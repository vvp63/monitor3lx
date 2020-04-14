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


        public Form1()
        {
            InitializeComponent();
        }

        private void TextLog(string aLogStr, params object[] aParams)
        {
            tbLog.AppendText(string.Format(aLogStr, aParams) + "\r\n");
        }

        private void ConnClick(object sender, EventArgs e)
        {

            string  host = "195.138.210.152";
            string  username = "aquila";
            string  password = "SQL16384";
            string  keyFile = @"D:\Poliektov\tmp\sld\vv_dev\SshHostKeys\aquila_sec_ssh.ppk";
            string  passPharse = "moonspell";
            string  database = "MTS3pg";
            int     pgPort = 5432;
            int     fwdPort = 15432;
            

            ConnectionInfo ConnNfo = new ConnectionInfo(host, 22, username,
                new AuthenticationMethod[]{
                        // Key Based Authentication (using keys in OpenSSH Format)
                        new PrivateKeyAuthenticationMethod(username, new PrivateKeyFile[]  {
                                        new PrivateKeyFile(keyFile, passPharse)
                                    }),
                 }
              );
            
            gCl = new SshClient(ConnNfo);
            gCl.Connect();
            TextLog("SSH connected = {0}",  gCl.IsConnected);

            var port = new ForwardedPortLocal("127.0.0.1", (uint)fwdPort, "127.0.0.1", (uint)pgPort);
            gCl.AddForwardedPort(port);
            port.Start();

            TextLog("Port Forwarding = {0}", port.IsStarted);

           
            string vConnStr = string.Format("Host=127.0.0.1; Port={0}; Database={1}; Username={2}; Password={3};",
                                                fwdPort, database, username, password);
            gConn = new NpgsqlConnection(vConnStr);
            gConn.Open();
            TextLog("Postgres state = {0}", gConn.State);




            /*
            string vConnStr = "Host=195.138.210.152; Port=22; Username=aquila; Integrated Security=true; Database=MTS3Pg" +
                "Client Certificate=D:/distr/putty.org.ru/PuTTY PORTABLE/SshHostKeys/aquila_pub";
            NpgsqlConnection gConn = new NpgsqlConnection(vConnStr);
            gConn.Open();
            tbLog.AppendText(gConn.State.ToString());
            */

        }

        private void getTP(object sender, EventArgs e)
        {
            //
            if (gConn.State == ConnectionState.Open)
            {
                TextLog("Connection ok");
                using (var cmd = new NpgsqlCommand("SELECT * FROM public.securities", gConn))
                using (var dr = cmd.ExecuteReader()) {
                    DataTable vSchema = dr.GetSchemaTable();
                    foreach (DataRow myField in vSchema.Rows)
                    {
                        foreach (DataColumn myProperty in vSchema.Columns)
                            TextLog("{0} = {1}", myProperty.ColumnName, myField[myProperty]);
                    }
/*
                    while (dr.Read()) {
                        TextLog("---{0} {1} {2}", dr.FieldCount, dr[0], dr[1]);
                    }
                    */
                }

            }
        }
    }


    

}
