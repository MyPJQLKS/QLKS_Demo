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
    public partial class FormSuDungDV : Form
    {
        public FormSuDungDV()
        {
            InitializeComponent();
            LoadCB();
        }
        #region Load
        void LoadCB()
        {
            comboBoxPhong.Items.Clear();
            comboBoxDV.Items.Clear();
            DataTable data = DataExcute.Instance.ExecuteQuery("Select tenphong from phong");
            foreach (DataRow item in data.Rows)
            {
                comboBoxPhong.Items.Add(item["tenphong"].ToString());
            }
            comboBoxPhong.SelectedIndex = 0;
            data = DataExcute.Instance.ExecuteQuery("Select tendv from dichvu");
            foreach (DataRow item in data.Rows)
            {
                comboBoxDV.Items.Add(item["tendv"].ToString());
            }
            comboBoxDV.SelectedIndex = 0;

        }
        void dichVu(string mathe)
        {
            listView1.Items.Clear();
            DataTable data = new DataTable();
            if (mathe != "")
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
        #endregion
        private void FormSuDungDV_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMaThe.Text = "";
            DataTable data = DataExcute.Instance.ExecuteQuery("Select mathe from thephongthue t, Phong p where t.maphong=p.maphong and p.tenphong='" + comboBoxPhong.Text + "' and p.trangthai=1");
            foreach (DataRow item in data.Rows)
            {
                labelMaThe.Text = "";
                labelMaThe.Text = item["mathe"].ToString();
            }
            dichVu(labelMaThe.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
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
                    if (dem > 0)
                    {
                        //sửa số lượng
                        foreach (ListViewItem item in listView1.Items)
                        {
                            if (item == it)
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
                                string que = "Update thedichvu set soluong=" + total + " where madv='" + madv + "' and mathe='" + labelMaThe.Text + "'";
                                int rez = DataExcute.Instance.ExecuteNonQuery(que);
                                if (rez > 0)
                                    MessageBox.Show("Thêm thành công");
                                else
                                    MessageBox.Show("???");
                            }
                        }
                    }
                    else
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
                        string madv = "";
                        dat = DataExcute.Instance.ExecuteQuery("Select madv from dichvu where tendv=N'" + comboBoxDV.Text + "'");
                        foreach (DataRow items in dat.Rows)
                        {
                            madv = items["madv"].ToString();
                        }
                        string que = "Insert into thedichvu(madv, mathe, soluong) values ('" + madv + "', '" + labelMaThe.Text + "', " + numericUpDown1.Value + ")";
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
                    string que = "Insert into thedichvu(madv, mathe, soluong) values ('" + madv + "', '" + labelMaThe.Text + "', " + numericUpDown1.Value + ")";
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
                    if (Convert.ToInt32(item.SubItems[1].Text) <= 0)
                    {
                        item.Remove();
                        listView1.Update();
                        DataExcute.Instance.ExecuteNonQuery("Delete from thedichvu where madv='" + madv2 + "' and mathe='" + labelMaThe.Text + "'");
                    }
                }

            }
            else
            {
                MessageBox.Show("Không để trống hoặc bằng 0");
            }
        }
    }
}
