using Biden.Data;
using ĐIEMANHHS.Model;
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
    public partial class THPT : Form
    {
        public THPT()
        {
            InitializeComponent();
        }

        private void THPT_Load(object sender, EventArgs e)
        {
            loadClass_HS();
        }
        void loadClass_HS()
        {
            DataHS.Rows.Clear();
            string query = "select * from class_hs order by CLHS_ID ASC";
            List<ClassTHPT> list = DataHelper.FindTHPT(query);
            foreach (ClassTHPT item in list)
            {
                DataHS.Rows.Add(item.getID());
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtclass.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin!", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DataHelper.InsertTHPT("admin", txtclass.Text.Trim()))
            {
                MessageBox.Show("Thêm Khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                loadClass_HS();
            }
        }
    }
}
