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
    public partial class ThongTin : Form
    {
        public ThongTin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer2_Tick(object sender, EventArgs e)
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
        int counter = 0;
        int len = 0;
        string txt;
        private void ThongTin_Load(object sender, EventArgs e)
        {
            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";
            timer1.Start();
            loadFaculty();
            LoadSpeciality();
            loadClassUni();
        }

        private void btnaddfaculty_Click(object sender, EventArgs e)
        {
            if (txtIDfaculty.Text.Trim() == "" || txtnamefaculty.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin!", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(DataHelper.InsertFaculty("admin", txtIDfaculty.Text.Trim(), txtnamefaculty.Text.Trim()))
            {
                MessageBox.Show("Thêm Khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                loadFaculty();
            }
        }
        void loadFaculty()
        {
            DataFaculty.Rows.Clear();
            string query = "select * from faculty order by FCT_ID ASC";
            List<Faculty> list = DataHelper.FindFaculty(query);
            foreach (Faculty item in list)
            {
                DataFaculty.Rows.Add(item.getID(), item.getName());
            }
        }

        private void btnaddspec_Click(object sender, EventArgs e)
        {
            if (txtspec.Text.Trim() == "" || txtnamespec.Text.Trim() == "" || txtidFa.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin!", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DataHelper.InsertSpeciality("admin", txtspec.Text.Trim(), txtnamespec.Text.Trim(), txtidFa.Text.Trim()))
            {
                MessageBox.Show("Thêm chuyên ngành thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                LoadSpeciality();
            }
        }
        void LoadSpeciality()
        {
            DataSpeciality.Rows.Clear();
            string query = "select * from speciality order by SPC_ID ASC";
            List<Speciality> list = DataHelper.FindSpeciality(query);
            foreach (Speciality item in list)
            {
                DataSpeciality.Rows.Add(item.getID(), item.getName(), item.getFaculty());
            }
        }

        private void btnaddClass_Click(object sender, EventArgs e)
        {
            if (txtclass.Text.Trim() == "" || txtspecClass.Text.Trim() == "" || txtFaclass.Text.Trim() == "")
            {
                MessageBox.Show("Chưa điền đủ thông tin!", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DataHelper.InsertClassUni("admin", txtclass.Text.Trim(), txtspecClass.Text.Trim(), txtFaclass.Text.Trim()))
            {
                MessageBox.Show("Thêm lớp Đại Học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                loadClassUni();
            }
        }
        void loadClassUni()
        {
            DataClass.Rows.Clear();
            string query = "select * from class_uni order by CLU_ID ASC";
            List<Class_uni> list = DataHelper.FindClassUni(query);
            foreach (Class_uni item in list)
            {
                DataClass.Rows.Add(item.getID(), item.getSpec(), item.getFaculty());
            }
        }
    }
}
