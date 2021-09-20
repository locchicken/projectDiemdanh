using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ĐIEMANHHS
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int counter = 0;
        int len = 0;
        string txt;

        private void TrangChu_Load(object sender, EventArgs e)
        {
            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter > len)
            {
                counter = 0;
                label1.Text = "";
            }

            else
            {

                label1.Text = txt.Substring(0, counter);

                if (label1.ForeColor == Color.Blue)
                    label1.ForeColor = Color.Orange;
                else
                    label1.ForeColor = Color.Blue;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đăng xuất không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dl==DialogResult.Yes)
            {
                Login lg = new Login();
                this.Hide();
                lg.Show();
            }
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            LopTheoMon l = new LopTheoMon();
           
            l.Show();
            l.WindowState = FormWindowState.Maximized;
        }

        private void btntt_Click(object sender, EventArgs e)
        {
            ThongKe t = new ThongKe();
         
            t.Show();
            t.WindowState = FormWindowState.Maximized;
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            Profile p = new Profile();
           
            p.Show();
            p.WindowState = FormWindowState.Maximized;
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            Admin p = new Admin();

            p.Show();
            p.WindowState = FormWindowState.Maximized;
        }
    }
}
