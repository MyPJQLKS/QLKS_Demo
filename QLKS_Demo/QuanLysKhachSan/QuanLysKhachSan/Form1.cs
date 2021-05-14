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
        //string chuoiketnoi = @"Data Source=DESKTOP-53IQ0S1\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
        string chuoiketnoi = SqlStringConnect.stringConnect;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ThePhongThue' table. You can move, or remove it, as needed.
            //this.thePhongThueTableAdapter.Fill(this.dataSet1.ThePhongThue);
            //lấy thông tin 

            fix();
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();


        }
        public void fix()
        {
            using(SqlConnection con = new SqlConnection(chuoiketnoi))
            {
                con.Open();
                string que = "Select mathe from thephongthue";
                SqlCommand coman = new SqlCommand(que, con);
                DataTable data = new DataTable();
                data.Load(coman.ExecuteReader());
                data.Dispose();
                cbmathe.DisplayMember = "mathe";
                cbmathe.DataSource = data;
                con.Close();
            }    
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
            /* ketnoi.Open();
             sql = @"select mahd,ngayxuathoadon,tongtien,hd.mathe from hoadon hd, ThePhongThue ttp where hd.mathe=ttp.mathe and ttp.mathe='" + cbmathe.Text+"'";
             thuchien = new SqlCommand(sql, ketnoi);
             docdulieu = thuchien.ExecuteReader();
             while (docdulieu.Read())
             {
                 lbmahd.Text = docdulieu[0].ToString();
                 lbngayxuathd.Text = docdulieu[1].ToString();
                 lbtinhtongtien.Text = docdulieu[2].ToString();
                 lbmt.Text = docdulieu[3].ToString();
             }
             ketnoi.Close();*/
            string ngayHD = "";
            string tongTien = "";
            ngayHD = DateTime.Now.ToShortDateString();
            double tienTro = 0;
            double tienDV = 0;
            DataTable data = new DataTable();
            data = DataExcute.Instance.ExecuteQuery("Select t.ngaythue, t.ngaydukientra, lp.dongia from thephongthue t, phong p, loaiphong lp where t.maphong = p.maphong and p.maloaiphong = lp.maloaiphong and t.mathe = '"+ cbmathe.Text + "'");
            foreach (DataRow item in data.Rows)
            {
                double donGia = Convert.ToDouble(item["dongia"].ToString());
                DateTime ngayBD = Convert.ToDateTime(item["ngaythue"].ToString());
                DateTime ngaykt = Convert.ToDateTime(item["ngaydukientra"].ToString());
                TimeSpan time = ngaykt - ngayBD;
                double soNgay = time.TotalDays;
                tienTro = donGia * (soNgay+1);
            }
            data = DataExcute.Instance.ExecuteQuery("Select madv, soluong, mathe from TheDichVu tdv where mathe='"+cbmathe.Text+"'");
            foreach (DataRow item in data.Rows)
            {
                string madv = item["madv"].ToString();
                int sL = Convert.ToInt32(item["soluong"].ToString());
                double donGia = 0;
                DataTable d = DataExcute.Instance.ExecuteQuery("Select dongia from dichvu where madv='" + madv + "'");
                foreach (DataRow it in d.Rows)
                {
                    donGia = Convert.ToDouble(it["dongia"].ToString());
                }
                tienDV += sL * donGia;
            }
            //MessageBox.Show(tienTro.ToString() + "  " + tienDV.ToString());

            double tong = tienDV + tienTro;
            tongTien = tong.ToString();

            string updateHD = "Update HoaDon set ngayxuathoadon='"+ngayHD+"', tongtien="+tongTien+" where mathe='"+cbmathe.Text+"'";
            DataExcute.Instance.ExecuteNonQuery(updateHD);

            DataTable dataTable = DataExcute.Instance.ExecuteQuery("select mahd,ngayxuathoadon,tongtien,hd.mathe from hoadon hd, ThePhongThue ttp where hd.mathe=ttp.mathe and ttp.mathe='" + cbmathe.Text + "'");
            foreach (DataRow item in dataTable.Rows)
            {
                lbmahd.Text = item["mahd"].ToString();
                lbngayxuathd.Text = ngayHD;
                lbtinhtongtien.Text = item["tongtien"].ToString();
                lbmt.Text = item["mathe"].ToString();
            }
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

        private void buttonIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In hóa đơn thành công");
            //set lại phòng
            /* DataTable data = DataExcute.Instance.ExecuteQuery("Select maphong from thephongthue where mathe = '" + cbmathe.Text + "'");
             string maphong = "";
             foreach (DataRow item in data.Rows)
             {
                 maphong = item["maphong"].ToString();
             }
             //string update = "Update Phong set trangthai='false' where maphong = '" + maphong + "'";
             int rez = DataExcute.Instance.ExecuteNonQuery(update);
             if(rez>0)
             {
                 MessageBox.Show("In hóa đơn thành công");
             }   */
        }
    }
}
