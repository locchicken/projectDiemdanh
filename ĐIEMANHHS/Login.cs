using Biden.Data;
using Biden.Model;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool dragging;
        private Point pointClicked;
        private TrangChu tt;
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backGround1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point pointMoveTo;
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));
                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);
                this.Location = pointMoveTo;
            }
        }

        private void backGround1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                pointClicked = new Point(e.X, e.Y);
            }
            else
            {
                dragging = false;
            }
        }

        private void backGround1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
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

        private void backGround1_Paint(object sender, PaintEventArgs e)
        {

        }
        int counter = 0;
        int len = 0;
        string txt;

        private void Login_Load(object sender, EventArgs e)
        {
            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";
            timer1.Start();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Trim() == "" || txtpass.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin!", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "call myclassroombiden.sp_teacherLogin('"+ txtuser.Text.Trim() + "', '"+ txtpass.Text.Trim()+ "');";
            Account acc = DataHelper.CheckLogin(txtuser.Text.Trim(), txtpass.Text.Trim(), query);
            if (acc != null)
            {
                //ShareData.info = acc;
                tt = new TrangChu();
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Hide();
                tt.Show();
                tt.WindowState = FormWindowState.Maximized;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
