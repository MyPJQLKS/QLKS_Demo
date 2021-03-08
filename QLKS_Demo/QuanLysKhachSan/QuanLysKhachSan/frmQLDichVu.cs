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
    public partial class frmQLDichVu : Form
    {
        static string connstring = @"Data Source=DESKTOP-L67U4QK;Initial Catalog=QLKS_Demo;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connstring);
        public frmQLDichVu()
        {
            InitializeComponent();
        }
        private void XoaText()
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtDongia.Clear();
            txtMaDV.Focus();
        }
        private void frmQLDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DichVu", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                ds_DV.DataSource = dt;

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Equals(""))
            {
                MessageBox.Show("Không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtDongia.Equals(""))
            {
                MessageBox.Show("Không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO DichVu VALUES(@madv, @tendv, @dongia)", conn);
                cmd.Parameters.AddWithValue("@madv", txtMaDV.Text);
                cmd.Parameters.AddWithValue("@tendv", txtTenDV.Text);
                cmd.Parameters.AddWithValue("@dongia", txtDongia.Text);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                frmQLDichVu_Load(sender, e);
            }
            catch (Exception e1)
            {
                if (txtMaDV.Equals(""))
                {
                    MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ds_DV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = ds_DV.CurrentRow.Index;
            txtMaDV.Text = ds_DV.Rows[i].Cells[0].Value.ToString();
            txtTenDV.Text = ds_DV.Rows[i].Cells[1].Value.ToString();
            txtDongia.Text = ds_DV.Rows[i].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE DichVu SET tendv = @tendv, dongia = @dongia WHERE madv = @madv", conn);
                cmd.Parameters.AddWithValue("@madv", txtMaDV.Text);
                cmd.Parameters.AddWithValue("@tendv", txtTenDV.Text);
                cmd.Parameters.AddWithValue("@dongia", txtDongia.Text);
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                frmQLDichVu_Load(sender, e);
                XoaText();
            }
            catch (Exception e1)
            {
                if (txtMaDV.Equals(""))
                {
                    MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
