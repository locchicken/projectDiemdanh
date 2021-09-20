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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btndmk_Click(object sender, EventArgs e)
        {
            if (txtpass.Text.Trim() == "" || txtpass1.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin!", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtpass.Text.Trim()!= txtpass1.Text.Trim())
            {
                MessageBox.Show("Mật khẩu không khớp!", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Account acc = DataHelper.CheckPass(txtuser.Text.Trim(), txtpasscu.Text.Trim());
                if(acc!=null)
                {
                    if(DataHelper.changePass(txtuser.Text.Trim(), txtpass.Text.Trim(), txtpass1.Text.Trim()))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        MessageBox.Show("Đổi thất bại!", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
