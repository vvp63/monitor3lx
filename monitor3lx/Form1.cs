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
            dtpFR_date.Value = DateTime.Now.Date;
            dtp_MoveDate.Value = DateTime.Now.Date;
            tb_kfp.Text = monitor3lx.Properties.Settings.Default.SSHPassPharse;
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
            string  passPharse = tb_kfp.Text;
            string  database = monitor3lx.Properties.Settings.Default.PGDatabese;
            string  PGusername = monitor3lx.Properties.Settings.Default.PGusername;
            string  password = monitor3lx.Properties.Settings.Default.PGpass;
            int     pgPort = monitor3lx.Properties.Settings.Default.PGport;
            int     fwdPort = monitor3lx.Properties.Settings.Default.PGlocalport;
            int     SSHPort = monitor3lx.Properties.Settings.Default.SSHPort;


            ConnectionInfo ConnNfo = new ConnectionInfo(host, SSHPort, SSHusername,
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
            if (gConn.State == ConnectionState.Open)
            {
                b_Apply.Enabled = true;
                bUpdateTP.Enabled = true;
                tabControl_Main.Enabled = true;
                getTPtable();
                getBalancesTable();
                FillFullBalance();
                getTPComboBox();
                getAMtable();
                timer_keepconn.Enabled = true;

                //TextLog("Apply command '{0}'  Length={1}", monitor3lx.Properties.Settings.Default.ApplyCommand, monitor3lx.Properties.Settings.Default.ApplyCommand.Length);

                if (monitor3lx.Properties.Settings.Default.ApplyCommand.Length < 3)
                {
                    dgvTP.Enabled = false;
                    dgv_BC_Params.Enabled = false;
                    b_Apply.Enabled = false;
                    b_BC_Set.Enabled = false;
                    cb_BC_Autoreload.Enabled = false;
                    tb_BC_Interval.Enabled = false;
                    b_BC_newcountset.Enabled = false;
                    cb_CB_newautoreload.Enabled = false;
                    tb_BC_intervalnew.Enabled = false;
                    b_Add.Enabled = false;
                    tbFR_Addition.Enabled = false;
                    bFR_AddSave.Enabled = false;
                    b_exp_itteration.Enabled = false;
                    pan_ExpRed.Visible = false;
                    cb_AutoExp.Enabled = false;
                    p_Commands.Visible = false;
                    b_tps_savetp.Enabled = false;
                    b_tps_addupdate.Enabled = false;
                    b_tps_delete.Enabled = false;
                    b_copysec.Enabled = false;
                    b_tps_import.Enabled = false;
                    b_tps_restore.Enabled = false;
                    p_tps_copysec.Visible = false;
                    p_tps_import.Visible = false;
                    p_tps_sec.Visible = false;
                    p_tps_tp.Visible = false;
                    dgv_tps_list.ReadOnly = true;
                    dgv_tps_tpsec.Enabled = false;
                    dgv_tps_hedgekf.Enabled = false;
                    b_copysec.Enabled = false;
                }

            }
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



        private void FillCBByQuery(ComboBox aCB, string aQuery, string aVal, string aData)
        {
            if (gConn.State == ConnectionState.Open)
            {
                DataTable DT = new DataTable();
                DataSet DS = new DataSet();
                gTP_DA = new NpgsqlDataAdapter(aQuery, gConn);
                DS.Reset();
                gTP_DA.Fill(DS);
                DT = DS.Tables[0];
                aCB.DataSource = DT;
                aCB.ValueMember = aVal;
                aCB.DisplayMember = aData;
                aCB.SelectedIndex = 0;
            }
            else TextLog("No connection");
        }

        private void getTPtable()
        {
            FillDGVByQuery(dgvTP, "SELECT * FROM public.tp WHERE isactive = B'1' ORDER BY tpid");
        }

        private void getTPComboBox()
        {
            FillCBByQuery(cbFR_TP, "select tpid, fullname FROM public.\"TPList\"", "tpid", "fullname");
            FillCBByQuery(cbFRH_TP, "select tpid, fullname FROM public.\"TPListService\"", "tpid", "fullname");
        }

        private void updateTPclick(object sender, EventArgs e)
        {        
            getTPtable();
        }

        private void EditFinished(object sender, DataGridViewCellEventArgs e)
        {
            SaveTPLine(e.RowIndex);
        }

        private void SaveTPLine(int aIdx)
        {
            string vUpdates = "";
            string vId = "";
            for (int j = 0; j < dgvTP.ColumnCount; j++)
            {
                if (j == 0) vId = dgvTP.Rows[aIdx].Cells[j].Value.ToString();
                if (j > 2)
                {
                    string vVal = dgvTP.Rows[aIdx].Cells[j].Value.ToString();
                    vVal = vVal.Replace(",", ".").Replace(" ", "");
                    vUpdates = vUpdates + dgvTP.Columns[j].HeaderText + " = " +
                            (dgvTP.Columns[j].HeaderText == "hedgemode" ? "'" + vVal + "'" : vVal);
                }
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
            Apply_proc();
        }

        private void Apply_proc()
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
            FillDGVByQuery(dgvDelays, "SELECT * FROM public.\"Delays_ByStock\"");
            l_chb_tpid.Text = "0";
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
                l_chb_tpid.Text = dgvTPBalances.Rows[e.RowIndex].Cells[0].Value.ToString();
                l_chb_secid.Text = "0";
            }
            if (gCurrTP_Balance > 0)
            {
                FillDGVByQuery(dgvFullBalance, string.Format(
                    "SELECT sec_id, code, sec_type, hedge_kf, qty, qtyneed, \"Value\"::DECIMAL(16) " + 
                    "FROM public.\"Full_Balances_2\" WHERE tp_id = {0} ORDER BY code", gCurrTP_Balance)
                 );
                ColorFullBalance(4, 5);
            }
        }



        private void BalancesClick(object sender, DataGridViewCellEventArgs e)
        {
            l_chb_secid.Text = dgvFullBalance.Rows[e.RowIndex].Cells[0].Value.ToString();
        }


        private void ClickFullBalance(object sender, EventArgs e)
        {
            FillFullBalance();
        }

        private void FillFullBalance()
        {
            gCurrTP_Balance = 0;
            l_TP_Balance.Text = "Full Balance";
            l_chb_tpid.Text = "0";
            l_chb_secid.Text = "0";
            FillDGVByQuery(dgvFullBalance, "SELECT sec_id, code, SUM(qty) AS qty, SUM(qtyneed) AS qtyneed, SUM(\"Value\")::DECIMAL(16) AS \"Value\" " +
                    "FROM public.\"Full_Balances_2\" GROUP BY sec_id, code ORDER BY code"
             );
            ColorFullBalance(2, 3);
        }

        private void WrongData(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
            MessageBox.Show("Возможно использован неверный разделитель десятичной части (. или ,)", "Неверный формат значения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ColorFullBalance(int aidx1, int aidx2)
        {
            for (int i = 0; i < dgvFullBalance.RowCount; i++)
                if (dgvFullBalance.Rows[i].Cells[aidx1].Value.ToString() != dgvFullBalance.Rows[i].Cells[aidx2].Value.ToString())
                    dgvFullBalance.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                else
                    dgvFullBalance.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;

        }

        //      --------------------------  Service Functions    ------------------------------------------  //

        int gCurrTPIdx = 0;
        float gBArrowMove = 1E-3F;
        float gBSqArrowMove = 1E-6F;

        private void EnterTpTable(object sender, DataGridViewCellEventArgs e)
        {
            TextLog("Enter TP table {0} {1}", e.RowIndex, dgvTP.Rows[e.RowIndex].Cells[1].Value.ToString());
            gCurrTPIdx = e.RowIndex;
            l_Kfs_with_TP.Text = "Kfs for " + dgvTP.Rows[e.RowIndex].Cells[1].Value.ToString();
        }



        private void b_ld_up_click(object sender, EventArgs e)
        {
            if (gCurrTPIdx >= 0)
            {
                float vVCdir = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[9].Value.ToString(), out vVCdir);
                float vVSq = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[11].Value.ToString(), out vVSq);
                float vLArrowMove = 0; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[25].Value.ToString(), out vLArrowMove);
                float vSQdiv = 0; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[26].Value.ToString(), out vSQdiv);
                float vSQArrowMove = 0; if (vSQdiv != 0) vSQArrowMove = vLArrowMove / vSQdiv;
                vVCdir += vLArrowMove;
                vVSq += vSQArrowMove;          
                if (vVCdir >= 0) dgvTP.Rows[gCurrTPIdx].Cells[9].Value = Math.Round(vVCdir, 8).ToString();
                if (vVSq >= 0) dgvTP.Rows[gCurrTPIdx].Cells[11].Value = Math.Round(vVSq, 12).ToString();
            }
        }

        private void b_ld_down_click(object sender, EventArgs e)
        {
            if (gCurrTPIdx >= 0)
            {
                float vVCdir = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[9].Value.ToString(), out vVCdir);
                float vVSq = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[11].Value.ToString(), out vVSq);
                float vLArrowMove = 0; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[25].Value.ToString(), out vLArrowMove);
                float vSQdiv = 0; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[26].Value.ToString(), out vSQdiv);
                float vSQArrowMove = 0; if (vSQdiv != 0) vSQArrowMove = vLArrowMove / vSQdiv;
                vVCdir -= vLArrowMove;
                vVSq -= vSQArrowMove;
                if (vVCdir >= 0) dgvTP.Rows[gCurrTPIdx].Cells[9].Value = Math.Round(vVCdir, 8).ToString();
                if (vVSq >= 0) dgvTP.Rows[gCurrTPIdx].Cells[11].Value = Math.Round(vVSq, 12).ToString();
            }
        }

        private void b_li_up_click(object sender, EventArgs e)
        {
            if (gCurrTPIdx >= 0)
            {
                float vVCdir = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[10].Value.ToString(), out vVCdir);
                float vVSq = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[12].Value.ToString(), out vVSq);
                float vLArrowMove = 0; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[25].Value.ToString(), out vLArrowMove);
                float vSQdiv = 0; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[26].Value.ToString(), out vSQdiv);
                float vSQArrowMove = 0; if (vSQdiv != 0) vSQArrowMove = vLArrowMove / vSQdiv;
                vVCdir += vLArrowMove;
                vVSq += vSQArrowMove;
                if (vVCdir >= 0) dgvTP.Rows[gCurrTPIdx].Cells[10].Value = Math.Round(vVCdir, 8).ToString();
                if (vVSq >= 0) dgvTP.Rows[gCurrTPIdx].Cells[12].Value = Math.Round(vVSq, 12).ToString();
            }
        }

        private void b_li_down_click(object sender, EventArgs e)
        {
            if (gCurrTPIdx >= 0)
            {
                float vVCdir = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[10].Value.ToString(), out vVCdir);
                float vVSq = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[12].Value.ToString(), out vVSq);
                float vLArrowMove = 0; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[25].Value.ToString(), out vLArrowMove);
                float vSQdiv = 0; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[26].Value.ToString(), out vSQdiv);
                float vSQArrowMove = 0; if (vSQdiv != 0) vSQArrowMove = vLArrowMove / vSQdiv;
                vVCdir -= vLArrowMove;
                vVSq -= vSQArrowMove;
                if (vVCdir >= 0) dgvTP.Rows[gCurrTPIdx].Cells[10].Value = Math.Round(vVCdir, 8).ToString();
                if (vVSq >= 0) dgvTP.Rows[gCurrTPIdx].Cells[12].Value = Math.Round(vVSq, 12).ToString();
            }
        }

        private void b_qd_up_click(object sender, EventArgs e)
        {
            if (gCurrTPIdx >= 0)
            {
                float vVSq = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[11].Value.ToString(), out vVSq);
                vVSq += gBSqArrowMove;
                if (vVSq >= 0) dgvTP.Rows[gCurrTPIdx].Cells[11].Value = Math.Round(vVSq, 8).ToString();
            }
        }


        private void KeepConnect(object sender, EventArgs e)
        {
            if (gConn.State == ConnectionState.Open) getBalancesTable();
        }


        //      -----------------------------   Finres (FR) ----------------------------------------------------    //


        private void bFR_CountClick(object sender, EventArgs e)
        {

            TextLog("{0} - {1}  IsToday = {2} TPID = {3}", dtpFR_date.Value, dtpFR_date.Value.AddDays(1), (dtpFR_date.Value == DateTime.Now.Date), cbFR_TP.SelectedValue);
            string vQuery = "SELECT * FROM ";
            if (dtpFR_date.Value == DateTime.Now.Date)
            {
                vQuery += String.Format("\"public\".\"FR_RevalAndTradesToNow\"({0}, '{1}')", 
                    cbFR_TP.SelectedValue, dtpFR_date.Value.ToString("yyyyMMdd")); 
            } else
            {
                vQuery += String.Format("\"public\".\"FR_RevalAndTradesToDate\"({0}, '{1}', '{2}')",
                    cbFR_TP.SelectedValue, dtpFR_date.Value.ToString("yyyyMMdd"), dtpFR_date.Value.AddDays(1).ToString("yyyyMMdd"));
            }
            FillDGVByQuery(dgvFR_Reval, vQuery);
            float vFr = 0;
            for (int i = 0; i < dgvFR_Reval.RowCount; i++) {

                float vpdkf = 1;
                float vTmp = 0;
                for (int j = 0; j < dgvFR_Reval.RowCount; j++)
                {
                    if (dgvFR_Reval.Rows[i].Cells[0].Value.ToString() == dgvFR_Reval.Rows[j].Cells[3].Value.ToString())
                    {
                        float vpdmult   =   1;
                        float vpdquot   =   10;
                        float.TryParse(dgvFR_Reval.Rows[j].Cells[4].Value.ToString(), out vpdmult);
                        float.TryParse(dgvFR_Reval.Rows[j].Cells[8].Value.ToString(), out vpdquot);
                        vpdkf = vpdmult * vpdquot / 10;
                    }
                }
     
                float.TryParse(dgvFR_Reval.Rows[i].Cells[dgvFR_Reval.ColumnCount - 1].Value.ToString(), out vTmp);
                vFr += vTmp * vpdkf;
            }
            lFR_FullResult.Text = String.Format("{0:C}", vFr);
            FR_ShowAddition();
            float vAdd = 0;
            float.TryParse(tbFR_Addition.Text, out vAdd);
            lFR_AddFull.Text = String.Format("{0:C}", (vFr + vAdd));
        }


        private void FR_ShowAddition()
        {
            //
            tbFR_Addition.Text = "0";
            if (gConn.State == ConnectionState.Open)
            {
                string vQuery = String.Format("SELECT addition FROM \"public\".\"Finres_Additions\" WHERE tpid={0} AND date='{1}'", cbFR_TP.SelectedValue, dtpFR_date.Value.ToString("yyyyMMdd"));
                //TextLog(vQuery);
                NpgsqlCommand vComm = new NpgsqlCommand(vQuery, gConn);
                NpgsqlDataReader vReader = vComm.ExecuteReader();
                while (vReader.Read())
                {
                    tbFR_Addition.Text = vReader[0].ToString();
                }
                vReader.Close();
            }
        }


        private void bFR_SaveAdd_Click(object sender, EventArgs e)
        {
            float vAdd = 0;
            float.TryParse(tbFR_Addition.Text, out vAdd);

            string vAddQuery = string.Format("SELECT * FROM \"public\".\"AddUpdateAddition\"('{0}-{1}-{2}', {3}, {4})",
                                                dtpFR_date.Value.Year, dtpFR_date.Value.Month, dtpFR_date.Value.Day, cbFR_TP.SelectedValue, vAdd);
            //TextLog(vAddQuery);
            if (gConn.State == ConnectionState.Open)
            {
                NpgsqlCommand vComm = new NpgsqlCommand(vAddQuery, gConn);
                vComm.ExecuteNonQuery();
            };
            bFR_CountClick(sender, e);

        }


        //      --------------------------  Basis Count (BC)    ------------------------------------------  //


        private void BC_Count_Click(object sender, EventArgs e)
        {
            BC_Count();
        }

        private void BC_Set_Click(object sender, EventArgs e)
        {
            BC_Count();
            BC_Set();
            Apply_proc();
        }

        private void BC_Count()
        {
            FillDGVByQuery(dgv_BC_settings, "SELECT * FROM \"public\".\"TP_Basis_Count_Full\"");
        }

        private void BC_Set()
        {
            for (int j = 0; j < dgv_BC_settings.Rows.Count; j++)
            {
                string vTpid    =   dgv_BC_settings.Rows[j].Cells[0].Value.ToString();
                string vBdir = dgv_BC_settings.Rows[j].Cells[14].Value.ToString();
                string vBinv = dgv_BC_settings.Rows[j].Cells[15].Value.ToString();
                string vQuoteStr = dgv_BC_settings.Rows[j].Cells[2].Value.ToString();
                float vQuote = 0;
                float.TryParse(vQuoteStr, out vQuote);
                TextLog("{0}   dir={1} inv={2}  quote = {3}", vTpid, vBdir, vBinv, vQuote);
                if (vQuote > 0)
                {
                    for (int i = 0; i < dgvTP.Rows.Count; i++)
                    {
                        if (dgvTP.Rows[i].Cells[0].Value.ToString() == vTpid)
                        {
                            dgvTP.Rows[i].Cells[5].Value = vBdir;
                            dgvTP.Rows[i].Cells[6].Value = vBinv;
                        }
                        SaveTPLine(i);
                    }
                }
                else dgv_BC_settings.Rows[j].DefaultCellStyle.BackColor = Color.LightPink;
            }
        }

        private void BC_Autoreload_check(object sender, EventArgs e)
        {
            //
            tb_BC_Interval.Enabled = !cb_BC_Autoreload.Checked;
            int vInterval = 60;
            int.TryParse(tb_BC_Interval.Text, out vInterval);
            timer_BC.Interval = vInterval * 1000;
            timer_BC.Enabled = cb_BC_Autoreload.Checked;
        }

        private void BC_Timer_Work(object sender, EventArgs e)
        {
            BC_Count();
            BC_Set();
            Apply_proc();
        }

        // 

        //      --------------------------  New BasisCounter    ------------------------------------------  //

        private void BC_countnew_click(object sender, EventArgs e)
        {
            BC_Count_new();
        }


        private void b_countsetnew_click(object sender, EventArgs e)
        {
            BC_Count_new();
            BC_Set_new();
            Apply_proc();
        }

        private void BC_Count_new()
        {
            FillDGVByQuery(dgv_BC_new, "SELECT * FROM \"public\".\"Basis_Count_New\"");
        }


        private void BC_Set_new()
        {
            for (int j = 0; j < dgv_BC_new.Rows.Count; j++)
            {
                string vTpid = dgv_BC_new.Rows[j].Cells[0].Value.ToString();
                string vBdir = dgv_BC_new.Rows[j].Cells[10].Value.ToString();
                string vBinv = dgv_BC_new.Rows[j].Cells[11].Value.ToString();
                string vQuoteStr = dgv_BC_new.Rows[j].Cells[3].Value.ToString();
                float vQuote = 0;
                float.TryParse(vQuoteStr, out vQuote);
                TextLog("{0}   dir={1} inv={2}  quote = {3}", vTpid, vBdir, vBinv, vQuote);
                if (vQuote > 0)
                {
                    for (int i = 0; i < dgvTP.Rows.Count; i++)
                    {
                        if (dgvTP.Rows[i].Cells[0].Value.ToString() == vTpid)
                        {
                            dgvTP.Rows[i].Cells[5].Value = vBdir;
                            dgvTP.Rows[i].Cells[6].Value = vBinv;
                        }
                        SaveTPLine(i);
                    }
                }
                else dgv_BC_new.Rows[j].DefaultCellStyle.BackColor = Color.LightPink;
            }
        }


        private void BC_Autoreload_checknew(object sender, EventArgs e)
        {
            //
            tb_BC_intervalnew.Enabled = !cb_CB_newautoreload.Checked;
            int vInterval = 60;
            int.TryParse(tb_BC_intervalnew.Text, out vInterval);
            timer_BC_new.Interval = vInterval * 1000;
            timer_BC_new.Enabled = cb_CB_newautoreload.Checked;
        }

        private void BC_Timer_New_Work(object sender, EventArgs e)
        {
            BC_Count_new();
            BC_Set_new();
            Apply_proc();
        }


        // 
        //      --------------------------  Basis counter params    ------------------------------------------  //

        private void BC_Enter(object sender, EventArgs e)
        {
            FillDGVByQuery(dgv_BC_Params, "SELECT \"TPId\", \"RepoPerc\", \"DivSumm\", \"Spread\" FROM \"public\".\"tp_basis_count\" WHERE \"IsActive\" = B'1' ORDER BY \"TPId\"");
        }

        private void BC_EndEdit(object sender, DataGridViewCellEventArgs e)
        {
            BC_SaveLine(e.RowIndex);
        }

        private void BC_SaveLine(int aIdx)
        {
            string vUpdates = "";
            string vId = "";
            for (int j = 0; j < dgv_BC_Params.ColumnCount; j++)
            {
                if (j == 0) vId = dgv_BC_Params.Rows[aIdx].Cells[j].Value.ToString();
                else
                {
                    string vVal = dgv_BC_Params.Rows[aIdx].Cells[j].Value.ToString();
                    vVal = vVal.Replace(",", ".").Replace(" ", "");
                    vUpdates = vUpdates + "\"" + dgv_BC_Params.Columns[j].HeaderText + "\" = " + vVal;
                }
                if ((j > 0) && (j < dgv_BC_Params.ColumnCount - 1)) vUpdates = vUpdates + ", ";
            }
            string vUpdQuery = string.Format("UPDATE tp_basis_count SET {0} WHERE \"TPId\" = {1}", vUpdates, vId);
            if (gConn.State == ConnectionState.Open)
            {
                NpgsqlCommand vComm = new NpgsqlCommand(vUpdQuery, gConn);
                vComm.ExecuteNonQuery();
            }
            else TextLog("No connection");
        }



        //      -----------------------------   Daily Finres (DFR) ----------------------------------------------------    //

        private void Show_FRH(object sender, EventArgs e)
        {
            string vQuery = "";
            switch (cbFRH_TP.SelectedValue.ToString())
            {
                case "9999999":
                    vQuery = "SELECT * FROM \"public\".\"AssetMoves_Full\" ORDER BY \"date\" DESC";
                    break;

                case "10000000":
                    vQuery = "SELECT * FROM \"public\".\"SummFinres_Full\" ORDER BY \"date\" DESC";
                    break;

                default:
                    vQuery = String.Format("SELECT * FROM \"public\".\"Daily_Finres_Add\" WHERE tpid = {0} ORDER BY \"date\" DESC", cbFRH_TP.SelectedValue);
                    break;
            }
            if (vQuery.Length > 1) FillDGVByQuery(dgvFRH, vQuery);
        }


        //      -----------------------------   Asset Move (AM) ----------------------------------------------------    //

        int vAmRowEnter = -1;

        private void getAMtable()
        {
            FillDGVByQuery(dgv_AssetMove, "SELECT * FROM public.asset_move ORDER BY date desc");
            vAmRowEnter = -1;
        }

        private void b_AddClick(object sender, EventArgs e)
        {
            float vVal = 0;
            float.TryParse(tb_Value.Text, out vVal);
            if (vVal != 0) {
                string vAddQuery = string.Format("INSERT INTO public.asset_move (date, value, comment) VALUES ('{0}-{1}-{2}', {3}, '{4}')",
                                                    dtp_MoveDate.Value.Year, dtp_MoveDate.Value.Month, dtp_MoveDate.Value.Day, vVal, cb_CommentsVar.Text);
                TextLog(vAddQuery);
                if (gConn.State == ConnectionState.Open)
                {
                    NpgsqlCommand vComm = new NpgsqlCommand(vAddQuery, gConn);
                    vComm.ExecuteNonQuery();
                };                
                getAMtable();
            }

        }

        private void kd_am_delete(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) && (vAmRowEnter >=0))
            {
                string vAMStr = string.Format("{0} Move={1}  ({2})", dgv_AssetMove.Rows[vAmRowEnter].Cells[1].Value,
                                            dgv_AssetMove.Rows[vAmRowEnter].Cells[2].Value, dgv_AssetMove.Rows[vAmRowEnter].Cells[3].Value);
                DialogResult result = MessageBox.Show("Delete asset move?", vAMStr, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //
                    string vDeleteQuery = string.Format("DELETE FROM public.asset_move WHERE id = {0}", dgv_AssetMove.Rows[vAmRowEnter].Cells[0].Value);
                    if (gConn.State == ConnectionState.Open)
                    {
                        NpgsqlCommand vComm = new NpgsqlCommand(vDeleteQuery, gConn);
                        vComm.ExecuteNonQuery();
                    };
                    getAMtable();
                }
            }
        }

        private void ce_am(object sender, DataGridViewCellEventArgs e)
        {
            vAmRowEnter = e.RowIndex;
        }

        private void b_loadParams_Click(object sender, EventArgs e)
        {
            FillDGVByQuery(dgv_LParams, "SELECT * FROM st.parameters");
        }




        //  -------------------------------   Expiration robot -----------------------

        private void b_State_click(object sender, EventArgs e)
        {
            ExpState();
        }

        private void b_itteration_click(object sender, EventArgs e)
        {
            ExpItteration();
        }

        private void ExpState()
        {
            FillDGVByQuery(dgv_Exp_Robotsett, "select * from public.exp_robot_state");
        }


        private void ExpItteration()
        {
            bool vSendVol = false;
            for (int i = 0; i < dgv_Exp_Robotsett.RowCount; i++)
            {
                string vTpid = dgv_Exp_Robotsett.Rows[i].Cells[0].Value.ToString();
                string vSecId = dgv_Exp_Robotsett.Rows[i].Cells[2].Value.ToString();
                string vActive = dgv_Exp_Robotsett.Rows[i].Cells[4].Value.ToString();
                string vBalance = dgv_Exp_Robotsett.Rows[i].Cells[6].Value.ToString();
                string vNextBalance = dgv_Exp_Robotsett.Rows[i].Cells[9].Value.ToString();
                string vReload = dgv_Exp_Robotsett.Rows[i].Cells[11].Value.ToString();

                TextLog("Expiration Itteration {0} {1} {2} {3} {4}", vTpid, vSecId, vActive, vNextBalance, vReload);

                if ((vBalance != vNextBalance) && (vActive == "True") && (vReload == "1"))
                {
                    string vIttQuery = string.Format("SELECT * FROM \"public\".\"ExpRobotItteration\"({0}, {1}, {2})", vTpid, vSecId, vNextBalance);
                    if (gConn.State == ConnectionState.Open)
                    {
                        NpgsqlCommand vComm = new NpgsqlCommand(vIttQuery, gConn);
                        vComm.ExecuteNonQuery();
                    };
                    vSendVol = true;
                }
            }

            if (vSendVol)
            {
                if (gConn.State == ConnectionState.Open)
                {
                    TextLog("Sending vol message");
                    NpgsqlCommand vComm = new NpgsqlCommand(monitor3lx.Properties.Settings.Default.VolCommand, gConn);
                    vComm.ExecuteNonQuery();
                }
                else TextLog("No connection");
            }

        }

        private void timer_ExpRobot(object sender, EventArgs e)
        {
            ExpState();
            ExpItteration();
        }

        private void cb_Exp_CchekChange(object sender, EventArgs e)
        {
            timer_exprobot.Enabled = cb_AutoExp.Checked;
        }





        // -------------------- TP  Structure ------------------------------------------

        private void TPStructEnter(object sender, EventArgs e)
        {
            TPListShow();
            SecToCopyShow();
        }

        private void TPListShow()
        {
            FillDGVByQuery(dgv_tps_list, "SELECT tpid, name, isactive FROM tp");
            FillCBByQuery(cb_tps_copyfrom, "SELECT tpid, name FROM tp", "tpid", "name");
            dgv_tps_list.Columns[0].ReadOnly = true;   
        }

        private void SecToCopyShow()
        {
            FillCBByQuery(cb_sec_to_copy, "SELECT securityid, '('|| securityid::text || ') ' || code AS fullname FROM securities ORDER BY securityid", "securityid", "fullname");
           // FillCBByQuery(cb_sec_to_copy, "SELECT securityid, code FROM securities ORDER BY code", "securityid", "code");
        }

        private void tps_tp_endedit(object sender, DataGridViewCellEventArgs e)
        {
            //
            string vQuery = String.Format("UPDATE tp SET name = '{0}', isactive = {1} WHERE tpid = {2}", dgv_tps_list.Rows[e.RowIndex].Cells[1].Value.ToString(), 
                        (dgv_tps_list.Rows[e.RowIndex].Cells[2].Value.ToString() == "True") ? "B'1'" : "B'0'", dgv_tps_list.Rows[e.RowIndex].Cells[0].Value.ToString() );
            if (gConn.State == ConnectionState.Open)
            {
                NpgsqlCommand vComm = new NpgsqlCommand(vQuery, gConn);
                vComm.ExecuteNonQuery();
            }
            else TextLog("No connection");
        }

        private void b_tps_savetp_Click(object sender, EventArgs e)
        {
            int vtpid = 0;
            int.TryParse(tb_tps_id.Text, out vtpid);
            if (vtpid > 0)
            {
                string vQuery = String.Format("select tps_add_tp({0}, '{1}', {2}, {3}, {4})", vtpid, tb_tps_name.Text, (cb_tps_active.Checked ? "B'1'" : "B'0'"), 
                                    (cb_tps_params.Checked ? cb_tps_copyfrom.SelectedValue : 0), (cb_tps_struct.Checked ? cb_tps_copyfrom.SelectedValue : 0));
                if (gConn.State == ConnectionState.Open)
                {
                    NpgsqlCommand vComm = new NpgsqlCommand(vQuery, gConn);
                    vComm.ExecuteNonQuery();
                }
                else TextLog("No connection");
                TPListShow();
            }
            else
            {
                TextLog("TP Id incorrect");
            }
        }

        private void tps_tp_enter(object sender, DataGridViewCellEventArgs e)
        {
            l_tps_tpid.Text = dgv_tps_list.Rows[e.RowIndex].Cells[0].Value.ToString();
            b_tps_deltp.Enabled = (dgv_tps_list.Rows[e.RowIndex].Cells[2].Value.ToString() != "True");
            l_tps_tpid1.Text = dgv_tps_list.Rows[e.RowIndex].Cells[0].Value.ToString();
            string vTpid = dgv_tps_list.Rows[e.RowIndex].Cells[0].Value.ToString();
            tps_tpsec_reload(vTpid);
        }

        private void tps_tpsec_reload(string aTpid)
        {
            FillDGVByQuery(dgv_tps_tpsec,
                String.Format("SELECT sec_id, code, accountid, sec_type, hedge_kf, pd_kf, pdtosecid, pdcode, p2p_kf FROM public.\"tps_tpsec\" WHERE tp_id = {0}", aTpid));
            for (int i = 0; i < dgv_tps_tpsec.RowCount; i++)
            {
                if (dgv_tps_tpsec.Rows[i].Cells[3].Value.ToString() == "B") dgv_tps_tpsec.Rows[i].DefaultCellStyle.BackColor = Color.LawnGreen;
                if (dgv_tps_tpsec.Rows[i].Cells[3].Value.ToString() == "P") dgv_tps_tpsec.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                if (dgv_tps_tpsec.Rows[i].Cells[3].Value.ToString() == "E") dgv_tps_tpsec.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            }

            FillCBByQuery(cb_tps_code, "SELECT securityid, code FROM securities ORDER BY code", "securityid", "code");
            FillCBByQuery(cb_tps_sectype, "SELECT code, type FROM tps_sectypes ORDER BY code", "code", "type");
            FillCBByQuery(cb_tps_acc, "SELECT id, acc FROM tps_accs ORDER BY id", "id", "acc");
            FillCBByQuery(cb_tps_acc1, "SELECT id, acc FROM tps_accs ORDER BY id", "id", "acc");
            FillCBByQuery(cb_tps_pdfor, String.Format("SELECT sec_id, code FROM public.\"tps_tpsec\" WHERE tp_id = {0}", aTpid), "sec_id", "code");
        }

        private void tps_tpsec_enter(object sender, DataGridViewCellEventArgs e)
        {
            cb_tps_code.SelectedValue = dgv_tps_tpsec.Rows[e.RowIndex].Cells[0].Value.ToString();
            cb_tps_acc.SelectedValue = dgv_tps_tpsec.Rows[e.RowIndex].Cells[2].Value.ToString();
            cb_tps_sectype.SelectedValue = dgv_tps_tpsec.Rows[e.RowIndex].Cells[3].Value.ToString();
            cb_tps_pdfor.SelectedValue = dgv_tps_tpsec.Rows[e.RowIndex].Cells[6].Value.ToString();

            tb_tps_hedgekf.Text = dgv_tps_tpsec.Rows[e.RowIndex].Cells[4].Value.ToString();
            tb_tps_pdkf.Text = dgv_tps_tpsec.Rows[e.RowIndex].Cells[5].Value.ToString();
            tb_tps_p2pkf.Text = dgv_tps_tpsec.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void tps_activate_pd(object sender, EventArgs e)
        {
            cb_tps_pdfor.Enabled = (cb_tps_sectype.SelectedValue.ToString() == "P");
        }

        private void b_tps_addupdate_click(object sender, EventArgs e)
        {
            int vTpId = 0; int.TryParse(l_tps_tpid.Text, out vTpId);
            int vSecId = 0; int.TryParse(cb_tps_code.SelectedValue.ToString(), out vSecId);
            int vAccId = 0; int.TryParse(cb_tps_acc.SelectedValue.ToString(), out vAccId);
            int vPdtosecid = 0; if (cb_tps_pdfor.Enabled) int.TryParse(cb_tps_pdfor.SelectedValue.ToString(), out vPdtosecid);
            float vHedgeKf = 0; float.TryParse(tb_tps_hedgekf.Text, out vHedgeKf);
            float vPdKf = 0; float.TryParse(tb_tps_pdkf.Text, out vPdKf);
            float vP2pKf = 0; float.TryParse(tb_tps_p2pkf.Text, out vP2pKf);

            bool vAct = true;

            if (vSecId == vPdtosecid)
            {
                vAct = false;
                DialogResult dialogResult = MessageBox.Show("Security cannot be pricedriver to itself!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (cb_tps_sectype.SelectedValue.ToString() == "B")
                {
                    DialogResult dialogResult = MessageBox.Show("Only one Base security allowed! All others will be replaced!", "Are You sure?", MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.Yes) vAct = false;
                }
                if (cb_tps_sectype.SelectedValue.ToString() == "E")
                {
                    DialogResult dialogResult = MessageBox.Show("Only one Etalon security allowed! All others will be replaced!", "Are You sure?", MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.Yes) vAct = false;
                }
                if (cb_tps_sectype.SelectedValue.ToString() == "P")
                {
                    DialogResult dialogResult = MessageBox.Show(String.Format("Only one Pricedriver for security {0} allowed! All others will be replaced!", vPdtosecid), "Are You sure?", MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.Yes) vAct = false;
                }
            }

            if (vAct) {
                if ((vTpId > 0) && (vSecId > 0) && (vAccId > 0))
                {
                    string vQuery = String.Format("select tps_addupdate_tpsec({0}, {1}, {2}, '{3}', {4}, {5}, {6}, {7})",
                                            vTpId, vSecId, vAccId, cb_tps_sectype.SelectedValue.ToString(),
                                            vHedgeKf.ToString().Replace(',', '.'), vPdKf.ToString().Replace(',', '.'), vPdtosecid, vP2pKf.ToString().Replace(',', '.'));
                    if (gConn.State == ConnectionState.Open)
                    {
                        NpgsqlCommand vComm = new NpgsqlCommand(vQuery, gConn);
                        vComm.ExecuteNonQuery();
                        tps_tpsec_reload(l_tps_tpid.Text);
                    }
                    else TextLog("No connection");
                }
                else
                {
                    TextLog("TP, security or account undefined");
                }
                tps_tpsec_reload(l_tps_tpid.Text);
            }

        }


        private void b_tps_delete_click(object sender, EventArgs e)
        {
            int vTpId = 0; int.TryParse(l_tps_tpid.Text, out vTpId);
            int vSecId = 0; int.TryParse(cb_tps_code.SelectedValue.ToString(), out vSecId);
            int vAccId = 0; int.TryParse(cb_tps_acc.SelectedValue.ToString(), out vAccId);
            DialogResult dialogResult = MessageBox.Show(String.Format("Deleting {0} ({1}) from {2}", cb_tps_code.Text, vAccId, vTpId),
                                                        "Delete security from tradepair?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string vQuery = String.Format("select tps_addupdate_tpsec({0}, {1}, {2}, 'D', 0, 0, 0, 0)", vTpId, vSecId, vAccId);
                if (gConn.State == ConnectionState.Open)
                {
                    NpgsqlCommand vComm = new NpgsqlCommand(vQuery, gConn);
                    vComm.ExecuteNonQuery();
                    tps_tpsec_reload(l_tps_tpid.Text);
                }
                else TextLog("No connection");
            }           
        }

        private void tps_buffer_insert(object sender, KeyEventArgs e)
        {
            if ((e.Control) && (e.KeyCode == Keys.V))
            {
                int vStartRI = dgv_tps_hedgekf.SelectedCells[0].RowIndex;
                int vStartCI = dgv_tps_hedgekf.SelectedCells[0].ColumnIndex;
                TextLog("Ctrl-V pos [{0} {1}]", vStartRI, vStartCI);
                String[] vCbLines = Clipboard.GetText().Split('\n');
                dgv_tps_hedgekf.RowCount = vStartRI + vCbLines.Length;
                for (int i = 0; i < vCbLines.Length; i++)
                {
                    String[] vCbItems = vCbLines[i].Split('\t');
                    for (int j = 0; j < vCbItems.Length; j++)
                    {
                        TextLog("Clipboard item [{0} {1}] {2}", i, j, vCbItems[j]);
                        int vCurrRI = vStartRI + i;
                        int vCurrCI = vStartCI + j;
                        if ((vCurrRI < dgv_tps_hedgekf.RowCount) && (vCurrCI < dgv_tps_hedgekf.ColumnCount))
                            dgv_tps_hedgekf.Rows[vCurrRI].Cells[vCurrCI].Value = vCbItems[j];
                    }
                }
            }              
        }

        private void tps_import_click(object sender, EventArgs e)
        {
            int vTpId = 0; int.TryParse(l_tps_tpid1.Text, out vTpId);
            int vAccId = 0; int.TryParse(cb_tps_acc1.SelectedValue.ToString(), out vAccId);
            DialogResult dialogResult = MessageBox.Show(String.Format("This will delete all hedge securities from traidpair {0}", vTpId),
                                                        "Import securities?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (gConn.State == ConnectionState.Open)
                {

                    NpgsqlCommand vComm = new NpgsqlCommand(String.Format("select tps_backup_tpsec({0})", vTpId), gConn);
                    vComm.ExecuteNonQuery();
                    for (int i = 0; i < dgv_tps_hedgekf.RowCount - 1; i++)
                    {
                        string vcode = dgv_tps_hedgekf.Rows[i].Cells[0].Value.ToString();
                        if (vcode.Length > 0)
                        {
                            float vHedgeKf = 0; float.TryParse(dgv_tps_hedgekf.Rows[i].Cells[1].Value.ToString(), out vHedgeKf);
                            string vQuery = String.Format("select tps_import_security({0}, {1}, '{2}', {3})", vTpId, vAccId, vcode, vHedgeKf.ToString().Replace(',', '.'));
                            TextLog(vQuery);
                            string vQres = "";
                            NpgsqlCommand vCommSec = new NpgsqlCommand(vQuery, gConn);
                            NpgsqlDataReader vReader = vCommSec.ExecuteReader();
                            while (vReader.Read())
                            {
                                vQres = vReader[0].ToString();
                            }
                            vReader.Close();
                            if (vQres != "0") dgv_tps_hedgekf.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                            else dgv_tps_hedgekf.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                }
                else TextLog("No connection");
                tps_tpsec_reload(vTpId.ToString());
            }

        }

        private void tps_restore_click(object sender, EventArgs e)
        {
            int vTpId = 0; int.TryParse(l_tps_tpid1.Text, out vTpId);
            DialogResult dialogResult = MessageBox.Show(String.Format("This will restore hedge securities in traidpair {0}", vTpId),
                                            "Restore?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (gConn.State == ConnectionState.Open)
                {
                    NpgsqlCommand vComm = new NpgsqlCommand(String.Format("select tps_restore_tpsec({0})", vTpId), gConn);
                    vComm.ExecuteNonQuery();
                }
                else TextLog("No connection");
                tps_tpsec_reload(vTpId.ToString());
            }
        }



        private void cb_tps_sectocopy_changed(object sender, EventArgs e)
        {
            // 
            string[] vidcode = cb_sec_to_copy.Text.Split(' ');
            if  (vidcode.Length > 1)
            {
                tb_newid.Text = vidcode[0].Substring(1, vidcode[0].Length - 2);
                tb_new_code.Text = vidcode[1];
            }

        }

        private void b_tps_copysec_click(object sender, EventArgs e)
        {
            int vsecid = 0;
            int.TryParse(tb_newid.Text, out vsecid);
            if (vsecid > 0)
            {
                if (gConn.State == ConnectionState.Open)
                {
                    int vseccount = 1;
                    string vQuery = String.Format("SELECT count(*) FROM securities WHERE securityid = {0} OR code ='{1}'", vsecid, tb_new_code.Text);
                    NpgsqlCommand vComm = new NpgsqlCommand(vQuery, gConn);
                    NpgsqlDataReader vReader = vComm.ExecuteReader();
                    while (vReader.Read())
                    {
                        int.TryParse(vReader[0].ToString(), out vseccount);
                    }
                    vReader.Close();
                    if (vseccount > 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("SecurityId or code already exists!", "Security copy error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string vCopyQuery = String.Format("SELECT copysecurity({0}, {1}, '{2}')", cb_sec_to_copy.SelectedValue.ToString(), vsecid, tb_new_code.Text);
                        TextLog(vCopyQuery);
                        NpgsqlCommand vCopyComm = new NpgsqlCommand(vCopyQuery, gConn);
                        vCopyComm.ExecuteNonQuery();
                        DialogResult dialogResult = MessageBox.Show(String.Format("Security {0} {1} added", vsecid, tb_new_code.Text), "Security copy ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SecToCopyShow();
                    }
                }
            }
            else {
                DialogResult dialogResult = MessageBox.Show("Security id is incorrect", "SecurityId error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void tps_deltp_click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(String.Format("This will delete tp {0} and all it structure", l_tps_tpid.Text),
                                "Are you shure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string vQuery = String.Format("select public.\"_User_DeleteTp\"({0})", l_tps_tpid.Text);
                if (gConn.State == ConnectionState.Open)
                {
                    NpgsqlCommand vComm = new NpgsqlCommand(vQuery, gConn);
                    vComm.ExecuteNonQuery();
                    TPListShow();
                }
                else TextLog("No connection");
            }
        }


        // -------------------- Messages ------------------------------------------

        private void mess_send(object sender, EventArgs e)
        {
            if (gConn.State == ConnectionState.Open)
            {
                string vMessage = (sender as Button).Text;
                TextLog("Sending {0} message", vMessage);
                string vQuery = monitor3lx.Properties.Settings.Default.ApplyCommand.Replace("'i'", String.Format("'{0}'", vMessage));
                NpgsqlCommand vComm = new NpgsqlCommand(vQuery, gConn);
                vComm.ExecuteNonQuery();
            }
            else TextLog("No connection");         
        }


        // -------------------- Change balance ------------------------------------------

        private void b_AddBalance_Click(object sender, EventArgs e)
        {
            int vtpid = 0;
            int vsecid = 0;
            int vqty = 0;
            float vprice = 0;
            float vvalue = 0;
            int.TryParse(l_chb_tpid.Text, out vtpid);
            int.TryParse(l_chb_secid.Text, out vsecid);
            int.TryParse(tb_qty.Text, out vqty);
            float.TryParse(tb_price.Text, out vprice);
            float.TryParse(tb_val.Text, out vvalue);

            if ( (vtpid > 0) && (vsecid > 0) && (vqty > 0) && (vprice > 1e-12) && (vvalue > 1e-12) )
            {

                DialogResult dialogResult = MessageBox.Show(String.Format("This will change balance in tp {0} security {1}", vtpid, vsecid),
                                    "Are you shure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string vQuery = String.Format("select public.\"BalanceMove\"({0}, {1}, '{2}', {3}, {4}, {5})",
                                                    vtpid, vsecid, cb_buysell.Text, vqty, vprice.ToString().Replace(',', '.'), vvalue.ToString().Replace(',', '.'));
                    TextLog(vQuery);
                    if (gConn.State == ConnectionState.Open)
                    {
                        NpgsqlCommand vComm = new NpgsqlCommand(vQuery, gConn);
                        vComm.ExecuteNonQuery();
                        TPListShow();
                    }
                    else TextLog("No connection");
                }

            } else
            {
                DialogResult dialogResult = MessageBox.Show("Some parameters are wrong. Check tp and security id and usage , or . in price and value",
                                                                "Parameters error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }






    }





}
