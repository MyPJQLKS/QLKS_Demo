using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLysKhachSan
{
    public partial class FormRoom : Form
    {
        public int a;
        //string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLKS_Demo;Integrated Security=True";
        string connectionString = SqlStringConnect.stringConnect;
        public FormRoom()
        {
            InitializeComponent();
        }
        DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> listPara = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0] == '@')
                            listPara.Add(item);
                    }
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.AddWithValue(listPara[i], parameter[i]);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);


                connection.Close();
            }
            return data;
        } 

        int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int acceptedRows = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> listPara = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0] == '@')
                            listPara.Add(item);
                    }
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.AddWithValue(listPara[i], parameter[i]);
                    }
                }
                //thực thi câu query chả về số dòng câu truy vấn thực hiện được
                acceptedRows = -1;
                try
                {
                    acceptedRows = command.ExecuteNonQuery();
                }
                catch { }
                connection.Close();
            }

            return acceptedRows;
        }
        private void btnShowK_Click(object sender, EventArgs e)
        {
            string query = "SELECT maloaiphong as N'Mã Loại Phòng', dongia as N'Đơn Giá', mota as N'Mô Tả' FROM LoaiPhong";
            dtgvKind.DataSource = ExecuteQuery(query);
        }

        private void btnEditK_Click(object sender, EventArgs e)
        {
            string query = "update LoaiPhong set mota = @mota , dongia = @dongia where maloaiphong = @maloaiphong";

            KindRoom kindroom = new KindRoom();

            if (txbIDKind.Text != "" )
            {
                kindroom.Maloaiphong = txbIDKind.Text;
                kindroom.Dongia = 0;
                try
                {
                    kindroom.Dongia = Convert.ToDecimal(txbPrice.Text);
                }
                catch { }
                kindroom.Mota = txbDescription.Text;
            }
            else 
            {
                if (dtgvKind.DataSource == null)
                {
                    MessageBox.Show("Không Thể Sửa Khi Chưa Có Đủ Dữ Liệu!");
                }
                else
                {
                    DataGridViewRow row = dtgvKind.SelectedCells[0].OwningRow;
                    kindroom.Maloaiphong = row.Cells["Mã Loại Phòng"].Value.ToString();
                    kindroom.Dongia = (decimal)row.Cells["Đơn Giá"].Value;
                    kindroom.Mota = row.Cells["Mô Tả"].Value.ToString();
                }

            }
           
            object[] para = new object[] { kindroom.Mota, kindroom.Dongia, kindroom.Maloaiphong };

            if (ExecuteNonQuery(query, para) > 0)
            {
                MessageBox.Show("Sửa Thành Công!");
                txbIDKind.Text = "";
                txbPrice.Text = "";
                txbDescription.Text = "";
                btnShowK_Click(sender, e);
            }
            else
                MessageBox.Show("Sửa Không Thành Công!");
        }

        private void btnAddK_Click(object sender, EventArgs e)
        {
            string query = "Insert into LoaiPhong values( @maloaiphong , @dongia , @mota )";

            KindRoom kindroom = new KindRoom();
            if (txbIDKind.Text != "") 
            {
                kindroom.Maloaiphong = txbIDKind.Text;
                if (txbPrice.Text == "")
                {
                    kindroom.Dongia = 0;
                }
                else kindroom.Dongia = Convert.ToDecimal(txbPrice.Text);
                kindroom.Mota = txbDescription.Text;
            }
            else
            {
                if(dtgvKind.DataSource == null)
                {
                    MessageBox.Show("Thêm Dữ Liệu Vào Bảng Dữ Liệu Hoặc Thêm Dữ Liệu Vào Text");
                    return;
                }
                DataGridViewRow row = dtgvKind.SelectedCells[0].OwningRow;

                kindroom.Maloaiphong = row.Cells["Mã Loại Phòng"].Value.ToString();
                if (row.Cells["Đơn Giá"].Value.ToString() == "")
                {
                    kindroom.Dongia = 0;
                }
                else kindroom.Dongia = (decimal)row.Cells["Đơn Giá"].Value;
                kindroom.Mota = row.Cells["Mô Tả"].Value.ToString();
            }
            
            object[] para = new object[] { kindroom.Maloaiphong, kindroom.Dongia, kindroom.Mota };
            if (ExecuteNonQuery(query, para) > 0)
            {
                MessageBox.Show("Thêm Thành Công!");
                txbIDKind.Text = "";
                txbPrice.Text = "";
                txbDescription.Text = "";
                btnShowK_Click(sender, e);
            }
            else
                MessageBox.Show("Thêm Không Thành Công!");
            
        }

        private void btnDeleteK_Click(object sender, EventArgs e)
        {
            if (dtgvKind.DataSource == null)
            {
                MessageBox.Show("Chọn Trường Cần Xóa Trong Bảng Dữ Liệu!");
            }
            else
            {
                string ID = dtgvKind.SelectedCells[0].OwningRow.Cells["Mã Loại Phòng"].Value.ToString();
                object[] para = new object[] { ID };
                string query = "exec xoa1LoaiPhong @ID";
                if (ExecuteNonQuery(query, para) > 0)
                {

                    MessageBox.Show("Xóa Thành Công!");
                    btnShowK_Click(sender, e);
                }
                else
                    MessageBox.Show("Xóa Không Thành Công!");
            }
        }

        private void btnShowR_Click(object sender, EventArgs e)
        {
            string query = "SELECT maphong as N'Mã Phòng', tenphong as N'Tên Phòng', maloaiphong as N'Mã Loại Phòng', trangthai as N'Trạng Thái' FROM Phong";
            dtgvRoom.DataSource = ExecuteQuery(query);
        }

        private void btnEditR_Click(object sender, EventArgs e)
        {
            string query = "update Phong set tenphong = @tenphong , maloaiphong = @maloaiphong , trangthai = @trangthai where maphong = @maphong";

            Room room = new Room();

            if(txbIDRoom.Text != "" & txbNameRoom.Text != "")
            {
                room.Maphong = txbIDRoom.Text;
                room.Maloaiphong = cbIDKind.Text;
                room.Tenphong = txbNameRoom.Text;
                if (cbStatus.Text == "Trống") room.Trangthai = false;
                if (cbStatus.Text == "Đã Thuê") room.Trangthai = true;
            }
            else
            {
                if (dtgvRoom.DataSource == null)
                {
                    MessageBox.Show("Không Thể Sửa Khi Chưa Đủ Dữ Liệu");
                }
                else
                {
                    DataGridViewRow row = dtgvRoom.SelectedCells[0].OwningRow;
                    room.Maphong = row.Cells["Mã Phòng"].Value.ToString();
                    room.Tenphong = row.Cells["Tên Phòng"].Value.ToString();
                    room.Maloaiphong = row.Cells["Mã Loại Phòng"].Value.ToString();
                    room.Trangthai = (bool)row.Cells["Trạng Thái"].Value;
                }
            }
           
            object[] para = new object[] { room.Tenphong, room.Maloaiphong, room.Trangthai, room.Maphong };

            if (ExecuteNonQuery(query, para) > 0)
            {
                MessageBox.Show("Sửa Thành Công!");
                txbIDRoom.Text = "";
                txbNameRoom.Text = "";
                cbStatus.Text = "Trống";
                btnShowR_Click(sender, e);
            }
            else
                MessageBox.Show("Sửa Không Thành Công!");
            
        }

        private void btnAddR_Click(object sender, EventArgs e)
        {
            string query = "Insert into Phong values( @maphong , @tenphong , @maloaiphong , @trangthai )";

            Room room = new Room();
            if (txbIDRoom.Text != "")
            {
                room.Maphong = txbIDRoom.Text;
                if (cbStatus.Text == "Trống")
                {
                    room.Trangthai = false;
                }
                else room.Trangthai = true;
                room.Tenphong = txbNameRoom.Text;
                room.Maloaiphong = cbIDKind.Text;
            }
            else
            {
                if (dtgvRoom.DataSource == null)
                {
                    MessageBox.Show("Thêm Dữ Liệu Vào Bảng Dữ Liệu Hoặc Thêm Dữ Liệu Vào Text");
                    return;
                }
                DataGridViewRow row = dtgvRoom.SelectedCells[0].OwningRow;
                room.Maphong = row.Cells["Mã Phòng"].Value.ToString();
                room.Tenphong = row.Cells["Tên Phòng"].Value.ToString();
                room.Maloaiphong = row.Cells["Mã Loại Phòng"].Value.ToString();
                room.Trangthai = false;
                try
                {
                    room.Trangthai = (bool)row.Cells["Trạng Thái"].Value;
                }
                catch { }

            }
            
            object[] para = new object[] { room.Maphong, room.Tenphong, room.Maloaiphong, room.Trangthai };
            if (ExecuteNonQuery(query, para) > 0)
            {
                MessageBox.Show("Thêm Thành Công!");
                txbIDRoom.Text = "";
                txbNameRoom.Text = "";
                cbStatus.Text = "Trống";
                btnShowR_Click(sender, e);
            }
            else
                MessageBox.Show("Thêm Không Thành Công!");
            
        }

        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            if (dtgvRoom.DataSource == null)
            {
                MessageBox.Show("Chọn Trường Cần Xóa Trong Bảng Dữ Liệu!");
            }
            else
            {
                string ID = dtgvRoom.SelectedCells[0].OwningRow.Cells["Mã Phòng"].Value.ToString();
                object[] para = new object[] { ID };
                string query = "exec xoa1Phong @ID";
                if (ExecuteNonQuery(query, para) > 0)
                {
                    MessageBox.Show("Xóa Thành Công!");
                    btnShowR_Click(sender, e);
                }
                else
                    MessageBox.Show("Xóa Không Thành Công!");
            }
        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = a;
            string query = "SELECT * FROM LoaiPhong";
            cbIDKind.DataSource = ExecuteQuery(query);
            cbIDKind.DisplayMember = "maloaiphong";
            cbStatus.Text = "Trống";
        }
    }
}
