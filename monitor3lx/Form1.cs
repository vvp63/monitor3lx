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

        }

        private void getTP(object sender, EventArgs e)
        {
            //
            if (gConn.State == ConnectionState.Open)
            {
                TextLog("Connection ok");
                DataTable DT = new DataTable();
                DataSet DS = new DataSet();
                gTP_DA = new NpgsqlDataAdapter("SELECT * FROM public.tp", gConn);
                DS.Reset();
                gTP_DA.Fill(DS);
                DT = DS.Tables[0];
                dgvTP.DataSource = DT;
                dgvTP.Columns[1].MinimumWidth = 100;


                /*  using (var cmd = new NpgsqlCommand("SELECT * FROM public.securities", gConn))
                 using (var dr = cmd.ExecuteReader()) {
                    DataTable vSchema = dr.GetSchemaTable();
                     foreach (DataRow myField in vSchema.Rows)
                     {
                         foreach (DataColumn myProperty in vSchema.Columns)
                             TextLog("{0} = {1}", myProperty.ColumnName, myField[myProperty]);
                     }


                 } */

            }
        }

        private void updateTPclick(object sender, EventArgs e)
        {
            //
        }
    }


    

}
