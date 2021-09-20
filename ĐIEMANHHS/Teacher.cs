using Biden.Data;
using Biden.Model;
using ĐIEMANHHS.Model;
using ĐIEMANHHS.ShareData;
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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }
        private Account account;
        int counter = 0;
        int len = 0;
        string txt;
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

        private void Teacher_Load(object sender, EventArgs e)
        {
            //txt = label1.Text;
            //len = txt.Length;
            //label1.Text = "";
            //timer1.Start();
            write();
            load();

        }
        void load()
        {
            DataTeacher.Rows.Clear();
            string query = "SELECT * FROM myclassroombiden.teacher_info";
            List<TeacherInfo> list = DataHelper.FindTeacher(query);
            foreach (TeacherInfo item in list)
            {
                DataTeacher.Rows.Add(item.getID(), item.getName(), item.getBOD(), item.getSex(), item.getAddress(), item.getPhone(), item.getMail(), item.getRole(), item.getSchool());
            }

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            account = new Account();
            account.setUser("admin");
            account.setEmail(txtmail.Text.Trim());
            account.setPass(txtpass.Text.Trim());
            account.setType((cbtype.SelectedIndex) + 1);
            account.setAdmin(cbadmin.SelectedIndex);
            account.setRole(txtrole.Text.Trim());
            if (DataHelper.InsertAccount(account))
            {
                MessageBox.Show("Đã thêm dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                write();
            }
            else
            {
                MessageBox.Show("Email đã tồn tại hoặc thiếu @gmail.com vui lòng xem lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {

        }
        void write()
        {
            writelog.Rows.Clear();
            string query = "SELECT * FROM myclassroombiden.writelog order by ID desc";
            List<WriteLog> list = DataHelper.FindWriteLog(query);
            foreach (WriteLog item in list)
            {
                writelog.Rows.Add(item.getActive(), item.getTime());
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(id==null)
            {
                MessageBox.Show("Chưa chọn thông tin giao viên để cập nhập!", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                UpdateTeacher up = new UpdateTeacher();
                up.ShowDialog();
            }
        }
        private static string id;
        private void DataTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
                TeacherInfo teacher = new TeacherInfo();
                if (DataTeacher.Rows.Count > 0)
                    if (DataTeacher.CurrentCell.ColumnIndex == 0)
                    {
                        id = DataTeacher.CurrentCell.Value.ToString();
                        Account account = DataHelper.FindAccountID(id);
                        teacher = DataHelper.FindTeacherID(id);
                        if (teacher != null||account!=null)
                        {
                            txtrole.Text = teacher.getRole();
                            
                            int admin = account.getAdmin();
                             chiase.acc = account;
                             LayTeacher.info = teacher;
                            if (admin == 0)
                            {
                                cbadmin.SelectedIndex = cbadmin.FindStringExact("Không");
                            }
                            else if (admin == 1)
                            {
                                cbadmin.SelectedIndex = cbadmin.FindStringExact("Admin");
                            }
                            
                          }
                      
                    }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            write();
            load();
        }
    }
}
