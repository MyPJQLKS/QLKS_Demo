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
    public partial class FormDatphong : Form
    {
        public FormDatphong()
        {
            InitializeComponent();
        }
        string ConnectionString =@"Data Source=localhost\SQLEXPRESS;Initial Catalog=QLKS_Demo;Integrated Security=True";
        private void button_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("Select * from Phong where trangthai = 'false'", sqlcon);
                DataTable table = new DataTable();
                sqlData.Fill(table);
                dataGridView_datphong.DataSource = table;
            }
    }

        private void dataGridView_datphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dataGridView_datphong.Rows[e.RowIndex];
                textBox_maphong.Text = row.Cells[0].Value.ToString();
                textBox_tenphong.Text = row.Cells[1].Value.ToString();
                textBox_mlphong.Text = row.Cells[2].Value.ToString();
                string trangthai = row.Cells[3].Value.ToString();
                if ( trangthai == "false")
                {
                    radioButton_dathue.Checked = true;
                    radioButton_chuathue.Checked = false;
                }
                else
                {
                    radioButton_dathue.Checked = false;
                    radioButton_chuathue.Checked = true;
                    
                }
            }
        }
    }
}
