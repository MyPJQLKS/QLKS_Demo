using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLysKhachSan
{
    public partial class FormHelp : Form
    {
        static string qlphong = File.ReadAllText(@"tester\help test.txt");
        static string dsphong = File.ReadAllText(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\help test.txt");
        static string taothephong = File.ReadAllText(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\help test.txt");
        static string suattphong = File.ReadAllText(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\help test.txt");
        static string ttloaiphong = File.ReadAllText(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\help test.txt");
        static string ttthephong = File.ReadAllText(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\help test.txt");
        
        static string qldichvu = File.ReadAllText(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\help test.txt");
        static string dsdichvu = File.ReadAllText(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\help test.txt");
        static string taothedichvu = File.ReadAllText(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\help test.txt");
        static string themdichvu = File.ReadAllText(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\help test.txt");
        static string ttdichvu = File.ReadAllText(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\help test.txt");
        
        static string tkbaomat = File.ReadAllText(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\help test.txt");
        static string ttnhanvien = File.ReadAllText(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\help test.txt");
        static string doimk = File.ReadAllText(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\help test.txt");

        public FormHelp()
        {
            InitializeComponent();
        }

        private void FormHelp_Load(object sender, EventArgs e)
        {
            //  Structure
            //treeview_ItemList.Nodes.Add("ParentKey1", "Parent-1  Text");
            //treeview_ItemList.Nodes["ParentKey1"].Nodes.Add("Child-1 Text");
            //treeview_ItemList.Nodes["ParentKey1"].Nodes.Add("ChildKey2", "Child-2 Text");
            //treeview_ItemList.Nodes["ParentKey1"].Nodes["ChildKey2"].Nodes.Add("Child-3 Text");

            treeview_ItemList.Nodes.Add("Room Manag", "Quản lý phòng");
            treeview_ItemList.Nodes["Room Manag"].Nodes.Add("Danh sách phòng");
            treeview_ItemList.Nodes["Room Manag"].Nodes.Add("Tạo thẻ phòng thuê");
            treeview_ItemList.Nodes["Room Manag"].Nodes.Add("Sửa đổi thông tin phòng thuê");
            treeview_ItemList.Nodes["Room Manag"].Nodes.Add("Thông tin loại phòng");
            treeview_ItemList.Nodes["Room Manag"].Nodes.Add("Thông tin thẻ phòng thuê");

            treeview_ItemList.Nodes.Add("Services Manag", "Quản lý dịch vụ");
            treeview_ItemList.Nodes["Services Manag"].Nodes.Add("Danh sách dịch vụ");
            treeview_ItemList.Nodes["Services Manag"].Nodes.Add("Tạo/Thêm thẻ dịch vụ");
            treeview_ItemList.Nodes["Services Manag"].Nodes.Add("Thêm dịch vụ mới");
            treeview_ItemList.Nodes["Services Manag"].Nodes.Add("Thông tin dịch vụ");

            treeview_ItemList.Nodes.Add("Security", "Tài khoản và bảo mật");
            treeview_ItemList.Nodes["Security"].Nodes.Add("Thông tin nhân viên");
            treeview_ItemList.Nodes["Security"].Nodes.Add("Đổi mật khẩu tài khoản");

        }

        private void treeview_ItemList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.Text);
            //DirectoryInfo dir = new DirectoryInfo(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls");
            switch(e.Node.Text)
            {
                case "Quản lý phòng":
                    richtextbox_Display.Text = qlphong;
                    break;
                case "Quản lý dịch vụ":
                    MessageBox.Show("quan ly dich vu");
                    break;
                default: 
                    MessageBox.Show("exception");
                    break;

            }



            //Image image = Image.FromFile(@"D:\TTNhom\QLKS_Demo\Mô tả chức năng và hình ảnh vào đây pls\test img.jpg");
            //Clipboard.SetImage(image);
            //richtextbox_Display.Paste();

        }
    }
}
