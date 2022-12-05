using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heunghae_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string userid=txt_id.Text;
            string userpw = txt_pw.Text;

            if (userid.Equals("MyId") && userpw.Equals("MyPw"))
            {
                MessageBox.Show("로그인 성공했습니다.", "LOGIN");
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.", "LOGIN");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
