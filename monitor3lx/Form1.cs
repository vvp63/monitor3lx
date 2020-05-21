using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Renci.SshNet;
using System.IO;



namespace monitor3lx
{
    public partial class Form1 : Form
    {

        SshClient gCl;
        NpgsqlConnection gConn;
        NpgsqlDataAdapter gTP_DA;
        int gCurrTP_Balance = 0;

        public Form1()
        {
            InitializeComponent();

            dgvTP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TextLog(string aLogStr, params object[] aParams)
        {
            tbLog.AppendText(string.Format(aLogStr, aParams) + "\r\n");
        }

        private void ConnClick(object sender, EventArgs e)
        {

            string  host =  monitor3lx.Properties.Settings.Default.SSHHost;
            string  localhost = "127.0.0.1";
            string  SSHusername = monitor3lx.Properties.Settings.Default.SSHusername;          
            string  keyFile = monitor3lx.Properties.Settings.Default.SSHKeyFile;
            string  passPharse = monitor3lx.Properties.Settings.Default.SSHPassPharse;
            string  database = monitor3lx.Properties.Settings.Default.PGDatabese;
            string  PGusername = monitor3lx.Properties.Settings.Default.PGusername;
            string  password = monitor3lx.Properties.Settings.Default.PGpass;
            int     pgPort = monitor3lx.Properties.Settings.Default.PGport;
            int     fwdPort = monitor3lx.Properties.Settings.Default.PGlocalport;
            
            ConnectionInfo ConnNfo = new ConnectionInfo(host, 22, SSHusername,
                new AuthenticationMethod[]{
                        // Key Based Authentication (using keys in OpenSSH Format)
                        new PrivateKeyAuthenticationMethod(SSHusername, new PrivateKeyFile[]  {
                                        new PrivateKeyFile(keyFile, passPharse)
                                    }),
                 }
              );
            
            gCl = new SshClient(ConnNfo);
            gCl.Connect();
            TextLog("SSH connection to {0}. State = {1}", host, gCl.IsConnected);

            var port = new ForwardedPortLocal(localhost, (uint)fwdPort, localhost, (uint)pgPort);
            gCl.AddForwardedPort(port);
            port.Start();

            TextLog("Port Forwarding {0} -> {1}. State = {2}", pgPort, fwdPort, port.IsStarted);

            string vConnStr = string.Format("Host={0}; Port={1}; Database={2}; Username={3}; Password={4};",
                                                localhost, fwdPort, database, PGusername, password);

            gConn = new NpgsqlConnection(vConnStr);
            gConn.Open();
            TextLog("Postgres state for DB {0} = {1}", database, gConn.State);
            getTPtable();
            getBalancesTable();
            FillFullBalance();
        }


        private void FillDGVByQuery(DataGridView aDGV, string aQuery)
        {
            if (gConn.State == ConnectionState.Open)
            {
                DataTable DT = new DataTable();
                DataSet DS = new DataSet();
                gTP_DA = new NpgsqlDataAdapter(aQuery, gConn);
                DS.Reset();
                gTP_DA.Fill(DS);
                DT = DS.Tables[0];
                aDGV.DataSource = DT;
                aDGV.Columns[1].MinimumWidth = 100;
            }
            else TextLog("No connection");

        }



        private void getTPtable()
        {
            FillDGVByQuery(dgvTP, "SELECT * FROM public.tp WHERE isactive = B'1' ORDER BY tpid");
        }

        private void updateTPclick(object sender, EventArgs e)
        {        
            getTPtable();
        }

        private void EditFinished(object sender, DataGridViewCellEventArgs e)
        {
            string vUpdates = "";
            string vId = "";
            for (int j = 0; j < dgvTP.ColumnCount; j++)
            {
                if (j == 0) vId = dgvTP.Rows[e.RowIndex].Cells[j].Value.ToString();
                if (j > 2)
                    vUpdates = vUpdates + dgvTP.Columns[j].HeaderText + " = " +
                            (dgvTP.Columns[j].HeaderText == "hedgemode" ? "'" + dgvTP.Rows[e.RowIndex].Cells[j].Value.ToString() + "'" : dgvTP.Rows[e.RowIndex].Cells[j].Value.ToString());
                if ((j > 2) && (j < dgvTP.ColumnCount - 1)) vUpdates = vUpdates + ", ";
            }
            vUpdates = vUpdates.Replace("False", "B'0'").Replace("True", "B'1'");
            string vUpdQuery = string.Format("UPDATE tp SET {0} WHERE tpid = {1}", vUpdates, vId);
            if (gConn.State == ConnectionState.Open)
            {
                NpgsqlCommand vComm = new NpgsqlCommand(vUpdQuery, gConn);
                vComm.ExecuteNonQuery();
            }
            else TextLog("No connection");

        }

        private void b_Apply_Click(object sender, EventArgs e)
        {
            if (gConn.State == ConnectionState.Open)
            {
                TextLog("Sending ini message");
                NpgsqlCommand vComm = new NpgsqlCommand(monitor3lx.Properties.Settings.Default.ApplyCommand, gConn);
                vComm.ExecuteNonQuery();
            }
            else TextLog("No connection");
        }



        private void getBalancesTable()
        {
            FillDGVByQuery(dgvTPBalances, "SELECT * FROM public.\"TP_Balances_2\"");
        }

        private void b_CurrPos_Click(object sender, EventArgs e)
        {
            getBalancesTable();
        }

        private void Click_TP_Balance(object sender, DataGridViewCellEventArgs e)
        {
            TextLog("{0} {1}", e.ColumnIndex, e.RowIndex);
            if (e.RowIndex >= 0)
            {
                int.TryParse(dgvTPBalances.Rows[e.RowIndex].Cells[0].Value.ToString(), out gCurrTP_Balance);
                l_TP_Balance.Text = String.Format("{0} (Id {1})", dgvTPBalances.Rows[e.RowIndex].Cells[1].Value.ToString(), gCurrTP_Balance);        
            }
            if (gCurrTP_Balance > 0)
            {
                FillDGVByQuery(dgvFullBalance, string.Format(
                    "SELECT sec_id, code, sec_type, hedge_kf, qty, qtyneed, qtybytrades, \"Value\"::DECIMAL(16), qtyoff, offresult::DECIMAL(16) " + 
                    "FROM public.\"Full_Balances_2\" WHERE tp_id = {0} ORDER BY code", gCurrTP_Balance)
                 );

            }
        }

        private void ClickFullBalance(object sender, EventArgs e)
        {
            FillFullBalance();
        }


        private void FillFullBalance()
        {
            gCurrTP_Balance = 0;
            l_TP_Balance.Text = "Full Balance";
            FillDGVByQuery(dgvFullBalance, "SELECT sec_id, code, SUM(qty) AS qty, SUM(qtyneed) AS qtyneed, SUM(qtybytrades) AS qtybytrades, " +
                    "SUM(\"Value\")::DECIMAL(16) AS \"Value\", SUM(offresult)::DECIMAL(16) AS offresult " +
                    "FROM public.\"Full_Balances_2\" GROUP BY sec_id, code ORDER BY code"
             );

        }


    }



    

}
