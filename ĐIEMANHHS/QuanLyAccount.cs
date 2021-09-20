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
    public partial class QuanLyAccount : Form
    {
        public QuanLyAccount()
        {
            InitializeComponent();
        }
        private Account account;
        private void btnadd_Click(object sender, EventArgs e)
        {
            account = new Account();
            account.setUser("admin");
            account.setEmail(txtmail.Text.Trim());
            account.setPass(txtpass.Text.Trim());
            account.setType((cbtype.SelectedIndex)+1);
            account.setAdmin(cbadmin.SelectedIndex);
            account.setRole(txtrole.Text.Trim());
            if (DataHelper.InsertAccount(account))
            {
                MessageBox.Show("Đã thêm dữ liệu thành công");
            }
            else
            {
                MessageBox.Show("Đã thêm dữ liệu thành công");
            }
        }
        void load()
        {
            DataAccount.Rows.Clear();
            string query = "select * from teacher_login order by STT ASC";
            List<Account> list = DataHelper.FindAccount(query);
            foreach (Account item in list)
            {
                DataAccount.Rows.Add(item.getID(), item.getUser(), item.getPass(), item.getAdmin(),item.getType());
            }
        }

        private void QuanLyAccount_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            load();
        }
    }
}
