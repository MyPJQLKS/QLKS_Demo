using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLysKhachSan
{
    public partial class FormDatphong : Form
    {
        public FormDatphong()
        {
            InitializeComponent();
        }
        //Data Source=localhost\SQLEXPRESS;Initial Catalog=QLKS_Demo;Integrated Security=True
        private void button_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(stringConnect);
            sqlcon.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("Select * from Phong where trangthai = 'false'");

        }
    }
}
