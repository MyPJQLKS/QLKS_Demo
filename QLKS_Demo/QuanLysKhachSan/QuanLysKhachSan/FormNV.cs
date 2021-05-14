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
    public partial class FormNV : Form
    {
        private string tk;
        private string maNV;

        public string Tk { get => tk; set => tk = value; }
        public FormNV()
        {
            InitializeComponent();
            load();
            kiemTraTT();
        }
        public FormNV(string tk)
        {
            InitializeComponent();   
            this.tk = tk;
            load();
            kiemTraTT();
        }

        #region Load
        bool kiemTraTT()
        {
            DataTable data = new DataTable();
            data = DataExcute.Instance.ExecuteQuery("Select manv from UserTable where taikhoan='" + label1.Text + "'");
            if(data.Rows.Count>0)
            {
                DataRow dataRow = data.Rows[0];
                maNV = dataRow["manv"].ToString();
            }    
            if (maNV == "") return false;
            else
            return true;
        }
        bool kiemTraTrangThaiPhong(string maphong)
        {
            DataTable data = new DataTable();
            data = DataExcute.Instance.ExecuteQuery("Select trangthai from phong where maphong='" + maphong + "'");
            string trangthai="";
            foreach (DataRow item in data.Rows)
            {
                trangthai = item["trangthai"].ToString();
            }
            if (trangthai.Equals("False")) return false;
            else return true;
        }
        public void load()
        {
            label7.Text = "";
            label9.Text = "";
            List<Room> listR = new List<Room>();
            DataTable data = new DataTable();
            data = DataExcute.Instance.ExecuteQuery("Select * from phong");
            foreach (DataRow item in data.Rows)
            {
                Room r = new Room(item);
                listR.Add(r);
            }
            foreach(Room item in listR)
            {
                string detail = item.Tenphong ;
                DataTable dat = DataExcute.Instance.ExecuteQuery("Select dongia, mota from loaiphong lp, phong p where lp.maloaiphong=p.maloaiphong and p.maphong='" + item.Maphong + "'");
                foreach (DataRow it in dat.Rows)
                {
                    detail += "\r\n" + it["dongia"].ToString();
                }
                Button bt = new Button() {Height=80, Width=80,Text=detail };
                bt.Click += btn_Click;
                bt.Tag = item;
                flowLayoutPanel1.Controls.Add(bt);
                switch (item.Trangthai)
                {
                    case true: 
                        {
                            bt.BackColor = Color.Red;
                            break;
                        }
                    default:
                        {
                            bt.BackColor = Color.Aqua;
                            break;
                        }
                }
            }
            loadComboBox();
            loadUser();
        }
        void showDetail(string maphong)
        {
            listView1.Items.Clear();
            string mathe = "";
            DataTable data = DataExcute.Instance.ExecuteQuery("Select mathe from thephongthue where maphong='" + maphong + "'");
            foreach (DataRow item in data.Rows)
            {
                mathe = item["mathe"].ToString();
            }
            if(mathe!="")
            {
                data = DataExcute.Instance.ExecuteQuery("Select d.tendv, t.madv, mathe, soluong, dongia from TheDichVu t, DichVu d where t.madv=d.madv and t.mathe='" + mathe + "'");
                foreach (DataRow item in data.Rows)
                {
                    string[] arr = new string[3];
                    arr[0] = item["tendv"].ToString();
                    arr[1] = item["soluong"].ToString();
                    arr[2] = item["dongia"].ToString();
                    ListViewItem lt = new ListViewItem(arr);
                    listView1.Items.Add(lt);
                }
            }    
        }



        void loadUser()
        {
            label1.Text = tk;
            if(kiemTraTT())
            {
                //tài khoản đã có mã nhân viên tương ứng
                label5.Text = "";
            }
            else
            {
                //vào form thông tin để thêm mã nhân viên
                label5.Text =  "Edit để thiết lập mã nhân viên và sử dụng";
                flowLayoutPanel1.Enabled = false;
            }
        }
        void loadComboBox()
        {
            DataTable data = new DataTable();
           /* data = DataExcute.Instance.ExecuteQuery("Select tenphong from phong");
            foreach (DataRow item in data.Rows)
            {
                string cb = item[0].ToString();
                comboBoxTenPhong.Items.Add(cb);
            }*/
            data.Clear();
            data = DataExcute.Instance.ExecuteQuery("Select tendv from dichvu");
            foreach  (DataRow item in data.Rows)
            {
                comboBoxDV.Items.Add(item[0].ToString());
            }
            comboBoxDV.SelectedIndex = 0;
        }
        #endregion

        #region Event
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Edit");
            FormThongTinNV fm = new FormThongTinNV(tk);
            fm.ShowDialog();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btn_Click(object sender, EventArgs e)
        {
            //chon 1 phong
            string mphong = ((sender as Button).Tag as Room).Maphong;
            DataTable dataTable = DataExcute.Instance.ExecuteQuery("Select trangthai from phong where maphong='" + mphong + "'");
            string trangThai = "";
            foreach (DataRow item in dataTable.Rows)
            {
                trangThai = item["trangthai"].ToString();
            }
            if(trangThai=="True")
            {
                showDetail(mphong);
                label7.Text = mphong;
                DataTable data = DataExcute.Instance.ExecuteQuery("Select mathe from thephongthue where maphong='" + mphong + "'");
                //int dem = 0;
                foreach (DataRow item in data.Rows)
                {
                    label9.Text = item["mathe"].ToString();
                    //dem++;
                }
                //if (dem == 0) label9.Text = "_____";
            }
            else
            {
                //tạo thẻ mới
            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(kiemTraTrangThaiPhong(label7.Text))
            {
                //đang thuê
                if (comboBoxDV.Text != "" && numericUpDown1.Value != 0)
                {
                    if (listView1.Items.Count > 0)
                    {
                        ListViewItem it = null;
                        int dem = 0;
                        foreach (ListViewItem item in listView1.Items)
                        {
                            if (item.Text.Equals(comboBoxDV.Text))
                            {
                                it = item;
                                dem++;
                            }    
                        }
                        if(dem>0)
                        {
                            //sửa số lượng
                            foreach (ListViewItem item in listView1.Items)
                            {
                                if(item == it)
                                {
                                    int total = Convert.ToInt32(item.SubItems[1].Text) + Convert.ToInt32(numericUpDown1.Value);
                                    item.SubItems[1].Text = total.ToString();
                                    numericUpDown1.Value = 0;
                                    //cap nhat sql
                                    string madv = "";
                                    DataTable dat = DataExcute.Instance.ExecuteQuery("Select madv from dichvu where tendv=N'" + comboBoxDV.Text + "'");
                                    foreach (DataRow items in dat.Rows)
                                    {
                                        madv = items["madv"].ToString();
                                    }
                                    string que = "Update thedichvu set soluong=" + total + " where madv='" + madv + "' and mathe='"+label9.Text+"'";
                                    int rez = DataExcute.Instance.ExecuteNonQuery(que);
                                    if (rez > 0)
                                        MessageBox.Show("Thêm thành công");
                                    else
                                        MessageBox.Show("???");
                                }    
                            }
                        }    else
                        {
                            //thêm mới
                            string[] arr = new string[3];
                            arr[0] = comboBoxDV.Text;
                            arr[1] = numericUpDown1.Value.ToString();
                            DataTable dat = new DataTable();
                            dat = DataExcute.Instance.ExecuteQuery("Select dongia from dichvu where tendv=N'" + comboBoxDV.Text + "'");
                            if (dat.Rows.Count > 0)
                            {
                                DataRow dataRow = dat.Rows[0];
                                arr[2] = dataRow["dongia"].ToString();
                            }
                            ListViewItem item = new ListViewItem(arr);
                            listView1.Items.Add(item);
                            
                            //cập nhat sql
                            string madv="";
                            dat = DataExcute.Instance.ExecuteQuery("Select madv from dichvu where tendv=N'" + comboBoxDV.Text + "'");
                            foreach (DataRow items in dat.Rows)
                            {
                                madv = items["madv"].ToString();
                            }
                            string que = "Insert into thedichvu(madv, mathe, soluong) values ('"+madv+"', '" + label9.Text + "', " + numericUpDown1.Value + ")";
                            int rez = DataExcute.Instance.ExecuteNonQuery(que);
                            if (rez > 0)
                                MessageBox.Show("Thêm thành công");
                            else
                                MessageBox.Show("???");
                            numericUpDown1.Value = 0;
                        }    

                    }
                    else
                    {
                        string[] arr = new string[3];
                        arr[0] = comboBoxDV.Text;
                        arr[1] = numericUpDown1.Value.ToString();
                        DataTable data = new DataTable();
                        data = DataExcute.Instance.ExecuteQuery("Select dongia from dichvu where tendv=N'" + comboBoxDV.Text + "'");
                        if (data.Rows.Count > 0)
                        {
                            DataRow dataRow = data.Rows[0];
                            arr[2] = dataRow["dongia"].ToString();
                        }
                        ListViewItem itl = new ListViewItem(arr);
                        listView1.Items.Add(itl);
                        //cap nhat sql
                        string madv = "";
                        data = DataExcute.Instance.ExecuteQuery("Select madv from dichvu where tendv=N'" + comboBoxDV.Text + "'");
                        foreach (DataRow items in data.Rows)
                        {
                            madv = items["madv"].ToString();
                        }
                        string que = "Insert into thedichvu(madv, mathe, soluong) values ('" + madv + "', '" + label9.Text + "', " + numericUpDown1.Value + ")";
                        int rez = DataExcute.Instance.ExecuteNonQuery(que);
                        if (rez > 0)
                            MessageBox.Show("Thêm thành công");
                        else
                            MessageBox.Show("???");
                    }

                    //xoa nhat item =0
                    string madv2 = "";
                    DataTable data1 = DataExcute.Instance.ExecuteQuery("Select madv from dichvu where tendv=N'" + comboBoxDV.Text + "'");
                    foreach (DataRow item in data1.Rows)
                    {
                        madv2 = item["madv"].ToString();
                    }
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if(Convert.ToInt32(item.SubItems[1].Text) <= 0)
                        {
                            item.Remove();
                            listView1.Update();
                            DataExcute.Instance.ExecuteNonQuery("Delete from thedichvu where madv='"+madv2+"' and mathe='"+label9.Text+"'");
                        }    
                    }

                }
                else
                {
                    MessageBox.Show("Không để trống hoặc bằng 0");
                }
            } else
            {
                MessageBox.Show("Phòng chưa được thuê");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
