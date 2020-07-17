using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;


namespace insa
{
    public partial class Form6 : MetroForm
    {
        public Form6()
        {
            InitializeComponent();
        }
        OracleConnection pgOraConn;
        OracleCommand pgOraCmd;
        SqlDataAdapter adapter = null;
        SqlConnection conn = null;

        string dbIp = "222.237.134.74";
        string dbName = "Ora7";
        string dbId = "EDU";
        string dbPw = "edu1234";
        public Form6(int tabindexNumber)
        {
            InitializeComponent();
        }
        public void changeTabControlPage(int tabIndexNumber)
        {
            tabControl1.SelectedIndex = tabIndexNumber;

        }
        private void Form6_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            dataGridView4.Columns.Add("dept_code", "부서코드");
            dataGridView4.Columns.Add("dept_name", "부서명");

            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();


            pgOraConn = new OracleConnection($"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1522)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
            pgOraConn.Open();
            pgOraCmd = pgOraConn.CreateCommand();
            string sql1 = "select dept_code,dept_name from THRM_DEPT_KJH";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = pgOraConn;
            cmd.CommandText = sql1;
            OracleDataReader rd = cmd.ExecuteReader();

            int cnt = 0;
               
            while (rd.Read())
            {
                dataGridView4.Rows.Add();
                dataGridView4.Rows[cnt].Cells["dept_code"].Value = rd["dept_code"].ToString();
                dataGridView4.Rows[cnt].Cells["dept_name"].Value = rd["dept_name"].ToString();

                cnt++;
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.TabIndex == 0)
            {
                this.MaximizeBox = false;
                
                dataGridView4.Columns.Add("dept_code", "부서코드");
                dataGridView4.Columns.Add("dept_name", "부서명");
             
            }
            else if (tabControl1.SelectedTab.TabIndex == 1)
            {
                this.MaximizeBox = false;

                dataGridView3.Columns.Add("dept_code", "부서코드");
                dataGridView3.Columns.Add("dept_name", "부서명");

            }
            else if (tabControl1.SelectedTab.TabIndex == 2)
            {
                this.MaximizeBox = false;
                dataGridView2.Columns.Add("dept_code", "부서코드");
                dataGridView2.Columns.Add("dept_name", "부서명");
            }
            else if (tabControl1.SelectedTab.TabIndex == 3)
            {
                this.MaximizeBox = false; 
                dataGridView1.Columns.Add("dept_code", "부서코드");
                dataGridView1.Columns.Add("dept_name", "부서명");
            }
        }

    }
}

