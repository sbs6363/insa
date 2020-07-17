using System;
using MetroFramework.Forms;
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


namespace insa
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            LoaduserId();
        }

        OracleConnection pgOraConn;
        OracleCommand pgOraCmd;
        SqlDataAdapter adapter = null;
        SqlConnection conn = null;

        string dbIp = "222.237.134.74";
        string dbName = "Ora7";
        string dbId = "EDU";
        string dbPw = "edu1234";
        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string sql="select * from thrm_login_kjh where admin_id='"+Id.Text+"' and admin_pass='" + Password.Text + "'";
            try
            {


                pgOraConn.Open();
                pgOraCmd = new OracleCommand(sql, pgOraConn);
                pgOraCmd.CommandType = CommandType.Text;
                OracleDataReader reader = pgOraCmd.ExecuteReader();


                if (Id.Text.Length >= 4 && Id.Text.Length <= 12)
                {
                    if (Password.Text.Length >= 6 && Password.Text.Length <= 16)
                    {

                        if (reader.Read())
                        {
                            string UserId = reader["admin_id"].ToString();
                            SaveUserId(UserId);
                            Form4 frm4 = new Form4(UserId + ':' + reader["admin_pass"].ToString(), this);
                            frm4.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("아이디나 패스워드가 잘못되었습니다.");
                        }
                        pgOraConn.Close();



                    }
                    else
                    {
                        MessageBox.Show("패스워드는 6자 이상 16자 이하이여야만 합니다.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("아이디는 4자 이상 12자 이하이여야만 합니다.");
                    return;
                }
                //e는 여기 있어서 못씀 ㅇ
            }catch(Exception e1)
            {
                Console.WriteLine(e1.ToString());
                MessageBox.Show("잘못된 접근입니다.");
                return;
            }
            finally
            {
                pgOraConn.Close();
            }

        }
        private void SaveUserId(String UserId)
        {

            if (saveid.Checked == true)
            {
                Properties.Settings.Default.id = UserId;
                Properties.Settings.Default.Save();
               
            }
            else
            {
                Properties.Settings.Default.id = "";
                Properties.Settings.Default.Save();
                

            }
        }
        private void LoaduserId()
        {
            string UserId = Properties.Settings.Default.id;
          
          
            if (!string.IsNullOrEmpty(UserId))
            {
                Id.Text = UserId;
                saveid.Checked = true;

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false; 
            pgOraConn = new OracleConnection($"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1522)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");

        }

        private void saveid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            string sql = "select * from thrm_login_kjh where admin_id='" + Id.Text + "' and admin_pass='" + Password.Text + "'";
            try
            {


                pgOraConn.Open();
                pgOraCmd = new OracleCommand(sql, pgOraConn);
                pgOraCmd.CommandType = CommandType.Text;
                OracleDataReader reader = pgOraCmd.ExecuteReader();


                if (Id.Text.Length >= 4 && Id.Text.Length <= 12)
                {
                    if (Password.Text.Length >= 6 && Password.Text.Length <= 16)
                    {

                        if (reader.Read())
                        {
                            string UserId = reader["admin_id"].ToString();
                            SaveUserId(UserId);
                            Form4 frm4 = new Form4(UserId + ':' + reader["admin_pass"].ToString(), this);
                            frm4.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("아이디나 패스워드가 잘못되었습니다.");
                        }
                        pgOraConn.Close();



                    }
                    else
                    {
                        MessageBox.Show("패스워드는 6자 이상 16자 이하이여야만 합니다.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("아이디는 4자 이상 12자 이하이여야만 합니다.");
                    return;
                }
                //e는 여기 있어서 못씀 ㅇ
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
                MessageBox.Show("잘못된 접근입니다.");
                return;
            }
            finally
            {
                pgOraConn.Close();
            }

        }

        private void Password_Enter(object sender, EventArgs e)
        {
         
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Form4 frm4 = new Form4();
                frm4.ShowDialog();
            }
            else
            {
                return;
            }
        }
    }
}
