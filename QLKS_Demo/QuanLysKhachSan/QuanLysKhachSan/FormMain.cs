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

<<<<<<< HEAD
        private void danhSáchPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoom formroom = new FormRoom();
            formroom.ShowDialog();
        }

        private void thôngTinPhòngThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoom form = new FormRoom();
            form.ShowDialog();
        }

        private void thôngTinLoạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoom form = new FormRoom();
            form.ShowDialog();
=======
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng màn hình chính?", "Thông báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
>>>>>>> fb2e5e432c4e413222c24ddce8561edfa513d96b
        }
    }
}
