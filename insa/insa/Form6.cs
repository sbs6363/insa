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
namespace insa
{
    public partial class Form6 : MetroForm
    {
        public Form6()
        {
            InitializeComponent();
        }
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

