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
    public partial class Form4 : MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(String a1, Form f1)
        {
            InitializeComponent();

        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "인사코드 관리")
            {
                Console.WriteLine("--" + 1);
                Form6 frm6 = new Form6(0);
                frm6.ShowDialog();
            }
            else if (e.Node.Text == "부서코드 관리")
            {
                Console.WriteLine("--" + 1);
                Form6 frm6 = new Form6(1);
                frm6.ShowDialog();
            }
            else if (e.Node.Text == "직급코드 관리")
            {
                Console.WriteLine("--" + 1);
                Form6 frm6 = new Form6(2);
                frm6.ShowDialog();
            }
            else if (e.Node.Text == "직책코드 관리")
            {
                Console.WriteLine("--" + 1);
                Form6 frm6 = new Form6(3);
                frm6.ShowDialog();
            }
            else if (e.Node.Text == "인사기본사항")
            {
                Console.WriteLine("--" + 1);
                Form2 frm2 = new Form2(0);
                frm2.ShowDialog();



            } else if (e.Node.Text == "가족사항")
            {
                Console.WriteLine("--" + 1);
                Form2 frm2 = new Form2(1);
                frm2.ShowDialog();

            }
            else if (e.Node.Text == "학력사항")
            {
                Console.WriteLine("--" + 1);
                Form2 frm2 = new Form2(2);
                frm2.ShowDialog();

            }
            else if (e.Node.Text == "상벌사항")
            {
                Console.WriteLine("--" + 1);
                Form2 frm2 = new Form2(3);
                frm2.ShowDialog();

            }
            else if (e.Node.Text == "경력사항")
            {
                Console.WriteLine("--" + 1);
                Form2 frm2 = new Form2(4);
                frm2.ShowDialog();

            }
            else if (e.Node.Text == "자격면허")
            {
                Console.WriteLine("--" + 1);
                Form2 frm2 = new Form2(5);
                frm2.ShowDialog();

            }
            else if (e.Node.Text == "외국어")
            {
                Console.WriteLine("--" + 1);
                Form2 frm2 = new Form2(6);
                frm2.ShowDialog();

            }
            else
            {
                return;
            }


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        { 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
