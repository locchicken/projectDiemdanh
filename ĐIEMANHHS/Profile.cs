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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void btndmk_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.ShowDialog();
        }
    }
}
