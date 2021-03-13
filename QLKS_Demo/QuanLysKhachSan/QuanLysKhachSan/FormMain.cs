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
            form.ShowDialog();
        }

        private void thôngTinThẻPhòngThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDatphong datphong = new FormDatphong();
            datphong.ShowDialog();
            //TabControl1
        }

        private void danhSáchKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer formcustomer = new FormCustomer();
            formcustomer.ShowDialog();
        }

        private void danhSáchDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDichVu formQLDV = new frmQLDichVu();
            formQLDV.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmthanhtoan f = new frmthanhtoan();
            f.ShowDialog();
        }

        private void thêmDịchVuMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmDịchVụMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDichVu formQLDV = new frmQLDichVu();
            formQLDV.ShowDialog();
        }

        private void thôngTinDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLDichVu formQLDV = new frmQLDichVu();
            formQLDV.ShowDialog();
        }

        private void thôngTinNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDatphong d = new FormDatphong();
            d.ShowDialog();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp h = new FormHelp();
            h.ShowDialog();
        }

        private void câuHỏiThườngGặpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp h = new FormHelp();
            h.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
