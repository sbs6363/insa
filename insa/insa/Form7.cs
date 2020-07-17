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
                    MessageBox.Show("인사기본사항에서 사원번호를 입력해주세요.");
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
                if(String.IsNullOrWhiteSpace(edu_empno.Text))
                {
                    MessageBox.Show("인사기본사항에서 사원번호를 입력해주세요.");
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
                btn_control1();
                checktext.Text = "A_i";
                MessageBox.Show("상벌이력을 입력해주세요.");
                award_type.Text = "";
                award_no.Text = "";
                award_kind.Text = "";
                award_organ.Text = "";
                award_content.Text = "";
                award_inout.Text = "";

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
           btn_control2() 
        }
    }

}
