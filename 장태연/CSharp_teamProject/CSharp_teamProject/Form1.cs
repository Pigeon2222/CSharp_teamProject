using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_teamProject
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
            
        }

       

        private void MyPage_label1_Click(object sender, EventArgs e)
        {

        }

        private void MyPage_button10_Click(object sender, EventArgs e)
        {
            MyPage_panel2.Visible = false;
            MyPage_panel3.Visible = false;
        }

        private void MyPage_button11_Click(object sender, EventArgs e)
        {

            MyPage_panel2.Visible = true;
            MyPage_panel3.Visible = false;
            MyPage_panel2.BringToFront();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void MyPage_loginSuccess1_Load(object sender, EventArgs e)
        {

        }

        private void loginSuccess1_Load(object sender, EventArgs e)
        {

        }

        private void MyPage_loginSuccess1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MyPage_button4_1_Click(object sender, EventArgs e)
        {
            MyPage_panel3.Visible = true;
            MyPage_panel3.BringToFront();
            
            //이미 로그인을 한 상태이기 때문에 
            //예를 들어 변수 loggedId 에 아이디가 들어가있다고 가정함.
            string loggedId = "titia";

            //데이터매니저 통해서 해보자.
            DataManager dm = new DataManager();
            usertable_ty ust = dm.Mypage_info(loggedId);

            MyPage_label5_2.Text = ust.user_name;
            MyPage_label6_2.Text = ust.user_id;
            MyPage_label7_2.Text = ust.user_phonenum;
            MyPage_label8_2.Text = ust.user_email;
        }

        private void MyPage_panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MyPage_label1_1_Click(object sender, EventArgs e)
        {

        }

        private void MyPage_panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
