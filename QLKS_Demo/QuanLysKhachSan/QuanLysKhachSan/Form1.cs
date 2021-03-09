using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLysKhachSan
{
    public partial class frmthanhtoan : Form
    {
        public frmthanhtoan()
        {
            InitializeComponent();
        }
        string sql;
        string chuoiketnoi = @"Data Source=DESKTOP-53IQ0S1\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ThePhongThue' table. You can move, or remove it, as needed.
            this.thePhongThueTableAdapter.Fill(this.dataSet1.ThePhongThue);
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();


        }
        public void hienthi()
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"select mathe, maphong, manv, tenkhachhang, socmt, ngaythue, ngaydukientra from thephongthue";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[3].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[4].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[5].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[6].ToString());
                i++;
            }
            ketnoi.Close();


        }

        private void btnhienthikh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"select mathe, maphong, manv, tenkhachhang, socmt, ngaythue, ngaydukientra from thephongthue where (mathe like'%" + cbmathe.Text + "%')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[3].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[4].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[5].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[6].ToString());
                i++;
            }
            ketnoi.Close();


        }

        private void lbngayxuathoadon_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            sql = @"select mahd,ngayxuathoadon,tongtien,mathe from hoadon";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            while (docdulieu.Read())
            {
                lbmahd.Text = docdulieu[0].ToString();
                lbngayxuathd.Text = docdulieu[1].ToString();
                lbtinhtongtien.Text = docdulieu[2].ToString();
                lbmt.Text = docdulieu[3].ToString();
            }
            ketnoi.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }

        }
    }
}
