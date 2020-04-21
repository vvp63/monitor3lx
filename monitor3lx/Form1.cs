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

        }



        private void getTPtable()
        {
            if (gConn.State == ConnectionState.Open)
            {
                DataTable DT = new DataTable();
                DataSet DS = new DataSet();
                gTP_DA = new NpgsqlDataAdapter("SELECT * FROM public.tp WHERE isactive = B'1' ORDER BY tpid", gConn);
                DS.Reset();
                gTP_DA.Fill(DS);
                DT = DS.Tables[0];
                dgvTP.DataSource = DT;
                dgvTP.Columns[1].MinimumWidth = 100;
            }
            else TextLog("No connection");
        }

        private void updateTPclick(object sender, EventArgs e)
        {        
            for (int i = 0; i < dgvTP.RowCount; i++)
            {
                string vUpdates = "";
                string vId = "";
                for (int j = 0; j < dgvTP.ColumnCount; j++)
                {
                    if (j == 0) vId = dgvTP.Rows[i].Cells[j].Value.ToString();
                    if (j > 2) 
                    vUpdates = vUpdates + dgvTP.Columns[j].HeaderText + " = " + 
                            (dgvTP.Columns[j].HeaderText == "hedgemode" ? "'" + dgvTP.Rows[i].Cells[j].Value.ToString() + "'" : dgvTP.Rows[i].Cells[j].Value.ToString());
                    if ((j > 2)  && (j < dgvTP.ColumnCount - 1)) vUpdates = vUpdates + ", ";
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
            getTPtable();

        }
    }


    

}
