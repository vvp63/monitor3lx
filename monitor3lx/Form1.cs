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
                    b_Add.Enabled = false;
                    tbFR_Addition.Enabled = false;
                    bFR_AddSave.Enabled = false;
                    b_exp_itteration.Enabled = false;
                    cb_AutoExp.Enabled = false;
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
            TextLog("gbt 1");
            FillDGVByQuery(dgvTPBalances, "SELECT * FROM public.\"TP_Balances_2\"");
            TextLog("gbt 2");
            FillDGVByQuery(dgvDelays, "SELECT * FROM public.\"Delays_ByStock\"");
            TextLog("gbt 3");
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
                    "SELECT sec_id, code, sec_type, hedge_kf, qty, qtyneed, \"Value\"::DECIMAL(16) " + 
                    "FROM public.\"Full_Balances_2\" WHERE tp_id = {0} ORDER BY code", gCurrTP_Balance)
                 );
                ColorFullBalance(4, 5);
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
        float gBArrowMove = 0.00025F;
        float gBSqArrowMove = 0.00000025F;

        private void EnterTpTable(object sender, DataGridViewCellEventArgs e)
        {
            TextLog("Enter TP table {0} {1}", e.RowIndex, dgvTP.Rows[e.RowIndex].Cells[1].Value.ToString());
            gCurrTPIdx = e.RowIndex;
            l_Kfs_with_TP.Text = "Kfs for " + dgvTP.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void b_Up_Click(object sender, EventArgs e)
        {
            if (gCurrTPIdx >= 0)
            {
                float vVCdir = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[9].Value.ToString(), out vVCdir);
                vVCdir += gBArrowMove;
                if (vVCdir >= 0) dgvTP.Rows[gCurrTPIdx].Cells[9].Value = Math.Round(vVCdir, 5).ToString();

                float vVSq = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[11].Value.ToString(), out vVSq);
                vVSq += gBSqArrowMove;
                if (vVSq >= 0) dgvTP.Rows[gCurrTPIdx].Cells[11].Value = Math.Round(vVSq, 8).ToString();
            }
        }

        private void b_down_Click(object sender, EventArgs e)
        {
            float vVCdir = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[9].Value.ToString(), out vVCdir);
            vVCdir -= gBArrowMove;
            if (vVCdir >= 0) dgvTP.Rows[gCurrTPIdx].Cells[9].Value = Math.Round(vVCdir, 5).ToString();
            float vVSq = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[11].Value.ToString(), out vVSq);
            vVSq -= gBSqArrowMove;
            if (vVSq >= 0) dgvTP.Rows[gCurrTPIdx].Cells[11].Value = Math.Round(vVSq, 8).ToString();
        }

        private void b_up_Inv(object sender, EventArgs e)
        {
            if (gCurrTPIdx >= 0)
            {
                float vVCinv = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[10].Value.ToString(), out vVCinv);
                vVCinv += gBArrowMove;
                if (vVCinv >= 0) dgvTP.Rows[gCurrTPIdx].Cells[10].Value = Math.Round(vVCinv, 5).ToString(); ;
                float vVSq = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[12].Value.ToString(), out vVSq);
                vVSq += gBSqArrowMove;
                if (vVSq >= 0) dgvTP.Rows[gCurrTPIdx].Cells[12].Value = Math.Round(vVSq, 8).ToString();
            }
        }

        private void b_down_Inv(object sender, EventArgs e)
        {
            if (gCurrTPIdx >= 0)
            {
                float vVCinv = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[10].Value.ToString(), out vVCinv);
                vVCinv -= gBArrowMove;
                if (vVCinv >= 0) dgvTP.Rows[gCurrTPIdx].Cells[10].Value = Math.Round(vVCinv, 5).ToString();
                float vVSq = -1; float.TryParse(dgvTP.Rows[gCurrTPIdx].Cells[12].Value.ToString(), out vVSq);
                vVSq -= gBSqArrowMove;
                if (vVSq >= 0) dgvTP.Rows[gCurrTPIdx].Cells[12].Value = Math.Round(vVSq, 8).ToString();
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




        //  Expiration

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


    }








}
