using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using MetroFramework.Forms;
using System.Data.SqlClient;
namespace insa
{
    public partial class Form2 : MetroForm
    {
        private int NowTabIndex;
        public Form2()
        {
            InitializeComponent();
            SetupdataGridView1();
            clearTextBox();
            NowTabIndex = 0;

        }
        OracleConnection pgOraConn;
        OracleCommand pgOraCmd;
        public Form2(int tablNumber)
        {
            InitializeComponent();
            SetupdataGridView1();
            clearTextBox();
            NowTabIndex = tablNumber;
            //tabControl1.TabIndex = NowTabIndex;
        }
        public void changeTabControlPage(int tabIndexNumber)
        {
            tabControl1.SelectedIndex = tabIndexNumber;
        }
        string dbIp = "222.237.134.74";
        string dbName = "Ora7";
        string dbId = "EDU";
        string dbPw = "edu1234";



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SetupdataGridView1()
        {



        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            bas_rmk.Text += Environment.NewLine;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.TabIndex == 0)
            {
                bas_empno.Focus();
                clearTextBox();
                MessageBox.Show("인사기본사항을 입력하세요.");
                btn_control1();
                checktext.Text = "I";
                bas_emp_sdate.Enabled = false;
                bas_emp_edate.Enabled = false;
                bas_entdate.Enabled = false;
                bas_resdate.Enabled = false;
                bas_reidate.Enabled = false;
                bas_levdate.Enabled = false;
                bas_pos_dt.Enabled = false;
                bas_dut_dt.Enabled = false;
                bas_dept_dt.Enabled = false;
                bas_intern_dt.Enabled = false;
                bas_emp_sdate.Format = DateTimePickerFormat.Custom;
                bas_emp_edate.Format = DateTimePickerFormat.Custom;
                bas_entdate.Format = DateTimePickerFormat.Custom;
                bas_resdate.Format = DateTimePickerFormat.Custom;
                bas_levdate.Format = DateTimePickerFormat.Custom;
                bas_reidate.Format = DateTimePickerFormat.Custom;
                bas_pos_dt.Format = DateTimePickerFormat.Custom;
                bas_dut_dt.Format = DateTimePickerFormat.Custom;
                bas_dept_dt.Format = DateTimePickerFormat.Custom;
                bas_intern_dt.Format = DateTimePickerFormat.Custom;
            }
            else if (tabControl1.SelectedTab.TabIndex == 1)
            {
                //fam_empno 텍스트 박스가 비어 있거나 공백 문자로 구성되어 있을 경우 발생하는 문구
                if (String.IsNullOrWhiteSpace(fam_empno.Text))
                {
                    MessageBox.Show("인사기본사항에서 사원번호를 입력해주세요.");
                    return;
                }
                else
                {

                    btn_control1();
                    checktext.Text = "F_i";
                    MessageBox.Show("가족사항을 입력해주세요.");
                    fam_ltg.Text = "Y";
                    fam_name.Focus();
                    fam_bth.Format = DateTimePickerFormat.Short;
                }



            }
            else if (tabControl1.SelectedTab.TabIndex == 2)
            {
                if (String.IsNullOrWhiteSpace(edu_empno.Text))
                {
                    MessageBox.Show("학력사항에서 사원번호를 입력해주세요.");
                    return;
                }
                else
                {
                    btn_control1();
                    checktext.Text = "E_i";
                    MessageBox.Show("학력사항을 입력해주세요.");
                    edu_loe.Text = "대학교";
                    edu_last.Text = "N";
                    edu_gra.Text = "졸업";
                    edu_degree.Text = "학사";
                    edu_schnm.Text = "";
                    edu_dept.Text = "";
                    edu_grade.Text = "";
                    edu_loe.Focus();
                    edu_entdate.Format = DateTimePickerFormat.Short;
                    edu_gradate.Format = DateTimePickerFormat.Short;
                }
            }
            else if (tabControl1.SelectedTab.TabIndex == 3)
            {
                if (String.IsNullOrWhiteSpace(award_empno.Text))
                {
                    MessageBox.Show("인사기본사항에서 사원번호를 입력해주세요");
                    return;
                }
                else
                {
                    btn_control1();
                    checktext.Text = "A_i";
                    MessageBox.Show("상벌이력을 입력해주세요.");



                }
            }
            else if (tabControl1.SelectedTab.TabIndex == 4)
            {
                if (String.IsNullOrWhiteSpace(car_empno.Text))
                {
                    MessageBox.Show("경력사항에서 사원번호를 입력해주세요");
                    return;
                }
                else
                {
                    btn_control1();
                    checktext.Text = "C_i";
                    MessageBox.Show("경력사항을 입력해주세요.");
                    car_com.Text = "";
                    car_region.Text = "";
                    car_yyyymm_f.Text = "";
                    car_yyyymm_t.Text = "";

                    car_job.Text = "";
                    car_reason.Text = "";
                }

            }
            else if (tabControl1.SelectedTab.TabIndex == 5)
            {
                if (String.IsNullOrWhiteSpace(lic_empno.Text))
                {
                    MessageBox.Show("자격면허에서 사원번호를 입력해주세요");
                    return;
                }
                else
                {
                    btn_control1();
                    checktext.Text = "L_i";
                    MessageBox.Show("자격면허를 입력해주세요.");
                    lic_code.Text = "";
                    lic_grade.Text = "";
                    lic_acqdate.Text = "";
                    lic_organ.Text = "";


                }
            }
            else if (tabControl1.SelectedTab.TabIndex == 6)
            {
                if (String.IsNullOrWhiteSpace(forl_empno.Text))
                {
                    MessageBox.Show("인사기본사항에서 사원번호를 입력해주세요");
                    return;
                }
                else
                {
                    btn_control1();
                    checktext.Text = "Fo_i";
                    MessageBox.Show("외국어 정보를 입력해주세요.");
                    lic_code.Text = "";
                    lic_grade.Text = "";
                    lic_acqdate.Text = "";
                    lic_organ.Text = "";

                }
            }
        }
        private void sabun_display()
        {

            //data 읽어오기
            String sabun_sql = "select bas_empno,bas_resno,bas_name,bas_cname,bas_ename,bas_fix,bas_zip,bas_addr,bas_residence,bas_hdpno,bas_telno,bas_email,bas_mil_sta,bas_mil_mil,bas_mil_rnk,bas_mar,bas_acc_bank1,bas_acc_name1,bas_acc_no1,bas_acc_bank2,bas_acc_name2,bas_acc_no2,bas_cont,bas_intern,bas_intern_no,bas_emp_sdate,bas_emp_edate,bas_entdate,bas_resdate,bas_levdate,bas_reidate,bas_wsta,(bas_sts ||':'|| cd_codnms) as bas_sts,(bas_pos ||':'|| pos_codnms) as bas_pos ,(bas_dut ||':'|| dut_codnms) as bas_dut, (bas_dept ||':'|| dept_name) as bas_dept,bas_rmk,bas_pos_dt,bas_dut_dt,bas_dept_dt,bas_intern_dt from thrm_bas_kjh,(select cd_code, cd_codnms from tieas_cd_kjh where cd_grpcd = 'STS'),(select cd_code as pos_code, cd_codnms as pos_codnms from tieas_cd_kjh where cd_grpcd = 'POS'),(select cd_code as dut_code, cd_codnms as dut_codnms from tieas_cd_kjh where cd_grpcd = 'DUT'), thrm_dept_kjh where bas_sts =cd_code and bas_pos =pos_code and bas_dut = dut_code(+) and bas_empno='" + bas_empno.Text + "'";
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = pgOraConn;
                cmd.CommandText = sabun_sql;

                OracleDataReader rd = cmd.ExecuteReader();
                if (rd.Read()) //select 했을 때 데이터가 있는 경우
                {
                    String as1 = rd["bas_dept"].ToString();
                    String[] dept = as1.Split(':');



                    bas_empno.Text = rd["bas_empno"] as string;
                    bas_resno.Text = rd["bas_resno"] as string;
                    bas_name.Text = rd["bas_name"] as string;
                    bas_cname.Text = rd["bas_cname"] as string;
                    bas_ename.Text = rd["bas_ename"] as string;
                    bas_fix.Text = rd["bas_fix"] as string;
                    bas_zip.Text = rd["bas_zip"] as string;
                    bas_addr.Text = rd["bas_addr"] as string;
                    bas_residence.Text = rd["bas_residence"] as string;
                    bas_hdpno.Text = rd["bas_hdpno"] as string;
                    bas_telno.Text = rd["bas_telno"] as string;
                    bas_email.Text = rd["bas_email"] as string;
                    bas_mil_sta.Text = rd["bas_mil_sta"] as string;
                    bas_mil_mil.Text = rd["bas_mil_mil"] as string;
                    bas_mil_rnk.Text = rd["bas_mil_rnk"] as string;
                    bas_mar.Text = rd["bas_mar"] as string;
                    bas_acc_bank1.Text = rd["bas_acc_bank1"] as string;
                    bas_acc_name1.Text = rd["bas_acc_name1"] as string;
                    bas_acc_no1.Text = rd["bas_acc_no1"] as string;
                    bas_acc_bank2.Text = rd["bas_acc_bank2"] as string;
                    bas_acc_name2.Text = rd["bas_acc_name2"] as string;
                    bas_acc_no2.Text = rd["bas_acc_no2"] as string;
                    bas_cont.Text = rd["bas_cont"] as string;
                    bas_intern.Text = rd["bas_intern"] as string;
                    bas_intern_no.Text = rd["bas_intern_no"] as string;
                    Console.WriteLine(DateTime.ParseExact(rd["bas_emp_sdate"] as string, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture));

                    bas_emp_sdate.Value = DateTime.ParseExact(rd["bas_emp_sdate"] as string, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    bas_emp_edate.Value = DateTime.ParseExact(rd["bas_emp_edate"] as string, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    bas_entdate.Value = DateTime.ParseExact(rd["bas_entdate"] as string, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    bas_resdate.Value = DateTime.ParseExact(rd["bas_resdate"] as string, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    bas_levdate.Value = DateTime.ParseExact(rd["bas_levdate"] as string, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    bas_reidate.Value = DateTime.ParseExact(rd["bas_reidate"] as string, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    bas_wsta.Text = rd["bas_wsta"] as string;
                    bas_sts.Text = rd["bas_sts"] as string;
                    bas_pos.Text = rd["bas_pos"] as string;
                    bas_dut.Text = rd["bas_dut"] as string;
                    bas_dept_code.Text = dept[1].ToString();
                    bas_dept.Text = dept[0].ToString();
                    bas_rmk.Text = rd["bas_rmk"] as string;
                    bas_pos_dt.Value = DateTime.ParseExact(rd["bas_pos_dt"] as string, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    bas_dut_dt.Value = DateTime.ParseExact(rd["bas_dut_dt"] as string, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    bas_dept_dt.Value = DateTime.ParseExact(rd["bas_dept_dt"] as string, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    bas_intern_dt.Value = DateTime.ParseExact(rd["bas_intern_dt"] as string, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);



                }

                else
                {

                    MessageBox.Show("입력하신 사원번호 정보가 존재하지 않습니다.");

                    return;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show(e.ToString());
                btn_control2();
                return;

            }
            finally
            {



            }


        }
        private void edu_display()
        {


        }
        private void update_Click(object sender, EventArgs e)//수정버튼
        {

            if (tabControl1.SelectedTab.TabIndex == 0)
            {
                if (String.IsNullOrWhiteSpace(bas_empno.Text))
                {
                    MessageBox.Show("사원번호를 입력하세요.");
                    return;
                }
                else
                {
                    sabun_display();
                    btn_control1();
                    MessageBox.Show("수정하실 내용을 수정해주세요.");
                }

                //db에서 읽어올 부분
                //시작할 때 커서가 bas_empno로 시작
                checktext.Text = "U";
            }
            else if (tabControl1.SelectedTab.TabIndex == 1)
            {
                checktext.Text = "F_U";
                if (String.IsNullOrWhiteSpace(fam_empno.Text))
                {
                    MessageBox.Show("사원번호를 입력하세요");
                    return;
                }
                if (string.IsNullOrWhiteSpace(fam_name.Text))
                {
                    MessageBox.Show("성명을 입력해주세요.");
                    return;
                }
                else
                {

                    MessageBox.Show("수정하실 내용을 수정해주세요.");
                    btn_control1();
                    fam_name.Enabled = false;
                    fam_rel.Enabled = false;
                }

            }
                else if (tabControl1.SelectedTab.TabIndex == 2)
                {
                    checktext.Text = "E_u";
                    if (String.IsNullOrWhiteSpace(edu_empno.Text))
                    {
                        MessageBox.Show("사원번호를 입력하세요");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(edu_schnm.Text))
                    {
                        MessageBox.Show("학교명을 입력하세요.");
                        return;

                    }
                    else if (String.IsNullOrWhiteSpace(edu_dept.Text))
                    {
                        MessageBox.Show("학과(전공)을 입력해주세요.");
                        return;
                    }
                    else if (String.IsNullOrWhiteSpace(edu_grade.Text))
                    {
                        MessageBox.Show("성적을 입력해주세요.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("수정하실 내용을 수정해주세요.");
                        btn_control1();
                        edu_loe.Enabled = false;
                    }
                }
                else if (tabControl1.SelectedTab.TabIndex == 3)
                {
                    checktext.Text = "A_u";
                    if (String.IsNullOrWhiteSpace(award_empno.Text))
                    {
                        MessageBox.Show("사원번호를 입력하세요");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(award_kind.Text))
                    {
                        MessageBox.Show("상벌종별을 입력해주세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(award_organ.Text))
                    {
                        MessageBox.Show("시행처를 입력해주세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(award_no.Text))
                    {
                        MessageBox.Show("상벌번호를 입력해주세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(award_type.Text))
                    {
                        MessageBox.Show("상벌구분을 선택해주세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(award_content.Text))
                    {
                        MessageBox.Show("상벌내용을 입력해주세요.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("수정하실 내용을 수정해주세요.");
                        btn_control1();
                        award_date.Enabled = false;

                    }
                }
                else if (tabControl1.SelectedTab.TabIndex == 4)
                {
                    checktext.Text = "C_u";
                    if (String.IsNullOrWhiteSpace(car_empno.Text))
                    {
                        MessageBox.Show("사원번호를 입력하세요");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(car_com.Text))
                    {
                        MessageBox.Show("근무처명을 입력해주세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(car_region.Text))
                    {
                        MessageBox.Show("소재지를 입력해주세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(car_pos.Text))
                    {
                        MessageBox.Show("최종직급을 입력해주세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(car_dept.Text))
                    {
                        MessageBox.Show("담당부서를 입력해주세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(car_job.Text))
                    {
                        MessageBox.Show("담당업무를 입력해주세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(car_reason.Text))
                    {
                        MessageBox.Show("퇴직/이직사유를 입력해주세요.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("수정하실 내용을 수정해주세요.");
                        btn_control1();
                        car_com.Enabled = false;

                    }

                }
                else if (tabControl1.SelectedTab.TabIndex == 5)
                {
                    checktext.Text = "L_u";
                    if (String.IsNullOrWhiteSpace(lic_empno.Text))
                    {
                        MessageBox.Show("사원번호를 입력하세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(lic_code.Text))
                    {
                        MessageBox.Show("자격면허코드를 입력해주세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(lic_grade.Text))
                    {
                        MessageBox.Show("급수를 입력해주세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(lic_organ.Text))
                    {
                        MessageBox.Show("발급기관을 입력해주세요.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("수정하실 내용을 수정해주세요.");
                        btn_control1();
                        lic_code.Enabled = false;

                    }
                }
                else if (tabControl1.SelectedTab.TabIndex == 6)
                {
                    checktext.Text = "Fo_u";
                    if (String.IsNullOrWhiteSpace(forl_empno.Text))
                    {
                        MessageBox.Show("사원번호를 입력하세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(forl_code.Text))
                    {
                        MessageBox.Show("외국어코드를 입력해주세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(forl_score.Text))
                    {
                        MessageBox.Show("점수를 입력해주세요.");
                        return;
                    }
                    if (String.IsNullOrWhiteSpace(forl_organ.Text))
                    {
                        MessageBox.Show("발급기관을 입력해주세요.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("수정하실 내용을 입력해주세요.");
                        btn_control1();
                        forl_code.Enabled = false;

                    }
                }
        }

        private void bas_acc_bank1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            changeTabControlPage(NowTabIndex);
            bas_mil_sta.Enabled = false;
            bas_mil_mil.Enabled = false;
            bas_mil_rnk.Enabled = false;
            fam_empno.Enabled = false;
            edu_empno.Enabled = false;
            award_empno.Enabled = false;
            car_empno.Enabled = false;
            lic_empno.Enabled = false;



            try
            {
                //db연동
                pgOraConn = new OracleConnection($"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1522)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;");
                pgOraConn.Open();
                pgOraCmd = pgOraConn.CreateCommand();
                //버튼 check(입력,수정,삭제->활성화 확인,취소->비활성화
                btn_control2();
                bas_empno.Focus();
                clearTextBox();

                string t_sql = "select cd_codnms,cd_code,cd_grpcd from TIEAS_CD_KJH ORDER BY CD_GRPCD ASC";
                OracleCommand t_cmd = new OracleCommand();
                t_cmd.Connection = pgOraConn;
                t_cmd.CommandText = t_sql;
                OracleDataReader t_rd = t_cmd.ExecuteReader();
                while (t_rd.Read())
                {
                    string CodeGroupName = t_rd["cd_grpcd"].ToString();
                    if (CodeGroupName == "MIL")
                    {
                        bas_mil_mil.Items.Add(t_rd["cd_codnms"] as string);
                    }
                    if (CodeGroupName == "BNK")
                    {
                        bas_acc_bank1.Items.Add(t_rd["cd_codnms"] as string);
                        bas_acc_bank2.Items.Add(t_rd["cd_codnms"] as string);
                    }
                    if (CodeGroupName == "POS")
                    {
                        bas_pos.Items.Add(t_rd[0].ToString());
                        pos1.Items.Add(t_rd[1].ToString());
                    }
                    if (CodeGroupName == "STS")
                    {
                        bas_sts.Items.Add(t_rd[0].ToString());
                        sts1.Items.Add(t_rd[1].ToString());
                    }
                    if (CodeGroupName == "DUT")
                    {
                        bas_dut.Items.Add(t_rd[0].ToString());
                        dut1.Items.Add(t_rd[1].ToString());

                    }
                    if (CodeGroupName == "REL")
                    {
                        fam_rel.Items.Add(t_rd[0].ToString());
                        rel1.Items.Add(t_rd[1].ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DB connection fail.\n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //은행
            //탭컨트롤 변경

        }
        public void qq1(string aq1, string aq2)
        {
            bas_zip.Text = aq1;
            bas_addr.Text = aq2;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {

            if (checktext.Text == "I" || checktext.Text == "U" || checktext.Text == "D" || checktext.Text == "F_i" || checktext.Text == "F_u" || checktext.Text == "F_d" || checktext.Text == "E_i" || checktext.Text == "E_u" || checktext.Text == "E_d" || checktext.Text == "A_i" || checktext.Text == "A_u" || checktext.Text == "A_d" || checktext.Text == "C_i" || checktext.Text == "C_u" || checktext.Text == "C_d" || checktext.Text == "L_i" || checktext.Text == "L_u" || checktext.Text == "L_d" || checktext.Text == "Fo_i" || checktext.Text == "Fo_u" || checktext.Text == "Fo_d")
            {
                // 시간 예시 이렇게 하면 현재 시간 들어감
                String msg = "취소하면 입력하신 자료가 모두 저장되지 않습니다.취소하시겠습니까?";
                DialogResult result = MessageBox.Show(this, msg, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    //delete 문자 넣을것

                    fam_name.Enabled = true;

                    fam_rel.Enabled = true;
                    edu_loe.Enabled = true;
                    MessageBox.Show("취소되었습니다.");
                    btn_control2();
                    bas_empno.Focus();
                    checktext.Text = "";
                    clearTextBox();
                    ClearTextBox2();
                    ClearTextBox3();
                    ClearTextBox4();
                    ClearTextBox5();
                    ClearTextBox6();
                    ClearTextBox7();
                    bas_empno.Enabled = true;
                    bas_resno.Enabled = true;
                    bas_name.Enabled = true;
                    bas_cname.Enabled = true;
                    bas_ename.Enabled = true;
                    bas_fix.Enabled = true;
                    bas_zip.Enabled = true;
                    bas_addr.Enabled = true;
                    bas_residence.Enabled = true;
                    bas_hdpno.Enabled = true;
                    bas_telno.Enabled = true;
                    bas_email.Enabled = true;
                    bas_mil_sta.Enabled = true;
                    bas_mil_mil.Enabled = true;
                    bas_mil_rnk.Enabled = true;
                    bas_mar.Enabled = true;
                    bas_acc_bank1.Enabled = true;
                    bas_acc_name1.Enabled = true;
                    bas_acc_no1.Enabled = true;
                    bas_acc_bank2.Enabled = true;
                    bas_acc_name2.Enabled = true;
                    bas_acc_no2.Enabled = true;
                    bas_cont.Enabled = true;
                    bas_intern.Enabled = true;
                    bas_intern_no.Enabled = true;
                    bas_emp_sdate.Enabled = true;
                    bas_emp_edate.Enabled = true;
                    bas_entdate.Enabled = true;
                    bas_resdate.Enabled = true;
                    bas_levdate.Enabled = true;
                    bas_reidate.Enabled = true;
                    bas_wsta.Enabled = true;
                    bas_sts.Enabled = true;
                    bas_pos.Enabled = true;
                    bas_dut.Enabled = true;
                    bas_dept_code.Enabled = true;
                    bas_rmk.Enabled = true;
                    bas_pos_dt.Enabled = true;
                    bas_dut_dt.Enabled = true;
                    bas_dept_dt.Enabled = true;
                    bas_intern_dt.Enabled = true;

                }

                bas_emp_sdate.Format = DateTimePickerFormat.Short;
                bas_emp_edate.Format = DateTimePickerFormat.Short;
                bas_entdate.Format = DateTimePickerFormat.Short;
                bas_resdate.Format = DateTimePickerFormat.Short;
                bas_levdate.Format = DateTimePickerFormat.Short;
                bas_reidate.Format = DateTimePickerFormat.Short;
                bas_pos_dt.Format = DateTimePickerFormat.Short;
                bas_dut_dt.Format = DateTimePickerFormat.Short;
                bas_dept_dt.Format = DateTimePickerFormat.Short;
                bas_intern_dt.Format = DateTimePickerFormat.Short;
                bas_emp_sdate.Enabled = true;
                bas_emp_edate.Enabled = true;
                bas_entdate.Enabled = true;
                bas_resdate.Enabled = true;
                bas_reidate.Enabled = true;
                bas_levdate.Enabled = true;
                bas_pos_dt.Enabled = true;
                bas_dut_dt.Enabled = true;
                bas_dept_dt.Enabled = true;
                bas_intern_dt.Enabled = true;

                btn_control2();
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab.TabIndex == 0)
            {


                if (bas_empno.Text == "")
                {
                    MessageBox.Show("사원번호를 입력하세요.");
                    btn_control2();
                    return;
                }
                else
                {
                    sabun_display();
                    bas_empno.Focus();
                    btn_control1();
                    checktext.Text = "D";
                    MessageBox.Show("삭제할 내용을 확인 후 확인 버튼을 눌러주세요.");
                    bas_empno.Enabled = false;
                    bas_resno.Enabled = false;
                    bas_name.Enabled = false;
                    bas_cname.Enabled = false;
                    bas_ename.Enabled = false;
                    bas_fix.Enabled = false;
                    bas_zip.Enabled = false;
                    bas_addr.Enabled = false;
                    bas_residence.Enabled = false;
                    bas_hdpno.Enabled = false;
                    bas_telno.Enabled = false;
                    bas_email.Enabled = false;
                    bas_mil_sta.Enabled = false;
                    bas_mil_mil.Enabled = false;
                    bas_mil_rnk.Enabled = false;
                    bas_mar.Enabled = false;
                    bas_acc_bank1.Enabled = false;
                    bas_acc_name1.Enabled = false;
                    bas_acc_no1.Enabled = false;
                    bas_acc_bank2.Enabled = false;
                    bas_acc_name2.Enabled = false;
                    bas_acc_no2.Enabled = false;
                    bas_cont.Enabled = false;
                    bas_intern.Enabled = false;
                    bas_intern_no.Enabled = false;
                    bas_emp_sdate.Enabled = false;
                    bas_emp_edate.Enabled = false;
                    bas_entdate.Enabled = false;
                    bas_resdate.Enabled = false;
                    bas_levdate.Enabled = false;
                    bas_reidate.Enabled = false;
                    bas_wsta.Enabled = false;
                    bas_sts.Enabled = false;
                    bas_pos.Enabled = false;
                    bas_dut.Enabled = false;
                    bas_dept_code.Enabled = false;
                    bas_rmk.Enabled = false;
                    bas_pos_dt.Enabled = false;
                    bas_dut_dt.Enabled = false;
                    bas_dept_dt.Enabled = false;
                    bas_intern_dt.Enabled = false;
                    bank_code2.Enabled = false;
                    bank_code1.Enabled = false;

                }
            }
            if (tabControl1.SelectedTab.TabIndex == 1)
            {
                if (fam_empno.Text == "")
                {
                    MessageBox.Show("사원번호를 입력하세요.");
                    btn_control2();
                    //return;
                }
                else
                {
                    checktext.Text = "F_D";
                    btn_control1();
                    fam_name.Enabled = false;
                    fam_empno.Enabled = false;
                    fam_dept.Enabled = false;
                    fam_bth.Enabled = false;
                    fam_pos.Enabled = false;
                    fam_rel.Enabled = false;
                    fam_nams.Enabled = false;
                    fam_ltg.Enabled = false;
                    MessageBox.Show("삭제할 내용을 확인 후 확인 버튼을 눌러주세요.");
                }
            }
            if (tabControl1.SelectedTab.TabIndex == 2)
            {
                if (edu_empno.Text == "")
                {
                    MessageBox.Show("사원번호를 입력하세요.");
                    btn_control2();
                    //return;
                }
                else
                {
                    checktext.Text = "E_d";
                    btn_control1();
                    MessageBox.Show("삭제할 내용을 확인 후 확인 버튼을 눌러주세요.");
                    edu_empno.Enabled = false;
                    edu_loe.Enabled = false;
                    edu_entdate.Enabled = false;
                    edu_gradate.Enabled = false;
                    edu_schnm.Enabled = false;
                    edu_dept.Enabled = false;
                    edu_degree.Enabled = false;
                    edu_grade.Enabled = false;
                    edu_gra.Enabled = false;
                    edu_last.Enabled = false;
                    edu_name.Enabled = false;
                    edu_dept1.Enabled = false;
                    edu_pos.Enabled = false;
                }

            }
            else if (tabControl1.SelectedTab.TabIndex == 3)
            {
                if (award_empno.Text == "")
                {
                    MessageBox.Show("사원번호를 입력하세요.");
                    btn_control2();
                    //return;
                }
                else
                {
                    checktext.Text = "A_d";
                    btn_control1();
                    MessageBox.Show("삭제할 내용을 확인 후 확인 버튼을 눌러주세요.");
                    award_empno.Enabled = false;
                    award_date.Enabled = false;
                    award_type.Enabled = false;
                    award_no.Enabled = false;
                    award_kind.Enabled = false;
                    award_organ.Enabled = false;
                    award_content.Enabled = false;
                    award_inout.Enabled = false;
                    award_pos.Enabled = false;
                    award_dept.Enabled = false;
                    award_name.Enabled = false;
                    award_pos.Enabled = false;
                    award_dept.Enabled = false;
                }
            }
            else if (tabControl1.SelectedTab.TabIndex == 4)
            {
                if (car_empno.Text == "")
                {
                    MessageBox.Show("사원번호를 입력해주세요.");
                    btn_control2();
                }
                else
                {
                    checktext.Text = "C_d";
                    btn_control1();
                    MessageBox.Show("삭제할 내용을 확인 후 확인 버튼을 눌러주세요.");
                    car_empno.Enabled = false;
                    car_com.Enabled = false;
                    car_region.Enabled = false;
                    car_yyyymm_f.Enabled = false;
                    car_yyyymm_t.Enabled = false;
                    car_pos.Enabled = false;
                    car_dept.Enabled = false;
                    car_job.Enabled = false;
                    car_reason.Enabled = false;
                    car_name.Enabled = false;
                    car_posname.Enabled = false;
                    car_deptname.Enabled = false;
                }
            }
            else if (tabControl1.SelectedTab.TabIndex == 5)
            {
                if (lic_empno.Text == "")
                {
                    MessageBox.Show("사원번호를 입력해주세요.");
                    btn_control2();
                }
                else
                {
                    checktext.Text = "L_d";
                    btn_control1();
                    MessageBox.Show("삭제할 내용을 확인 후 확인 버튼을 눌러주세요.");
                    lic_empno.Enabled = false;
                    lic_code.Enabled = false;
                    lic_grade.Enabled = false;
                    lic_acqdate.Enabled = false;
                    lic_organ.Enabled = false;
                    lic_name.Enabled = false;
                    lic_pos.Enabled = false;
                    lic_dept.Enabled = false;

                }
            }
            else if (tabControl1.SelectedTab.TabIndex == 6)
            {
                if (forl_empno.Text == "")
                {
                    MessageBox.Show("사원번호를 입력해주세요.");
                    btn_control2();
                }
                else
                {
                    checktext.Text = "Fo_d";
                    btn_control1();
                    MessageBox.Show("삭제할 내용을 확인 후 확인 버튼을 눌러주세요.");
                    forl_empno.Enabled = false;
                    forl_code.Enabled = false;
                    forl_score.Enabled = false;
                    forl_acqdate.Enabled = false;
                    forl_organ.Enabled = false;
                    forl_name.Enabled = false;
                    forl_pos.Enabled = false;
                    forl_dept.Enabled = false;
                }
            }
        }
        private void clearTextBox()
        {
            bas_empno.Text = "";
            bas_resno.Text = "";
            bas_name.Text = "";
            bas_cname.Text = "";
            bas_ename.Text = "";
            bas_fix.Text = "";
            bas_zip.Text = "";
            bas_addr.Text = "";
            bas_residence.Text = "";
            bas_hdpno.Text = "";
            bas_telno.Text = "";
            bas_email.Text = "";
            bas_mil_sta.Text = "";
            bas_mil_mil.Text = "";
            bas_mil_rnk.Text = "";
            bas_mar.Text = "";
            bas_acc_bank1.Text = "";
            bas_acc_name1.Text = "";
            bas_acc_no1.Text = "";
            bas_acc_bank2.Text = "";
            bas_acc_name2.Text = "";
            bas_acc_no2.Text = "";
            bas_cont.Text = "";
            bas_intern.Text = "";
            bas_intern_no.Text = "";
            bas_emp_sdate.Text = "";
            bas_emp_edate.Text = "";
            bas_entdate.Text = "";
            bas_resdate.Text = "";
            bas_levdate.Text = "";
            bas_reidate.Text = "";
            bas_wsta.Text = "";
            bas_sts.Text = "";
            bas_pos.Text = "";
            bas_dut.Text = "";
            bas_dept.Text = "";
            bas_rmk.Text = "";
            bas_pos_dt.Text = "";
            bas_dut_dt.Text = "";
            bas_dept_dt.Text = "";
            bas_intern_dt.Text = "";
            bas_dept_code.Text = "";
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.TabIndex == 0)
            {
                string result = bas_sts.Text;
                string[] sts1 = result.Split(':');

                result = bas_pos.Text;
                string[] pos2 = result.Split(':');

                result = bas_dut.Text;
                string[] dut3 = result.Split(':');
                result = bas_dept.Text;
                string[] dept4 = result.Split(':');


                result = bas_acc_bank1.Text;
                string[] bnk1 = result.Split(':');

                result = bas_acc_bank2.Text;
                string[] bnk2 = result.Split(':');

                result = bas_mil_mil.Text;
                string[] mil1 = result.Split(':');


                //ToString("yyyyMMdd");
                if (bas_emp_sdate.Text != " " && bas_emp_edate.Text != " ")
                {

                    String s1 = bas_emp_sdate.Text;
                    String s2 = bas_emp_edate.Text;
                    s1 = s1.Replace("-", "");
                    s2 = s2.Replace("-", "");

                    int date1 = int.Parse(s1);
                    int date2 = int.Parse(s2);

                    if (date1 >= date2)
                    {
                        MessageBox.Show("계약시작일이 계약 종료일보다 빨라야합니다.");
                        return;

                    }
                }
                if (bas_entdate.Text != " " && bas_resdate.Text != " ")
                {
                    String s3 = bas_entdate.Value.ToString("yyyyMMdd");
                    String s4 = bas_resdate.Value.ToString("yyyyMMdd");

                    int date3 = int.Parse(s3);
                    int date4 = int.Parse(s4);

                    if (date3 >= date4)
                    {
                        MessageBox.Show("입사일자는 퇴사일자보다 빨라야합니다.");
                        return;
                    }
                }
                if (bas_resdate.Text != " " && bas_reidate.Text != " ")
                {
                    String s5 = bas_resdate.Value.ToString("yyyyMMdd");
                    String s6 = bas_reidate.Value.ToString("yyyyMMdd");
                    int date5 = int.Parse(s5);
                    int date6 = int.Parse(s6);
                    if (date5 > date6)
                    {
                        MessageBox.Show("휴직일자는 복직일자보다 빨라야합니다.");
                        return;
                    }
                }
                // Console.WriteLine(bas_emp_sdate.Value.ToString("yyyyMMdd"));

                if (checktext.Text == "I")
                {
                    string sql1 = "insert into THRM_BAS_KJH(bas_empno, bas_resno, bas_name, bas_cname, bas_ename, bas_fix, bas_zip, bas_addr, bas_residence, bas_hdpno, bas_telno, bas_email, bas_mil_sta, bas_mil_mil, bas_mil_rnk, bas_mar, bas_acc_bank1, bas_acc_name1, bas_acc_no1, bas_acc_bank2, bas_acc_name2, bas_acc_no2, bas_cont, bas_intern, bas_intern_no, bas_emp_sdate, bas_emp_edate, bas_entdate, bas_resdate, bas_levdate, bas_reidate, bas_wsta, bas_sts, bas_pos, bas_dut, bas_dept, bas_rmk, bas_pos_dt, bas_dut_dt, bas_dept_dt, bas_intern_dt)"
                                      + " values(" + "'" + bas_empno.Text + "'," + "'" + bas_resno.Text + "'," + "'" + bas_name.Text + "'," + "'" + bas_cname.Text + "'," + "'" + bas_ename.Text + "'," + "'" + bas_fix.Text + "'," + "'" + bas_zip.Text + "'," + "'" + bas_addr.Text + "'," + "'" + bas_residence.Text + "'," + "'" + bas_hdpno.Text + "'," + "'" + bas_telno.Text + "'," + "'" + bas_email.Text + "'," + "'" + bas_mil_sta.Text + "'," + "'" + bas_mil_mil.Text + "'," + "'" + bas_mil_rnk.Text + "'," + "'" + bas_mar.Text + "'," + "'" + bas_acc_bank1.Text + "'," + "'" + bas_acc_name1.Text + "'," + "'" + bas_acc_no1.Text + "'," + "'" + bas_acc_bank2.Text + "'," + "'" + bas_acc_name2.Text + "'," + "'" + bas_acc_no2.Text + "'," + "'" + bas_cont.Text + "'," + "'" + bas_intern.Text + "'," + "'" + bas_intern_no.Text + "'," + "'" + bas_emp_sdate.Value.ToString("yyyyMMdd") + "'," + "'" + bas_emp_edate.Value.ToString("yyyyMMdd") + "'," + "'" + bas_entdate.Value.ToString("yyyyMMdd") + "'," + "'" + bas_resdate.Value.ToString("yyyyMMdd") + "'," + "'" + bas_levdate.Value.ToString("yyyyMMdd") + "'," + "'" + bas_reidate.Value.ToString("yyyyMMdd") + "'," + "'" + bas_wsta.Text + "'," + "'" + this.sts1.Text + "'," + "'" + pos1.Text + "'," + "'" + dut1.Text + "'," + "'" + bas_dept.Text + "'," + "'" + bas_rmk.Text + "'," + "'" + bas_pos_dt.Value.ToString("yyyyMMdd") + "'," + "'" + bas_dut_dt.Value.ToString("yyyyMMdd") + "'," + "'" + bas_dept_dt.Value.ToString("yyyyMMdd") + "'," + "'" + bas_intern_dt.Value.ToString("yyyyMMdd") + "')";

                    if (bas_empno.Text == "")
                    {
                        MessageBox.Show("사원번호를 입력해주세요.");
                        return;
                    }
                    else if (bas_resno.Text == "")
                    {
                        MessageBox.Show("주민등록번호를 입력해주세요.");
                        return;
                    }
                    else if (bas_name.Text == "")
                    {
                        MessageBox.Show("성명(한글)을 입력해주세요.");
                        return;
                    }
                    else if (bas_cname.Text == "")
                    {
                        MessageBox.Show("성명(한자)을 입력해주세요.");
                        return;
                    }
                    else if (bas_ename.Text == "")
                    {
                        MessageBox.Show("성명(영문)을 입력해주세요.");
                        return;
                    }
                    else if (bas_fix.Text == "")
                    {
                        MessageBox.Show("성별을 입력해주세요.");
                        return;
                    }
                    else if (bas_zip.Text == "")
                    {
                        MessageBox.Show("우편번호를 입력해주세요.");
                        return;
                    }
                    else if (bas_addr.Text == "")
                    {
                        MessageBox.Show("주소를 입력해주세요.");
                        return;
                    }
                    else if (bas_residence.Text == "")
                    {
                        MessageBox.Show("거주지를 입력해주세요.");
                        return;
                    }
                    else if (bas_hdpno.Text == "")
                    {
                        MessageBox.Show("연락처(휴대폰)를 입력해주세요.");
                        return;
                    }
                    else if (bas_telno.Text == "")
                    {
                        MessageBox.Show("연락처(집)를 입력해주세요.");
                        return;
                    }
                    else if (bas_email.Text == "")
                    {
                        MessageBox.Show("이메일을 입력해주세요.");
                        return;
                    }
                    else if (bas_mar.Text == "")
                    {
                        MessageBox.Show("결혼여부를 입력해주세요.");
                        return;
                    }
                    else if (bas_acc_bank1.Text == "")
                    {
                        MessageBox.Show("계좌사항(은행명)을 입력해주세요.");
                        return;
                    }
                    else if (bas_acc_name1.Text == "")
                    {
                        MessageBox.Show("계좌사항(예금주)을 입력해주세요.");
                        return;
                    }
                    else if (bas_acc_no1.Text == "")
                    {
                        MessageBox.Show("계좌사항(계좌번호)을 입력해주세요.");
                        return;
                    }
                    else if (bas_acc_bank2.Text == "")
                    {
                        MessageBox.Show("계좌사항(은행명)을입력해주세요.");
                        return;
                    }
                    else if (bas_acc_name2.Text == "")
                    {
                        MessageBox.Show("계좌사항(예금주)을입력해주세요.");
                        return;
                    }
                    else if (bas_acc_no2.Text == "")
                    {
                        MessageBox.Show("계좌사항(계좌번호)을 입력해주세요.");
                        return;
                    }
                    else if (bas_cont.Text == "")
                    {
                        MessageBox.Show("계약구분을 입력해주세요.");
                        return;
                    }
                    else if (bas_intern.Text == "")
                    {
                        MessageBox.Show("수습/인턴구분을 입력해주세요.");
                        return;
                    }
                    else if (bas_intern_no.Text == "")
                    {
                        MessageBox.Show("수습/인턴 개월수를 입력해주세요.");
                        return;
                    }
                    else if (bas_emp_sdate.Text == "")
                    {
                        MessageBox.Show("계약시작일을 입력해주세요.");
                        return;
                    }
                    else if (bas_emp_edate.Text == "")
                    {
                        MessageBox.Show("계약종료일을 입력해주세요.");
                        return;
                    }
                    else if (bas_entdate.Text == "")
                    {
                        MessageBox.Show("입사일자를 입력해주세요.");
                        return;
                    }
                    else if (bas_resdate.Text == "")
                    {
                        MessageBox.Show("퇴사일자를 입력해주세요.");
                        return;
                    }
                    else if (bas_levdate.Text == "")
                    {
                        MessageBox.Show("휴직일자를 입력해주세요.");
                        return;
                    }
                    else if (bas_reidate.Text == "")
                    {
                        MessageBox.Show("복직일자를 입력해주세요.");
                        return;
                    }
                    else if (bas_wsta.Text == "")
                    {
                        MessageBox.Show("재직상태를 입력해주세요.");
                        return;
                    }
                    else if (bas_sts.Text == "")
                    {
                        MessageBox.Show("신분구분을 입력해주세요.");
                        return;
                    }
                    else if (bas_pos.Text == "")
                    {
                        MessageBox.Show("직급(현재)을 입력해주세요.");
                        return;
                    }
                    else if (bas_dut.Text == "")
                    {
                        MessageBox.Show("직위(현재)를 입력해주세요.");
                        return;
                    }
                    else if (bas_dept.Text == "")
                    {
                        MessageBox.Show("부서(현재)를 입력해주세요.");
                        return;
                    }
                    else if (bas_rmk.Text == "")
                    {
                        MessageBox.Show("참고사항을 입력해주세요.");
                        return;
                    }
                    else if (bas_pos_dt.Text == "")
                    {
                        MessageBox.Show("현직급일자를 입력해주세요.");
                        return;
                    }
                    else if (bas_dut_dt.Text == "")
                    {
                        MessageBox.Show("현직위일자를 입력해주세요.");
                        return;
                    }
                    else if (bas_dept_dt.Text == "")
                    {
                        MessageBox.Show("현부서일자를 입력해주세요.");
                        return;
                    }
                    else if (bas_intern_dt.Text == "")
                    {
                        MessageBox.Show("수습/인턴일자입력해주세요.");
                        return;
                    }


                    Console.WriteLine(sql1);
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = pgOraConn;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                    String msg1 = "저장하시겠습니까?";
                    DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result5 == DialogResult.Yes)
                    {
                        MessageBox.Show("입력되었습니다.");
                        clearTextBox();
                        btn_control2();
                        checktext.Text = "";
                    }
                }
             

                else if (checktext.Text == "U")
                {
                    string sql = "update thrm_bas_kjh set bas_resno = '" + bas_resno.Text + "',bas_name = '" + bas_name.Text + "',bas_cname = '" + bas_cname.Text + "',bas_ename = '" + bas_ename.Text + "',bas_fix = '" + bas_fix.Text + "',bas_zip = '" + bas_zip.Text + "',bas_addr = '" + bas_addr.Text + "',bas_residence = '" + bas_residence.Text + "',bas_hdpno = '" + bas_hdpno.Text + "',bas_telno = '" + bas_telno.Text + "',bas_email = '" + bas_email.Text + "',bas_mil_sta = '" + bas_mil_sta.Text + "',bas_mil_mil = '" + bas_mil_mil.Text + "',bas_mil_rnk = '" + bas_mil_rnk.Text + "',bas_mar = '" + bas_mar.Text + "',bas_acc_bank1 = '" + bas_acc_bank1.Text + "',bas_acc_name1 = '" + bas_acc_name1.Text + "',bas_acc_no1 = '" + bas_acc_no1.Text + "',bas_acc_bank2 = '" + bas_acc_bank2.Text + "',bas_acc_name2 = '" + bas_acc_name2.Text + "',bas_acc_no2 = '" + bas_acc_no2.Text + "',bas_cont = '" + bas_cont.Text + "',bas_intern = '" + bas_intern.Text + "',bas_intern_no = '" + bas_intern_no.Text + "',bas_emp_sdate = '" + bas_emp_sdate.Value.ToString("yyyyMMdd") + "',bas_emp_edate = '" + bas_emp_edate.Value.ToString("yyyyMMdd") + "',bas_entdate = '" + bas_entdate.Value.ToString("yyyyMMdd") + "',bas_resdate = '" + bas_resdate.Value.ToString("yyyyMMdd") + "',bas_levdate = '" + bas_levdate.Value.ToString("yyyyMMdd") + "',bas_reidate = '" + bas_reidate.Value.ToString("yyyyMMdd") + "',bas_wsta = '" + bas_wsta.Text + "',bas_sts = '" + sts1[0].ToString() + "',bas_pos = '" + pos2[0].ToString() + "',bas_dut = '" + dut3[0].ToString() + "',bas_dept = '" + dept4[0].ToString() + "',bas_rmk = '" + bas_rmk.Text + "',bas_pos_dt = '" + bas_pos_dt.Value.ToString("yyyyMMdd") + "',bas_dut_dt = '" + bas_dut_dt.Value.ToString("yyyyMMdd") + "',bas_dept_dt = '" + bas_dept_dt.Value.ToString("yyyyMMdd") + "',bas_intern_dt = '" + bas_intern_dt.Value.ToString("yyyyMMdd") + "' where bas_empno = '" + bas_empno.Text + "'";
                    Console.WriteLine(sql);
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = pgOraConn;
                    cmd.CommandText = sql;

                    cmd.ExecuteNonQuery();
                    String msg1 = "수정하시겠습니까?";

                    DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result5 == DialogResult.Yes)
                    {
                        MessageBox.Show("수정되었습니다.");
                        clearTextBox();
                        btn_control2();
                        checktext.Text = "";

                    }

                }
               
                else if (checktext.Text == "D")
                {
                    string sql3 = "delete from THRM_BAS_KJH WHERE bas_empno='" + bas_empno.Text + "'";
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = pgOraConn;
                    cmd.CommandText = sql3;

                    cmd.ExecuteNonQuery();
                    String msg1 = "삭제하시겠습니까?";
                    DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result5 == DialogResult.Yes)
                    {
                        MessageBox.Show("삭제되었습니다.");
                        clearTextBox();
                        btn_control2();
                        checktext.Text = "";
                    }
                }
            }
            if (tabControl1.SelectedTab.TabIndex == 1)
            {



                {
                    string result = rel1.Text;
                    string[] rel2 = result.Split(':');

                    if (fam_bth.Text != "  ")
                    {
                        String s1 = fam_bth.Text;

                        s1 = s1.Replace("-", "");

                        int date1 = int.Parse(s1);
                    }
                    
                    if (checktext.Text == "F_i")
                    {
                        string sql1 = "insert into THRM_FAM_KJH(fam_empno,fam_rel,fam_name,fam_bth,fam_ltg) values(" + "'" + fam_empno.Text + "'," + "'" + rel1.Text + "'," + "'" + fam_name.Text + "'," + "'" + fam_bth.Value.ToString("yyyyMMdd") + "', '" + fam_ltg.Text + "')";
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = pgOraConn;
                        cmd.CommandText = sql1;
                        cmd.ExecuteNonQuery();
                        if (fam_rel.Text == "")
                        {
                            MessageBox.Show("가족관계를 설정해주세요.");
                            return;
                        }
                        else if (fam_name.Text == "")
                        {
                            MessageBox.Show("가족분의 이름을 적어주세요.");
                            return;
                        }
                        else
                        {
                            String msg1 = "저장하시겠습니까?";
                            DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                            if (result5 == DialogResult.Yes)
                            {
                                MessageBox.Show("입력되었습니다.");
                                clearTextBox();
                                btn_control2();
                                checktext.Text = "";
                            }
                        }
                    }
                    

                    if (checktext.Text == "F_U")
                    {
                        string sql = "update thrm_fam_kjh set fam_empno='" + fam_empno.Text + "',fam_rel='" + rel2[0].ToString() + "',fam_name='" + fam_name.Text + "',fam_bth='" + fam_bth.Value.ToString("yyyyMMdd") + "',fam_ltg='" + fam_ltg.Text + "' where fam_empno='" + fam_empno.Text + "' and fam_rel='" + rel2[0].ToString() + "' and fam_name='" + fam_name.Text + "'";
                        Console.WriteLine(sql);
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = pgOraConn;
                        cmd.CommandText = sql;

                        cmd.ExecuteNonQuery();
                        String msg1 = "수정하시겠습니까?";

                        DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result5 == DialogResult.Yes)
                        {
                            MessageBox.Show("수정되었습니다.");
                            ClearTextBox2();
                            btn_control2();
                            checktext.Text = "";


                        }

                    }
                 
                    else if (checktext.Text == "F_D")
                    {
                        string sql3 = "delete from THRM_fam_KJH WHERE fam_empno='" + fam_empno.Text + "'";
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = pgOraConn;
                        cmd.CommandText = sql3;

                        cmd.ExecuteNonQuery();
                        String msg1 = "삭제하시겠습니까?";
                        DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result5 == DialogResult.Yes)
                        {
                            MessageBox.Show("삭제되었습니다.");
                            clearTextBox();
                            btn_control2();
                            checktext.Text = "";
                        }
                    }
                }

            }
            if (tabControl1.SelectedTab.TabIndex == 2)
            {
                if (edu_entdate.Text != " " && edu_gradate.Text != " ")
                {

                    String s1 = edu_entdate.Text;
                    String s2 = edu_gradate.Text;
                    s1 = s1.Replace("-", "");
                    s2 = s2.Replace("-", "");

                    int date1 = int.Parse(s1);
                    int date2 = int.Parse(s2);

                    if (date1 >= date2)
                    {
                        MessageBox.Show("입학일자는 졸업일자보다 빨라야합니다.");
                        return;

                    }

                }
                if (tabControl1.SelectedTab.TabIndex == 2)
                {
               
                    if (checktext.Text == "E_i")
                    {
                        string sql1 = "insert into THRM_edu_KJH(edu_empno,edu_loe,edu_entdate,edu_gradate,edu_schnm,edu_dept,edu_degree,edu_grade,edu_gra,edu_last) values('" + edu_empno.Text + "', '" + edu_loe.Text + "', '" + edu_entdate.Value.ToString("yyyyMMdd") + "', '" + edu_gradate.Value.ToString("yyyyMMdd") + "', '" + edu_schnm.Text + "','" + edu_dept.Text + "','" + edu_degree.Text + "','" + edu_grade.Text + "','" + edu_gra.Text + "','" + edu_last.Text + "')";
                        MessageBox.Show(sql1);
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = pgOraConn;
                        cmd.CommandText = sql1;
                        cmd.ExecuteNonQuery();
                        if (edu_schnm.Text == "")
                        {
                            MessageBox.Show("학교명을 입력해주세요.");
                            return;
                        }
                        else if (edu_grade.Text == "")
                        {
                            MessageBox.Show("성적을 입력해주세요");
                            return;
                        }
                        else if (edu_dept.Text == "")
                        {
                            MessageBox.Show("학과(전공)을 입력해주세요.");
                            return;
                        }
                        else
                        {
                            String msg1 = "저장하시겠습니까?";
                            DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                            if (result5 == DialogResult.Yes)
                            {
                                MessageBox.Show("입력되었습니다.");
                                ClearTextBox3();
                                btn_control2();
                                checktext.Text = "";
                            }
                        }
                    }
                    if (checktext.Text == "E_u")
                    {

                        string sql = "update thrm_edu_kjh set edu_entdate='" + edu_entdate.Value.ToString("yyyyMMdd") + "',edu_gradate='" + edu_gradate.Value.ToString("yyyyMMdd") + "',edu_schnm='" + edu_schnm.Text + "',edu_dept='" + edu_dept.Text + "',edu_degree='" + edu_degree.Text + "',edu_grade='" + edu_grade.Text + "',edu_gra='" + edu_gra.Text + "',edu_last='" + edu_last.Text + "' where edu_empno='" + edu_empno.Text + "'";
                        //////MessageBox.Show(sql);
                        Console.WriteLine(sql);
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = pgOraConn;
                        cmd.CommandText = sql;
                        
                        cmd.ExecuteNonQuery();
                        String msg1 = "수정하시겠습니까?";

                        DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result5 == DialogResult.Yes)
                        {
                            MessageBox.Show("수정되었습니다.");
                            ClearTextBox3();
                            btn_control2();
                            checktext.Text = "";

                        }
                    }
                    if (checktext.Text == "E_d")
                    {
                        string sql3 = "delete from THRM_edu_KJH WHERE edu_empno='" + edu_empno.Text + "'";
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = pgOraConn;
                        cmd.CommandText = sql3;

                        cmd.ExecuteNonQuery();
                        String msg1 = "삭제하시겠습니까?";
                        DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result5 == DialogResult.Yes)
                        {
                            MessageBox.Show("삭제되었습니다.");
                            ClearTextBox3();
                            btn_control2();
                            checktext.Text = "";
                        }
                    }
                }
            }
            if (tabControl1.SelectedTab.TabIndex == 3)
            {
                if (checktext.Text == "A_i")
                {
                    string sql1 = "insert into THRM_award_KJH(award_empno,award_date,award_type,award_no,award_kind,award_organ,award_content,award_inout,award_pos,award_dept) values('" + award_empno.Text + "', '" + award_date.Value.ToString("yyyyMMdd") + "', '" + award_type.Text + "', '" + award_no.Text + "', '" + award_kind.Text + "','" + award_organ.Text + "','" + award_content.Text + "','" + award_inout.Text + "','" + award_pos.Text + "','" + award_dept.Text + "')";
                    MessageBox.Show(sql1);
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = pgOraConn;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                    if (award_kind.Text == "")
                    {
                        MessageBox.Show("상벌종별을 입력해주세요.");
                        return;
                    }
                    else if (award_organ.Text == "")
                    {
                        MessageBox.Show("시행처를 입력해주세요.");
                        return;
                    }
                    else if (award_type.Text == "")
                    {
                        MessageBox.Show("상벌구분을 선택해주세요.");
                        return;
                    }
                    else if (award_no.Text == "")
                    {
                        MessageBox.Show("상벌번호를 입력해주세요.");
                        return;

                    }
                    else if (award_content.Text == "")
                    {
                        MessageBox.Show("상벌내용을 입력해주세요.");
                        return;
                    }
                    else if (award_inout.Text == "선택")
                    {
                        MessageBox.Show("내외구분을 선택하지않았습니다.");
                        return;
                    }
                    String msg1 = "저장하시겠습니까?";
                    DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result5 == DialogResult.Yes)
                    {
                        MessageBox.Show("입력되었습니다.");
                        ClearTextBox4();
                        btn_control2();
                        checktext.Text = "";
                    }
                }
                if (checktext.Text == "A_u")
                {
                    string sql = "update thrm_award_kjh set award_type='" + award_type.Text + "',award_no='" + award_no.Text + "',award_kind='" + award_kind.Text + "',award_organ='" + award_organ.Text + "',award_content='" + award_content.Text + "',award_inout='" + award_inout.Text + "',award_pos='" + award_pos.Text + "',award_dept='" + award_dept.Text + "' where award_empno='" + award_empno.Text + "' and award_date='" + award_date.Value.ToString("yyyyMMdd") + "'";
                    Console.WriteLine(sql);
                    MessageBox.Show(sql);
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = pgOraConn;
                    cmd.CommandText = sql;

                    cmd.ExecuteNonQuery();
                    String msg1 = "수정하시겠습니까?";

                    DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result5 == DialogResult.Yes)
                    {
                        MessageBox.Show("수정되었습니다.");
                        ClearTextBox4();
                        btn_control2();
                        checktext.Text = "";


                    }
                }
            }
            if (checktext.Text == "A_d")
            {

                string sql3 = "delete from THRM_award_KJH WHERE award_empno='" + award_empno.Text + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = pgOraConn;
                cmd.CommandText = sql3;

                cmd.ExecuteNonQuery();
                String msg1 = "삭제하시겠습니까?";
                DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result5 == DialogResult.Yes)
                {

                    MessageBox.Show("삭제되었습니다.");
                    ClearTextBox4();
                    btn_control2();
                    checktext.Text = "";
                }
            }
            if (tabControl1.SelectedTab.TabIndex == 4)
                if (checktext.Text == "C_i")
                {
                    string sql1 = "insert into THRM_car_KJH(car_empno,car_com,car_region,car_yyyymm_f,car_yyyymm_t,car_pos,car_dept,car_job,car_reason) values('" + car_empno.Text + "', '" + car_com.Text + "', '" + car_region.Text + "', '" + car_yyyymm_f.Value.ToString("yyyyMM") + "', '" + car_yyyymm_t.Value.ToString("yyyyMM") + "','" + car_pos.Text + "','" + car_dept.Text + "','" + car_job.Text + "','" + car_reason.Text + "')";
                    MessageBox.Show(sql1);
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = pgOraConn;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                    if (car_com.Text == "")
                    {
                        MessageBox.Show("근무처명을 입력해주세요.");
                        return;
                    }
                    else if (car_region.Text == "")
                    {
                        MessageBox.Show("소재지를 입력해주세요.");
                        return;
                    }
                    else if (car_pos.Text == "")
                    {
                        MessageBox.Show("최종직급을 입력해주세요.");
                        return;
                    }
                    else if (car_dept.Text == "")
                    {
                        MessageBox.Show("담당무서를 입력해주세요.");
                        return;
                    }
                    else if (car_job.Text == "")
                    {
                        MessageBox.Show("담당업무를 입력해주세요.");
                        return;
                    }
                    else if (car_reason.Text == "")
                    {
                        MessageBox.Show("퇴직/이직사유를 입력해주세요.");
                        return;
                    }
                    else
                    {
                        String msg1 = "저장하시겠습니까?";
                        DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result5 == DialogResult.Yes)
                        {
                            MessageBox.Show("입력되었습니다.");
                            ClearTextBox5();
                            btn_control2();
                            checktext.Text = "";
                        }
                    }
                }

            if (checktext.Text == "C_u")
            {

                string sql = "update thrm_car_kjh set car_region='" + car_region.Text + "',car_yyyymm_f='" + car_yyyymm_f.Value.ToString("yyyyMM") + "',car_yyyymm_t='" + car_yyyymm_t.Value.ToString("yyyyMM") + "',car_pos='" + car_pos.Text + "',car_dept='" + car_dept.Text + "',car_job='" + car_job.Text + "',car_reason='" + car_reason.Text + "' where car_empno='" + car_empno.Text + "' and car_com='" + car_com.Text + "'";
                Console.WriteLine(sql);
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = pgOraConn;
                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
                String msg1 = "수정하시겠습니까?";

                DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result5 == DialogResult.Yes)
                {
                    MessageBox.Show("수정되었습니다.");
                    ClearTextBox5();
                    btn_control2();
                    checktext.Text = "";

                }
            }
            if (checktext.Text == "C_d")
            {
                string sql3 = "delete from THRM_car_KJH WHERE car_empno='" + car_empno.Text + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = pgOraConn;
                cmd.CommandText = sql3;

                cmd.ExecuteNonQuery();
                String msg1 = "삭제하시겠습니까?";
                DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result5 == DialogResult.Yes)
                {

                    MessageBox.Show("삭제되었습니다.");
                    ClearTextBox5();
                    btn_control2();
                    checktext.Text = "";
                }
            }
            if (tabControl1.SelectedTab.TabIndex == 5)
            {
                if (checktext.Text == "L_i")
                {
                    string sql1 = "insert into THRM_lic_KJH(lic_empno,lic_code,lic_grade,lic_acqdate,lic_organ) values('" + lic_empno.Text + "', '" + lic_code.Text + "', '" + lic_grade.Text + "', '" + lic_acqdate.Value.ToString("yyyyMMdd") + "', '" + lic_organ.Text + "')";
                    MessageBox.Show(sql1);
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = pgOraConn;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();

                    if (lic_code.Text == "")
                    {
                        MessageBox.Show("자격면허코드를 입력해주세요.");
                        return;
                    }
                    else if (lic_grade.Text == "")
                    {
                        MessageBox.Show("급수를 입력해주세요.");
                        return;
                    }
                    else if (lic_organ.Text == "")
                    {
                        MessageBox.Show("발급기관을 입력해주세요.");
                        return;
                    }
                    else
                    {
                        String msg1 = "저장하시겠습니까?";
                        DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result5 == DialogResult.Yes)
                        {
                            MessageBox.Show("입력되었습니다.");
                            ClearTextBox6();
                            btn_control2();
                            checktext.Text = "";
                        }
                    }
                }


                if (checktext.Text == "L_u")
                {
                    string sql = "update thrm_lic_kjh set lic_grade='" + lic_grade.Text + "',lic_acqdate='" + lic_acqdate.Value.ToString("yyyyMMdd") + "',lic_organ='" + lic_organ.Text + "' where lic_empno='" + lic_empno.Text + "' and lic_code='" + lic_code.Text + "'";
                    Console.WriteLine(sql);
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = pgOraConn;
                    cmd.CommandText = sql;

                    cmd.ExecuteNonQuery();
                    String msg1 = "수정하시겠습니까?";

                    DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result5 == DialogResult.Yes)
                    {
                        MessageBox.Show("수정되었습니다.");
                        ClearTextBox6();
                        btn_control2();
                        checktext.Text = "";


                    }
                }
                if (checktext.Text == "L_d")
                {
                    string sql3 = "delete from THRM_lic_KJH WHERE lic_empno='" + lic_empno.Text + "'";
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = pgOraConn;
                    cmd.CommandText = sql3;

                    cmd.ExecuteNonQuery();
                    String msg1 = "삭제하시겠습니까?";
                    DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result5 == DialogResult.Yes)
                    {

                        MessageBox.Show("삭제되었습니다.");
                        ClearTextBox6();
                        btn_control2();
                        checktext.Text = "";
                    }
                }
            }
            if (tabControl1.SelectedTab.TabIndex == 6)
            {
                if (checktext.Text == "Fo_i")
                {
                    string sql1 = "insert into THRM_forl_KJH(forl_empno,forl_code,forl_score,forl_acqdate,forl_organ) values('" + forl_empno.Text + "', '" + forl_code.Text + "', '" + forl_score.Text + "', '" + forl_acqdate.Value.ToString("yyyyMMdd") + "', '" + forl_organ.Text + "')";
                    MessageBox.Show(sql1);
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = pgOraConn;
                    cmd.CommandText = sql1;
                    cmd.ExecuteNonQuery();
                    if (forl_code.Text == "")
                    {
                        MessageBox.Show("외국어코드를 입력해주세요.");
                        return;
                    }
                    else if (forl_score.Text == "")
                    {
                        MessageBox.Show("점수를 입력해주세요.");
                        return;
                    }
                    else if (forl_organ.Text == "")
                    {
                        MessageBox.Show("발급기관을 입력해주세요.");
                        return;
                    }
                    else
                    {
                        String msg1 = "저장하시겠습니까?";
                        DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result5 == DialogResult.Yes)
                        {
                            MessageBox.Show("입력되었습니다.");
                            ClearTextBox7();
                            btn_control2();
                            checktext.Text = "";
                        }
                    }
                }
            }
            if (checktext.Text == "Fo_u")
            {
                string sql = "update thrm_forl_kjh set forl_score='" + forl_score.Text + "',forl_acqdate='" + forl_acqdate.Value.ToString("yyyyMMdd") + "',forl_organ='" + forl_organ.Text + "' where forl_empno='" + forl_empno.Text + "' and forl_code='" + forl_code.Text + "'";
                Console.WriteLine(sql);
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = pgOraConn;
                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
                String msg1 = "수정하시겠습니까?";

                DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result5 == DialogResult.Yes)
                {
                    MessageBox.Show("수정되었습니다.");
                    ClearTextBox7();
                    btn_control2();
                    checktext.Text = "";

                }


            }
            if (checktext.Text == "Fo_d")
            {
                string sql3 = "delete from THRM_forl_KJH WHERE forl_empno='" + forl_empno.Text + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = pgOraConn;
                cmd.CommandText = sql3;

                cmd.ExecuteNonQuery();
                String msg1 = "삭제하시겠습니까?";
                DialogResult result5 = MessageBox.Show(this, msg1, "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result5 == DialogResult.Yes)
                {

                    MessageBox.Show("삭제되었습니다.");
                    btn_control2();
                    checktext.Text = "";
                }

            }


        }


        private void btn_control1()
        {
            insert.Enabled = false;
            update.Enabled = false;
            delete.Enabled = false;
            Confirm.Enabled = true;
            Cancel.Enabled = true;
        }
        private void btn_control2()
        {
            insert.Enabled = true;
            update.Enabled = true;
            delete.Enabled = true;
            Confirm.Enabled = false;
            Cancel.Enabled = false;
        }
        private void btn_control3()
        {
            insert.Enabled = true;
            update.Enabled = true;
            delete.Enabled = true;
            Confirm.Enabled = true;
            Cancel.Enabled = true;
        }
        private void ClearTextBox2()
        {

            fam_rel.Text = "";
            fam_name.Text = "";
            fam_bth.Text = "";
            fam_ltg.Text = "";


        }
        private void ClearTextBox3()
        {

            edu_loe.Text = "";
            edu_entdate.Text = "";
            edu_gradate.Text = "";
            edu_schnm.Text = "";
            edu_dept.Text = "";
            edu_degree.Text = "";
            edu_grade.Text = "";
            edu_gra.Text = "";
            edu_last.Text = "";

        }
        private void ClearTextBox5()
        {

            car_com.Text = "";
            car_region.Text = "";
            car_yyyymm_f.Text = "";
            car_yyyymm_t.Text = "";
            car_pos.Text = "";
            car_dept.Text = "";
            car_job.Text = "";
            car_reason.Text = "";

        }
        private void ClearTextBox4()
        {

            award_date.Text = "";
            award_type.Text = "";
            award_no.Text = "";
            award_kind.Text = "";
            award_organ.Text = "";
            award_content.Text = "";
            award_inout.Text = "";


        }
        private void
            ClearTextBox6()
        {

            lic_code.Text = "";
            lic_grade.Text = "";
            lic_acqdate.Text = "";
            lic_organ.Text = "";

        }
        private void ClearTextBox7()
        {

            forl_code.Text = "";
            forl_score.Text = "";
            forl_acqdate.Text = "";
            forl_organ.Text = "";


        }


        private void bas_wsta_SelectedIndexChanged(object sender, EventArgs e) //재직상태
        {
            if (bas_wsta.Text == "재직")
            {
                bas_resdate.Enabled = false;
                bas_levdate.Enabled = false;
                bas_reidate.Enabled = false;
                bas_resdate.Format = DateTimePickerFormat.Custom;
                bas_levdate.Format = DateTimePickerFormat.Custom;
                bas_reidate.Format = DateTimePickerFormat.Custom;
            }
            else if (bas_wsta.Text == "휴직")
            {
                bas_resdate.Enabled = false;
                bas_levdate.Enabled = true;
                bas_reidate.Enabled = true;
                bas_resdate.Format = DateTimePickerFormat.Custom;
                bas_levdate.Format = DateTimePickerFormat.Short;
                bas_reidate.Format = DateTimePickerFormat.Short;
            }
            else
            {
                bas_resdate.Enabled = true;
                bas_levdate.Enabled = false;
                bas_reidate.Enabled = false;
                bas_resdate.Format = DateTimePickerFormat.Short;
                bas_levdate.Format = DateTimePickerFormat.Custom;
                bas_reidate.Format = DateTimePickerFormat.Custom;
            }

        }

        private void bas_intern_SelectedIndexChanged(object sender, EventArgs e) //수습인턴구분
        {
            if (bas_intern.Text == "수습")
            {
                bas_intern_no.Text = "3";
            }
            else if (bas_intern.Text == "인턴")
            {
                bas_intern_no.Text = "9";
            }
            else
            {
                bas_intern_no.Text = "";
            }

        }

        private void bas_cont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bas_cont.Text == "정규직")
            {
                bas_emp_edate.Enabled = false;
                bas_emp_sdate.Enabled = false;
                bas_emp_edate.Format = DateTimePickerFormat.Custom;
                bas_emp_sdate.Format = DateTimePickerFormat.Custom;

            }
            else
                if (bas_cont.Text == "계약직")
            {
                bas_emp_edate.Enabled = true;
                bas_emp_sdate.Enabled = true;
                bas_emp_edate.Format = DateTimePickerFormat.Short;
                bas_emp_sdate.Format = DateTimePickerFormat.Short;


                //DateTimePicker;
            }

        }


        private void bas_resno_Leave(object sender, EventArgs e)
        {
            string bas_div;
            string bas_sbs;
            if (bas_resno.Text.Length < 13)
            {
                MessageBox.Show("잘못된 입력방식입니다.");
                return;
            }
            bas_div = bas_resno.Text;
            bas_sbs = bas_div.Substring(6, 1);

            if (bas_resno.Text == "")
            {
                MessageBox.Show("주민등록번호를 입력해주세요.");
                return;
            }
            if (bas_resno.Text.Length != 13)
            {
                MessageBox.Show("주민등록번호는 무조건 13자리이여야 합니다.");
                bas_resno.Focus();
                return;

            }
            if (bas_sbs == "1" || bas_sbs == "3")
            {
                bas_fix.Text = "남";
                bas_mil_sta.Enabled = true;
                bas_mil_rnk.Enabled = true;
                bas_mil_mil.Enabled = true;

            }
            else if (bas_sbs == "2" || bas_sbs == "4")
            {
                bas_fix.Text = "여";
                bas_mil_sta.Enabled = false;
                bas_mil_rnk.Enabled = false;
                bas_mil_mil.Enabled = false;
            }
        }

        private void bas_resno_TextChanged(object sender, EventArgs e)
        {

        }

        private void bas_mil_sta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bas_mil_sta.Text == "복무")
            {
                bas_mil_mil.Enabled = true;
                bas_mil_rnk.Enabled = true;
            }
            else if (bas_mil_sta.Text == "미필" || bas_mil_sta.Text == "면제")
            {
                bas_mil_mil.Enabled = false;
                bas_mil_rnk.Enabled = false;
            }
        }

        private void bas_emp_sdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bas_emp_edate_ValueChanged(object sender, EventArgs e)
        {


        }

        private void bas_emp_edate_Validated(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form3 frm3 = new Form3(this);
            frm3.ShowDialog();



        }
        public void aa1(string aa2, String aa3)
        {
            bas_dept.Text = aa2;
            bas_dept_code.Text = aa3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            metroGrid7.Columns.Clear();
            metroGrid7.Rows.Clear();

            metroGrid7.Columns.Add("bas_empno", "사번");
            metroGrid7.Columns.Add("bas_name", "성명");
            metroGrid7.Columns.Add("cd_codnms", "직급");
            string sql = "select bas_empno,bas_name,bas_pos,cd_codnms,bas_dept from thrm_bas_kjh,(select cd_grpcd,cd_code,cd_codnms from TIEAS_CD_KJH where cd_grpcd = 'POS') CD, (select DEPT_CODE, DEPT_NAME from THRM_DEPT_KJH) DP where bas_pos = CD.cd_code and bas_dept = DP.dept_code and (bas_name like '%" + textBox1.Text + "%') ";

            try
            {
                Console.WriteLine(sql);
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = pgOraConn;
                cmd.CommandText = sql;
                OracleDataReader rd = cmd.ExecuteReader();
                int cnt = 0;

                if (textBox1.Text == "")
                {
                    MessageBox.Show("이름을 입력해주세요.");
                    return;
                }
                else
                {
                    while (rd.Read())
                    {
                        metroGrid7.Rows.Add();
                        metroGrid7.Rows[cnt].Cells["bas_empno"].Value = rd["bas_empno"].ToString();
                        metroGrid7.Rows[cnt].Cells["bas_name"].Value = rd["bas_name"].ToString();
                        metroGrid7.Rows[cnt].Cells["cd_codnms"].Value = rd["cd_codnms"].ToString();
                        cnt++;
                    }

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }




        private void button8_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(this);
            frm5.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bas_sts_SelectedIndexChanged(object sender, EventArgs e)
        {
            sts1.SelectedIndex = bas_sts.SelectedIndex;
        }

        private void bas_pos_SelectedIndexChanged(object sender, EventArgs e)
        {

            pos1.SelectedIndex = bas_pos.SelectedIndex;
            fam_pos.Text = bas_pos.Text;
            award_pos.Text = bas_pos.Text;
            car_posname.Text = bas_pos.Text;
            lic_pos.Text = bas_pos.Text;
            forl_pos.Text = bas_pos.Text;
            edu_pos.Text = bas_pos.Text;
            bas_pos.Text = award_pos.Text;
            award_pos.Text = bas_pos.Text;


        }

        private void bas_dut_SelectedIndexChanged(object sender, EventArgs e)
        {
            dut1.SelectedIndex = bas_dut.SelectedIndex;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            if (File.ShowDialog() == DialogResult.OK)
            {

                Picture.Image = new Bitmap(File.FileName);

            }

        }
        private void picturebox1_Click(object sender, EventArgs e)
        {
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tabpage2_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = metroGrid7.CurrentRow.Index;
            bas_empno.Text = metroGrid7.Rows[rowIndex].Cells[0].Value.ToString();
            bas_name.Text = metroGrid7.Rows[rowIndex].Cells[1].Value.ToString();
            bas_pos.Text = metroGrid7.Rows[rowIndex].Cells[2].Value.ToString();

            try
            {
                string sql1 = "select* from THRM_BAS_KJH where bas_empno='" + bas_empno.Text + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sql1;
                cmd.Connection = pgOraConn;
                OracleDataReader rd = cmd.ExecuteReader();
                if (bas_empno.Text != null)
                {
                    if (rd.Read())
                    {
                        sabun_display();

                    }
                }


            }

            catch
            {
                MessageBox.Show("오류");
            }
        }
        #region
        private void button3_Click(object sender, EventArgs e)
        {
            metroGrid6.Rows.Clear();
            metroGrid6.Columns.Add("fam_name", "성명");
            metroGrid6.Columns.Add("fam_rel", "관계");
            metroGrid6.Columns.Add("fam_bth", "동거여부");
            metroGrid6.Columns.Add("fam_ltg", "생년월일");
            string sql = "select fam_empno, fam_name, fam_rel,fam_bth,fam_ltg  from thrm_fam_kjh";


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = pgOraConn;
            cmd.CommandText = sql;
            OracleDataReader rd = cmd.ExecuteReader();
            int cnt = 0;

            while (rd.Read())
            {
                metroGrid7.Rows.Add();
                metroGrid7.Rows[cnt].Cells["fam_empno"].Value = rd["fam_empno"].ToString();
                metroGrid7.Rows[cnt].Cells["fam_name"].Value = rd["fam_name"].ToString();
                metroGrid7.Rows[cnt].Cells["fam_rel"].Value = rd["fam_rel"].ToString();
                metroGrid7.Rows[cnt].Cells["fam_bth"].Value = rd["fam_bth"].ToString();
                metroGrid7.Rows[cnt].Cells["fam_ltg"].Value = rd["fam_ltg"].ToString();
                cnt++;
            }
        }
        #endregion
        #region 탭컨트롤 제어
        //***********************************************************************
        // 탭 인덱스 변경
        //***********************************************************************

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = (TabControl)sender;
            //Console.WriteLine($"{tab.SelectedIndex}:{tab.SelectedTab.Text}");
            Console.WriteLine("change Tabs event ---------------");
            int NowSelectedTab = tab.SelectedIndex;
            Console.WriteLine(NowSelectedTab);
            switch (NowSelectedTab)
            {
                case 0:
                    Console.WriteLine("0");
                    break;
                case 1:
                    Console.WriteLine("1");
                    ChangeTabIndexIs1();
                    break;
                case 2:
                    Console.WriteLine("2");
                    ChangeTabIndexIs2();
                    break;
                case 3:
                    Console.WriteLine("3");
                    ChangeTabIndexIs3();
                    break;
                case 4:
                    Console.WriteLine("4");
                    ChangeTabIndexIs4();
                    break;
                case 5:
                    Console.WriteLine("5");
                    ChangeTabIndexIs5();
                    break;
                case 6:
                    Console.WriteLine("6");
                    ChangeTabIndexIs6();
                    break;
            }
        }
        //************************************************
        //
        //************************************************

        private void ChangeTabIndexIs0()
        {


        }
        private void ChangeTabIndexIs1()
        {
            if (fam_empno.Text == string.Empty)
            {
                return;
            }
            else
            {
                string q_sql = "select fam_name,fam_rel,fam_bth,fam_ltg from thrm_fam_kjh where fam_empno='" + fam_empno.Text + "'";
                OracleCommand q_cmd = new OracleCommand();
                q_cmd.Connection = pgOraConn;
                q_cmd.CommandText = q_sql;
                OracleDataReader q_rd = q_cmd.ExecuteReader();
                int cnt = 0;
                while (q_rd.Read())
                {
                    metroGrid6.Rows.Add();
                    metroGrid6.Rows[cnt].Cells[0].Value = q_rd["fam_name"].ToString();
                    metroGrid6.Rows[cnt].Cells[1].Value = q_rd["fam_rel"].ToString();
                    metroGrid6.Rows[cnt].Cells[2].Value = q_rd["fam_bth"].ToString();
                    metroGrid6.Rows[cnt].Cells[3].Value = q_rd["fam_ltg"].ToString();
                    cnt++;
                }
            }
        }
        private void ChangeTabIndexIs2()
        {
            if (edu_empno.Text == string.Empty)
            {
                return;
            }
            string w_sql = "select edu_loe,edu_entdate,edu_gradate,edu_schnm,edu_dept,edu_degree,edu_grade,edu_gra,edu_last from thrm_edu_kjh where edu_empno='" + edu_empno.Text + "'";
            OracleCommand w_cmd = new OracleCommand();
            w_cmd.Connection = pgOraConn;
            w_cmd.CommandText = w_sql;
            OracleDataReader w_rd = w_cmd.ExecuteReader();
            int cnt = 0;
            while (w_rd.Read())
            {
                metroGrid5.Rows.Add();

                metroGrid5.Rows[cnt].Cells[0].Value = w_rd["edu_loe"].ToString();
                metroGrid5.Rows[cnt].Cells[1].Value = w_rd["edu_entdate"].ToString();
                metroGrid5.Rows[cnt].Cells[2].Value = w_rd["edu_gradate"].ToString();
                metroGrid5.Rows[cnt].Cells[3].Value = w_rd["edu_schnm"].ToString();
                metroGrid5.Rows[cnt].Cells[4].Value = w_rd["edu_dept"].ToString();
                metroGrid5.Rows[cnt].Cells[5].Value = w_rd["edu_degree"].ToString();
                metroGrid5.Rows[cnt].Cells[6].Value = w_rd["edu_grade"].ToString();
                metroGrid5.Rows[cnt].Cells[7].Value = w_rd["edu_gra"].ToString();
                metroGrid5.Rows[cnt].Cells[8].Value = w_rd["edu_last"].ToString();
                cnt++;
            }
        }
        private void ChangeTabIndexIs3()
        {
            if (award_empno.Text == string.Empty) return;
            try
            {
                string e_sql = "select award_date,award_type,award_no,award_kind,award_organ,award_content,award_inout,award_pos,award_dept from thrm_award_kjh where award_empno='" + award_empno.Text + "'";
                OracleCommand e_cmd = new OracleCommand();
                e_cmd.Connection = pgOraConn;
                e_cmd.CommandText = e_sql;
                OracleDataReader e_rd = e_cmd.ExecuteReader();
                int cnt = 0;



                if (award_empno.Text == string.Empty)
                {
                    return;
                }

                while (e_rd.Read())
                {
                    metroGrid4.Rows.Add();
                    metroGrid4.Rows[cnt].Cells[0].Value = e_rd["award_date"].ToString();
                    metroGrid4.Rows[cnt].Cells[1].Value = e_rd["award_type"].ToString();
                    metroGrid4.Rows[cnt].Cells[2].Value = e_rd["award_no"].ToString();
                    metroGrid4.Rows[cnt].Cells[3].Value = e_rd["award_kind"].ToString();
                    metroGrid4.Rows[cnt].Cells[4].Value = e_rd["award_organ"].ToString();
                    metroGrid4.Rows[cnt].Cells[5].Value = e_rd["award_content"].ToString();
                    metroGrid4.Rows[cnt].Cells[6].Value = e_rd["award_inout"].ToString();
                    metroGrid4.Rows[cnt].Cells[7].Value = e_rd["awrad_pos"].ToString();
                    metroGrid4.Rows[cnt].Cells[8].Value = e_rd["award_dept"].ToString();
                    cnt++;
                }
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.ToString());
            }
        }
        private void ChangeTabIndexIs4()
        {
            if (car_empno.Text == string.Empty)
            {
                return;
            }
            string r_sql = "select car_com,car_region,car_yyyymm_f,car_yyyymm_t,car_pos,car_dept,car_job,car_reason from THRM_CAR_kjh where car_empno='" + car_empno.Text + "'";
            OracleCommand r_cmd = new OracleCommand();
            r_cmd.Connection = pgOraConn;
            r_cmd.CommandText = r_sql;
            OracleDataReader r_rd = r_cmd.ExecuteReader();
            int cnt = 0;
            while (r_rd.Read())
            {
                metroGrid3.Rows.Add();
                metroGrid3.Rows[cnt].Cells[0].Value = r_rd["car_com"].ToString();
                metroGrid3.Rows[cnt].Cells[1].Value = r_rd["car_region"].ToString();
                metroGrid3.Rows[cnt].Cells[2].Value = r_rd["car_yyyymm_f"].ToString();
                metroGrid3.Rows[cnt].Cells[3].Value = r_rd["car_yyyymm_t"].ToString();
                metroGrid3.Rows[cnt].Cells[4].Value = r_rd["car_pos"].ToString();
                metroGrid3.Rows[cnt].Cells[5].Value = r_rd["car_dept"].ToString();
                metroGrid3.Rows[cnt].Cells[6].Value = r_rd["car_job"].ToString();
                metroGrid3.Rows[cnt].Cells[7].Value = r_rd["car_reason"].ToString();
                cnt++;
            }
        }
        private void ChangeTabIndexIs5()
        {
            if (lic_empno.Text == string.Empty)
            {
                return;
            }
            string t_sql = "select lic_code,lic_grade,lic_acqdate,lic_organ from thrm_lic_kjh where lic_empno='" + lic_empno.Text + "'";
            OracleCommand t_cmd = new OracleCommand();
            t_cmd.Connection = pgOraConn;
            t_cmd.CommandText = t_sql;
            OracleDataReader t_rd = t_cmd.ExecuteReader();
            int cnt = 0;
            while (t_rd.Read())
            {
                metroGrid2.Rows.Add();
                metroGrid2.Rows[cnt].Cells[0].Value = t_rd["lic_code"].ToString();
                metroGrid2.Rows[cnt].Cells[1].Value = t_rd["lic_grade"].ToString();
                metroGrid2.Rows[cnt].Cells[2].Value = t_rd["lic_acqdate"].ToString();
                metroGrid2.Rows[cnt].Cells[3].Value = t_rd["lic_organ"].ToString();
                cnt++;
            }
        }
        private void ChangeTabIndexIs6()
        {
            if (forl_empno.Text == string.Empty)
            {
                return;
            }
            string y_sql = "select forl_code,forl_score,forl_acqdate,forl_organ from thrm_forl_kjh where forl_empno='" + forl_empno.Text + "'";
            OracleCommand y_cmd = new OracleCommand();
            y_cmd.Connection = pgOraConn;
            y_cmd.CommandText = y_sql;
            OracleDataReader y_rd = y_cmd.ExecuteReader();
            int cnt = 0;
            while (y_rd.Read())
            {
                metroGrid1.Rows.Add();
                metroGrid1.Rows[cnt].Cells[0].Value = y_rd["forl_code"].ToString();
                metroGrid1.Rows[cnt].Cells[1].Value = y_rd["forl_score"].ToString();
                metroGrid1.Rows[cnt].Cells[2].Value = y_rd["forl_acqdate"].ToString();
                metroGrid1.Rows[cnt].Cells[3].Value = y_rd["forl_organ"].ToString();
                cnt++;
            }
        }
        #endregion

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checktext_TextChanged(object sender, EventArgs e)
        {

        }

        private void bas_empno_TextChanged(object sender, EventArgs e)
        {
            fam_empno.Text = bas_empno.Text;
            edu_empno.Text = bas_empno.Text;
            award_empno.Text = bas_empno.Text;
            car_empno.Text = bas_empno.Text;
            lic_empno.Text = bas_empno.Text;
            forl_empno.Text = bas_empno.Text;

        }

        private void rel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fam_rel.SelectedIndex = rel1.SelectedIndex;
        }

        private void fam_rel_SelectedIndexChanged(object sender, EventArgs e)
        {
            rel1.SelectedIndex = fam_rel.SelectedIndex;

        }

        private void metroGrid6_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void bas_name_TextChanged(object sender, EventArgs e)
        {
            fam_nams.Text = bas_name.Text;
            edu_name.Text = bas_name.Text;
            award_name.Text = bas_name.Text;
            car_name.Text = bas_name.Text;
            lic_name.Text = bas_name.Text;
            forl_name.Text = bas_name.Text;
        }

        private void bas_dept_code_TextChanged(object sender, EventArgs e)
        {
            fam_dept.Text = bas_dept_code.Text;
            edu_dept1.Text = bas_dept_code.Text;
            car_deptname.Text = bas_dept_code.Text;
            lic_dept.Text = bas_dept_code.Text;
            forl_dept.Text = bas_dept_code.Text;
            award_dept.Text = bas_dept_code.Text;


        }

        private void metroGrid6_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String dat1;
            int rowIndex = metroGrid6.CurrentRow.Index;
            fam_name.Text = metroGrid6.Rows[rowIndex].Cells[0].Value.ToString();
            rel1.Text = metroGrid6.Rows[rowIndex].Cells[1].Value.ToString();
            dat1 = metroGrid6.Rows[rowIndex].Cells[2].Value.ToString();
            dat1 = dat1.Substring(0, 4) + "-" + dat1.Substring(4, 2) + "-" + dat1.Substring(6, 2);

            fam_bth.Text = dat1;
            fam_ltg.Text = metroGrid6.Rows[rowIndex].Cells[3].Value.ToString();
            try
            {
                string sql1 = "select * from THRM_fam_kjh where fam_empno='" + fam_empno.Text + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sql1;
                cmd.Connection = pgOraConn;
                OracleDataReader rd = cmd.ExecuteReader();
                if (fam_empno.Text != null)
                {
                    if (rd.Read())
                    {


                    }
                }
            }
            catch
            {

            }
        }

        private void metroGrid7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string dat1;
            string dat2;
            int rowIndex = metroGrid5.CurrentRow.Index;
            edu_loe.Text = metroGrid5.Rows[rowIndex].Cells[0].Value.ToString();
            edu_schnm.Text = metroGrid5.Rows[rowIndex].Cells[3].Value.ToString();
            edu_dept.Text = metroGrid5.Rows[rowIndex].Cells[4].Value.ToString();
            edu_degree.Text = metroGrid5.Rows[rowIndex].Cells[5].Value.ToString();
            edu_grade.Text = metroGrid5.Rows[rowIndex].Cells[6].Value.ToString();
            edu_last.Text = metroGrid5.Rows[rowIndex].Cells[8].Value.ToString();
            edu_gra.Text = metroGrid5.Rows[rowIndex].Cells[7].Value.ToString();
            dat1 = metroGrid5.Rows[rowIndex].Cells[1].Value.ToString();
            dat1 = dat1.Substring(0, 4) + "-" + dat1.Substring(4, 2) + "-" + dat1.Substring(6, 2);
            edu_entdate.Text = dat1;
            dat2 = metroGrid5.Rows[rowIndex].Cells[2].Value.ToString();
            dat2 = dat2.Substring(0, 4) + "-" + dat2.Substring(4, 2) + "-" + dat2.Substring(6, 2);
            edu_gradate.Text = dat2;

            try
            {
                string sql1 = "select * from THRM_edu_kjh where edu_empno='" + edu_empno.Text + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sql1;
                cmd.Connection = pgOraConn;
                OracleDataReader rd = cmd.ExecuteReader();
                if (fam_empno.Text != null)
                {
                    if (rd.Read())
                    {

                        //여기 

                    }
                }
            }
            catch
            {

            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {



        }

        //private void metroButton1_Click(object sender, EventArgs e)
        //  {
        //  metroGrid7.Columns.Clear();
        // metroGrid7.Rows.Clear();
        //metroGrid7.Columns.Add("bas_empno", "사번");
        // metroGrid7.Columns.Add("bas_name", "성명");
        //metroGrid7.Columns.Add("cd_codnms", "직급");
        //metroGrid7.Columns.Add("dept_name", "부서");
        //string sql = "select bas_empno, bas_name, bas_pos, cd_codnms, bas_dept, dept_name from thrm_bas_kjh,(select cd_grpcd, cd_code, cd_codnms from TIEAS_CD_KJH where cd_grpcd = 'POS'),( select * from THRM_DEPT_KJH) where bas_pos = cd_code and bas_dept = dept_code and bas_empno like '%%' and bas_name like '%" + textBox1.Text + "%'";
        //
        //OracleCommand cmd = new OracleCommand();
        //cmd.Connection = pgOraConn;
        //cmd.CommandText = sql;
        //OracleDataReader rd = cmd.ExecuteReader();
        //int cnt = 0;
        //if (textBox2.Text == "")
        //{
        //    MessageBox.Show("부서이름을 입력해주세요.");
        //    return;
        //}
        //else
        //{
        //
        //    while (rd.Read())
        //    {
        //        metroGrid7.Rows.Add();
        ////       metroGrid7.Rows[cnt].Cells["bas_empno"].Value = rd["bas_empno"].ToString();
        //     metroGrid7.Rows[cnt].Cells["bas_name"].Value = rd["bas_name"].ToString();
        //     metroGrid7.Rows[cnt].Cells["cd_codnms"].Value = rd["cd_codnms"].ToString();
        //     metroGrid7.Rows[cnt].Cells["dept_name"].Value = rd["dept_name"].ToString();
        //     return;
        // }
        //  //} //
        //}     //

        private void metroGrid4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string dat1;

            int rowIndex = metroGrid4.CurrentRow.Index;
            dat1 = metroGrid4.Rows[rowIndex].Cells[0].Value.ToString();
            award_type.Text = metroGrid4.Rows[rowIndex].Cells[1].Value.ToString();
            award_no.Text = metroGrid4.Rows[rowIndex].Cells[2].Value.ToString();
            award_kind.Text = metroGrid4.Rows[rowIndex].Cells[3].Value.ToString();
            award_organ.Text = metroGrid4.Rows[rowIndex].Cells[4].Value.ToString();
            award_content.Text = metroGrid4.Rows[rowIndex].Cells[5].Value.ToString();
            award_inout.Text = metroGrid4.Rows[rowIndex].Cells[6].Value.ToString();

            dat1 = dat1.Substring(0, 4) + "-" + dat1.Substring(4, 2) + "-" + dat1.Substring(6, 2);
            award_date.Text = dat1;


            try
            {
                string sql1 = "select * from THRM_edu_kjh where edu_empno='" + edu_empno.Text + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sql1;
                cmd.Connection = pgOraConn;
                OracleDataReader rd = cmd.ExecuteReader();
                if (award_empno.Text != null)
                {
                    if (rd.Read())
                    {


                    }
                }
            }
            catch
            {

            }
        }

        private void metroGrid3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string dat1;
            string dat2;
            int rowIndex = metroGrid3.CurrentRow.Index;
            car_com.Text = metroGrid3.Rows[rowIndex].Cells[0].Value.ToString();
            car_region.Text = metroGrid3.Rows[rowIndex].Cells[1].Value.ToString();
            dat1 = metroGrid3.Rows[rowIndex].Cells[2].Value.ToString();
            dat2 = metroGrid3.Rows[rowIndex].Cells[3].Value.ToString();
            car_pos.Text = metroGrid3.Rows[rowIndex].Cells[4].Value.ToString();
            car_dept.Text = metroGrid3.Rows[rowIndex].Cells[5].Value.ToString();
            car_job.Text = metroGrid3.Rows[rowIndex].Cells[6].Value.ToString();
            car_reason.Text = metroGrid3.Rows[rowIndex].Cells[7].Value.ToString();

            dat1 = dat1.Substring(0, 4) + "-" + dat1.Substring(4, 2);
            car_yyyymm_f.Text = dat1;
            dat2 = dat2.Substring(0, 4) + "-" + dat2.Substring(4, 2);
            car_yyyymm_t.Text = dat2;


            try
            {
                string sql1 = "select * from THRM_car_kjh where car_empno='" + car_empno.Text + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sql1;
                cmd.Connection = pgOraConn;
                OracleDataReader rd = cmd.ExecuteReader();
                if (car_empno.Text != null)
                {
                    if (rd.Read())
                    {


                    }
                }
            }
            catch
            {

            }
        }

        private void metroGrid2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string dat1;
            int rowIndex = metroGrid2.CurrentRow.Index;
            lic_code.Text = metroGrid2.Rows[rowIndex].Cells[0].Value.ToString();
            lic_grade.Text = metroGrid2.Rows[rowIndex].Cells[1].Value.ToString();
            dat1 = metroGrid2.Rows[rowIndex].Cells[2].Value.ToString();
            lic_organ.Text = metroGrid2.Rows[rowIndex].Cells[3].Value.ToString();
            dat1 = dat1.Substring(0, 4) + "-" + dat1.Substring(4, 2) + "-" + dat1.Substring(6, 2);
            lic_acqdate.Text = dat1;


            try
            {
                string sql1 = "select * from THRM_lic_kjh where lic_empno='" + lic_empno.Text + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sql1;
                cmd.Connection = pgOraConn;
                OracleDataReader rd = cmd.ExecuteReader();
                if (lic_empno.Text != null)
                {
                    if (rd.Read())
                    {


                    }
                }
            }
            catch
            {

            }
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string dat1;
            int rowIndex = metroGrid1.CurrentRow.Index;
            forl_code.Text = metroGrid1.Rows[rowIndex].Cells[0].Value.ToString();
            forl_score.Text = metroGrid1.Rows[rowIndex].Cells[1].Value.ToString();
            dat1 = metroGrid1.Rows[rowIndex].Cells[2].Value.ToString();
            forl_organ.Text = metroGrid1.Rows[rowIndex].Cells[3].Value.ToString();
            dat1 = dat1.Substring(0, 4) + "-" + dat1.Substring(4, 2) + "-" + dat1.Substring(6, 2);
            forl_acqdate.Text = dat1;


            try
            {
                string sql1 = "select * from THRM_forl_kjh where forl_empno='" + forl_empno.Text + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sql1;
                cmd.Connection = pgOraConn;
                OracleDataReader rd = cmd.ExecuteReader();
                if (forl_empno.Text != null)
                {
                    if (rd.Read())
                    {


                    }
                }
            }
            catch
            {

            }
        }
    }
}




