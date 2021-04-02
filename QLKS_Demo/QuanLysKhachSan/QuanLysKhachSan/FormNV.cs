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
        public void load()
        {
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
                Button bt = new Button() {Height=80, Width=80,Text=item.Tenphong };
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
            data = DataExcute.Instance.ExecuteQuery("Select tenphong from phong");
            foreach (DataRow item in data.Rows)
            {
                string cb = item[0].ToString();
                comboBoxTenPhong.Items.Add(cb);
            }
            data.Clear();
            data = DataExcute.Instance.ExecuteQuery("Select tendv from dichvu");
            foreach  (DataRow item in data.Rows)
            {
                comboBoxDV.Items.Add(item[0].ToString());
            }
        }
        #endregion

        #region Event
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

       
    }
}
