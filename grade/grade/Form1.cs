using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string text = cmbox.Text;
            if (text.Equals("Thông tin xe"))
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else if (text.Equals("Thông tin bảo dưỡng"))
            {
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn chưa lựa chọn Loại thông tin");
            }
        }
    }
}
