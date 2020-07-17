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
using Oracle.ManagedDataAccess.Client;


namespace insa
{
    public partial class Form7 : MetroForm
    {
        public Form7()
        {
            InitializeComponent();
        }
    
        //오라클 커넥션 해주는 것
        OracleConnection pgOraConn;
        //sql에 대한 결과값 반환
        OracleCommand pgOraCmd;

        //oracle 연동 ip,name,id,pw
        string dbIp = "222.237.134.74";
        string dbName = "Ora7";
        string dbId = "EDU";
        string dbPw = "edu1234";

        //********//
        //입력 버튼//
        //*******//
        private void insert_Click(object sender, EventArgs e)
        {
            //인사기본사항 탭 페이지의 경우 작동하는 기능
            if (tabControl1.SelectedTab.TabIndex == 0)
            {
                //bas_empno로 시작
                bas_empno.Focus();
                //인사기본 입력 버튼을 누를 시 발생하는 이벤트
                clearTextBox();
                //입력버튼을 누를 시 괄호 안에 있는 내용을 포함한 창이 뜬다.
                MessageBox.Show("인사기본사항을 입력하세요.");
                //입력수정삭제 버튼 비활성화와 동시에 확인,취소 버튼은 활성화
                btn_control1();
                //현재 상태를 확인할 수 있는 checktextbox에서 입력상태라고 표시를 해준다.
                checktext.Text = "I";
                //입력 상태에선 입력할 필요가 없는 부분들은 Enabled = False;로 막아준다.
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
                //datetimepicker 표시 방식을 좀 더 보기 좋게 만드는 기능이다.
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
            // 탭 페이지가 가족사항인 경우 입력버튼을 누르면 일어나는 기능들이다.
            else if (tabControl1.SelectedTab.TabIndex == 1)
            {
                //fam_empno 텍스트 박스가 비어 있거나 공백 문자로 구성되어 있을 경우 발생하는 문구
                if (string.IsNullOrWhiteSpace(fam_empno.Text))
                {
                    MessageBox.Show("가족사항에서 사원번호를 입력해주세요.");
                    return;
                }
                else
                {
                    btn_control1();
                    //현재 상태를 알려주는 checktextbox에서 가족사항의 입력상태라고 알려줌
                    checktext.Text = "F_i";
                    //가족사항 페이지에서 입력버튼을 누르면 확인 창과 함께 괄호 안에 있는 내용이 나온다.
                    MessageBox.Show("가족사항을 입력해주세요.");
                    //동거여부에서 대부분 같이 살기 때문에 예스로 표시 해준다.
                    fam_ltg.Text = "Y";
                    //입력버튼을 누르면 가족분의 이름을 작성할 수 있게 fam_name 부분에 초점을 둔다.
                    fam_name.Focus();
                    //fam_bth 데이트타임피커에서 형식을 짧은 형식으로 지정한다.
                    fam_bth.Format = DateTimePickerFormat.Short;
                }
            }
            else if (tabControl1.SelectedTab.TabIndex == 2)
            {
                //학력 사항의 창에 사원번호가 비어 있거나 공백인 경우 해당 이벤트가 발생한다.
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
                btn_control1();
                checktext.Text = "A_i";
                MessageBox.Show("상벌이력을 입력해주세요.");


            }
            else if (tabControl1.SelectedTab.TabIndex == 4)
            {
                if (String.IsNullOrWhiteSpace(car_empno.Text))
                {
                    MessageBox.Show("경력사항에서 사원번호를 입력해주세요.");
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
                    MessageBox.Show("자격 면허에서 사원번호를 입력해주세요.");
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
                    MessageBox.Show("외국어에서 사원번호를 입력해주세요");
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

        //인사기본사항 입력 버튼을 누를 시 발생하는 이벤트
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
        //입력버튼을 누를 시 입력,수정,버튼이 비활성화 되며, 확인,취소 버튼만 활성화된다.
        private void btn_control1()
        {
            insert.Enabled = false;
            update.Enabled = false;
            delete.Enabled = false;
            Confirm.Enabled = true;
            Cancel.Enabled = true;
        }
        //처음 폼이 로드될 때 입력,수정,삭제 버튼만 활성화되며, 확인,취소를 사용하지 못하게 비활성화 시킨다 .
        private void btn_control2()
        {
            insert.Enabled = true;
            update.Enabled = true;
            delete.Enabled = true;
            Confirm.Enabled = false;
            Cancel.Enabled = false;
        }
        //Form7을 시작하면 불러오는 기능
        private void Form7_Load(object sender, EventArgs e)
        {
            //폼이 시작되고 확인,취소를 눌러서 오류가 발생하지 않게 확인,취소 버튼은 비활성화 시킨다.
            btn_control2();
        }
        

        //왼쪽 데이터 그리드뷰 검색기능 
        private void sabun_display()
        {

            //저장한 data 읽어오기
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
                    //부서 검색 코드와 부서명 절취하는 기능
                    String[] dept = as1.Split(':');


                    //이 내용들은 MetroGrid7에서 검색을 하여 나오는 결과를 더블클릭 했을 경우에 내용을 불러오는 내용들이다.
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

        private void update_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.TabIndex == 0)
            {
                if(String.IsNullOrWhiteSpace(bas_empno.Text))
                {
                    MessageBox.Show("사원번호를 입력하세요.");
                    return;
                }
                else
                {
                    //MetroGird7에서 thrm_bas_kjh에 있는 내용을 더블클릭하여 가져온다.
                    sabun_display();
                    btn_control1();
                    MessageBox.Show("수정하실 내용을 수정해주세요.");
                }
                checktext.Text="U";
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
    }

}
