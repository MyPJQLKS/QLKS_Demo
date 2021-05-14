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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            load();
            loadCBB();
        }
        #region Load
        void load()
        {
            dataGridView1.DataSource = DataExcute.Instance.ExecuteQuery("Select nv.manv, tennv, taikhoan, ngaysinh, luong, quequan from NhanVien nv left join UserTable us on nv.manv=us.manv");
            panel1.Visible = false;
            buttonSua.Enabled = true;
            buttonThem.Enabled = true;
            buttonXoa.Enabled = true;
            textBoxTenNV.Text = "";
            textBoxQueQuan.Text = "";
            textBoxLuong.Text = "";
        }
        void loadCBB()
        {
            comboBoxTK.Items.Clear();
            DataTable data = DataExcute.Instance.ExecuteQuery("Select taikhoan from Usertable");
            comboBoxTK.Items.Add("Chưa có");
            foreach (DataRow item in data.Rows)
            {
                comboBoxTK.Items.Add(item["taikhoan"].ToString());
            }
            comboBoxTK.SelectedIndex = 0;
        }
        #endregion

        private void buttonTK_Click(object sender, EventArgs e)
        {
            string que = "Select nv.manv, tennv, taikhoan, ngaysinh, luong, quequan from NhanVien nv left join UserTable us on nv.manv=us.manv where tennv like '%" + textBoxTenTK.Text + "%'";
            dataGridView1.DataSource = DataExcute.Instance.ExecuteQuery(que);

        }

        private void textBoxTenTK_TextChanged(object sender, EventArgs e)
        {
            string que = "Select nv.manv,tennv, taikhoan, ngaysinh, luong, quequan from NhanVien nv left join UserTable us on nv.manv=us.manv where tennv like '%" + textBoxTenTK.Text + "%'";
            dataGridView1.DataSource = DataExcute.Instance.ExecuteQuery(que);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if(textBoxDel.Text=="")
            {
                MessageBox.Show("Chọn trường muốn xóa " + textBoxDel.Text);
            }   else
            {
                //Xóa
                int rez = 0;
                //MessageBox.Show(textBoxDel.Text);
                string update = "Update UserTable set manv=NULL where manv='" + textBoxDel.Text + "' ";
                DataExcute.Instance.ExecuteNonQuery(update);
                string update2 = "Update ThePhongThue set manv = NULL where manv='" +textBoxDel.Text+ "' ";
                DataExcute.Instance.ExecuteNonQuery(update2);
                rez = DataExcute.Instance.ExecuteNonQuery("Delete from nhanvien where manv='"+textBoxDel.Text+"'");
                if(rez>0)
                {
                    MessageBox.Show("Xóa thành công");
                    load();
                }
                else
                {
                    MessageBox.Show("Fails");
                }
            }    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(panel1.Visible && buttonSua.Enabled)
            {
                textBoxTenNV.DataBindings.Clear();
                textBoxTenNV.DataBindings.Add("text", dataGridView1.DataSource, "tennv");
                textBoxQueQuan.DataBindings.Clear();
                textBoxQueQuan.DataBindings.Add("text", dataGridView1.DataSource, "quequan");
                textBoxLuong.DataBindings.Clear();
                textBoxLuong.DataBindings.Add("text", dataGridView1.DataSource, "luong");
                comboBoxTK.DataBindings.Clear();
                dateTimePicker1.DataBindings.Clear();
                dateTimePicker1.DataBindings.Add("text",dataGridView1.DataSource, "ngaysinh");
                comboBoxTK.DataBindings.Add("text", dataGridView1.DataSource, "taikhoan");
            }    
            textBoxDel.Text = "";
            if (e.RowIndex >= 0)
            {
                textBoxDel.Text = "";
                textBoxDel.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            buttonSua.Enabled = false;

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            load();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            string manv = "";
            DataTable da = DataExcute.Instance.ExecuteQuery("Select dbo.at_ma_nv() as manv");
            string ngaysinh = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            foreach (DataRow item in da.Rows)
            {
                manv = item["manv"].ToString();
            }
            if(buttonThem.Enabled)
            {
                //thêm
                if (textBoxTenNV.Text != "" && textBoxLuong.Text != "" && textBoxQueQuan.Text != "")
                {
                    int rez = 0;
                    string que = "Insert into nhanvien(manv, tennv, ngaysinh, quequan, luong) values('"+manv+"', N'"+textBoxTenNV.Text+"', '"+ngaysinh+"', '"+textBoxQueQuan.Text+"', "+textBoxLuong.Text+")";
                    rez = DataExcute.Instance.ExecuteNonQuery(que);
                    if(rez>0)
                    {
                        MessageBox.Show("Thêm thành công");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Fails");
                    }
                }
                else
                    MessageBox.Show("Hãy nhập thông tin cần thiết");
            }    
            else
            {
                //Sửa
                if(textBoxTenNV.Text != "" && textBoxLuong.Text != "" && textBoxQueQuan.Text != "")
                {
                    int rez = 0;
                    string que = "Update Nhanvien set tennv=N'"+textBoxTenNV.Text+"', luong="+textBoxLuong.Text+", quequan='"+textBoxQueQuan.Text+"', ngaysinh='"+dateTimePicker1.Value.ToShortDateString()+"' where manv='"+textBoxDel.Text+"'";
                    rez = DataExcute.Instance.ExecuteNonQuery(que);
                    if(rez > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Fails");
                    }
                }    else
                {
                    MessageBox.Show("Fails");
                }    
            }    
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy chọn trường cần sửa");
            buttonThem.Enabled = false;
            panel1.Visible = true;

        }
    }
}
