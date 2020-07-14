using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;

namespace insa
{
    public partial class Form3 : MetroForm
    {
        Form2 a3;
        public Form3(Form2 a2)
        {
            InitializeComponent();
            a3 = a2;
        }
        OracleConnection pgOraConn;
        OracleCommand pgOraCmd;
        SqlDataAdapter adapter = null;
        SqlConnection conn = null;

        string dbIp = "222.237.134.74";
        string dbName = "Ora7";
        string dbId = "EDU";
        string dbPw = "edu1234";

        private void Form3_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            dataGridView1.Columns.Add("dept_code", "부서코드");
            dataGridView1.Columns.Add("dept_name", "부서명");

        }
        //try catch 추가 하셈
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            
           
            pgOraConn = new OracleConnection($"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1522)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
            pgOraConn.Open();
            pgOraCmd = pgOraConn.CreateCommand();
            string sql1 = "select * from THRM_DEPT_KJH where dept_edate is null and dept_name like '" + bas_dept.Text + "%'";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = pgOraConn;
            cmd.CommandText = sql1;
            OracleDataReader rd = cmd.ExecuteReader();
            
            int cnt = 0;
            
            while (rd.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[cnt].Cells["dept_code"].Value = rd["dept_code"].ToString();
                dataGridView1.Rows[cnt].Cells["dept_name"].Value = rd["dept_name"].ToString();

                cnt++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           string a1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string a2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            a3.aa1(a1,a2);
            
                Close();

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bas_dept_TextChanged(object sender, EventArgs e)
        {

        }
        //try catch 추가 하셈

        private void metroButton1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
    
            pgOraConn = new OracleConnection($"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1522)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
            pgOraConn.Open();
            pgOraCmd = pgOraConn.CreateCommand();
            string sql1 = "select * from THRM_DEPT_KJH where dept_edate is null and dept_name like '%" + bas_dept.Text + "%'";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = pgOraConn;
            cmd.CommandText = sql1;
            OracleDataReader rd = cmd.ExecuteReader();
            int cnt = 0;
            if (bas_dept.Text == "")
            {
                MessageBox.Show("검색하실 부서 이름을 입력해주세요.");
                return;

            }
            else
            {

                while (rd.Read())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[cnt].Cells["dept_code"].Value = rd["dept_code"].ToString();
                    dataGridView1.Rows[cnt].Cells["dept_name"].Value = rd["dept_name"].ToString();
                    return;
                   
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string a1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string a2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            a3.aa1(a1, a2);

            Close();
        }
    }
}
