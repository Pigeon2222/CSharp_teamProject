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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.btn_Register.Click += Btn_Click;
        }

        public void Btn_Click(object sender, EventArgs e)
        {
            InserEmployeeData();
        }
        public void InserEmployeeData()
        {
            DataSet ds=new DataSet();
            string query=string.Empty;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        
    }
}
