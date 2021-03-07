using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLysKhachSan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void danhSáchPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoom formroom = new FormRoom();
            formroom.ShowDialog();
        }

        private void thôngTinPhòngThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoom form = new FormRoom();
            form.a = 1;
            form.ShowDialog();
        }

        private void thôngTinLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoom form = new FormRoom();
            form.a = 0;
            form.ShowDialog();

        }

        private void tạoThẻPhòngThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDatphong form = new FormDatphong();
            form.Show();
        }
    }
}
