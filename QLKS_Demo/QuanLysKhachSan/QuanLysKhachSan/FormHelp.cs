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
            treeview_ItemList.Nodes["Room Manag"].Nodes.Add("Danh sách khách");

            treeview_ItemList.Nodes.Add("Services Manag", "Quản lý dịch vụ");
            treeview_ItemList.Nodes["Services Manag"].Nodes.Add("Danh sách dịch vụ");
            treeview_ItemList.Nodes["Services Manag"].Nodes.Add("Tạo/Thêm thẻ dịch vụ");
            treeview_ItemList.Nodes["Services Manag"].Nodes.Add("Thêm dịch vụ mới");
            treeview_ItemList.Nodes["Services Manag"].Nodes.Add("Thông tin dịch vụ");
            treeview_ItemList.Nodes["Services Manag"].Nodes.Add("In hóa đơn");

            treeview_ItemList.Nodes.Add("Security", "Tài khoản và bảo mật");
            treeview_ItemList.Nodes["Security"].Nodes.Add("Thông tin nhân viên");
            treeview_ItemList.Nodes["Security"].Nodes.Add("Đổi mật khẩu tài khoản");
        }

        private void treeview_ItemList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch(e.Node.Text)
            {
                case "Danh sách phòng":                     //done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSPhong.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\DSPhong.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Tạo thẻ phòng thuê":                  //done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DatPhong.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\DatPhong.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Sửa đổi thông tin phòng thuê":        //done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSPhong.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\DSPhong.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Thông tin loại phòng":                //done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSLoaiPhong.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\DSLoaiPhong.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Thông tin thẻ phòng thuê":            //done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DatPhong.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\DatPhong.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Danh sách khách":                     //done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSKhach.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\DSKhach.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Danh sách dịch vụ":                   //done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSDichVu.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\DSDichVu.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Tạo/Thêm thẻ dịch vụ":                //done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DatPhong.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\DatPhong.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Thêm dịch vụ mới":                    //done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSDichVu.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\DSDichVu.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Thông tin dịch vụ":                   //done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSDichVu.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\DSDichVu.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Thông tin nhân viên":                 //done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\Not_Exist.txt");
                        //Clipboard.SetImage(Image.FromFile(@"HelpResources\Not_Exist.jpg"));
                        //richtextbox_Display.AppendText("\n");
                        //richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "Đổi mật khẩu tài khoản":              //done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\Not_Exist.txt");
                        //Clipboard.SetImage(Image.FromFile(@"HelpResources\Not_Exist.jpg"));
                        //richtextbox_Display.AppendText("\n");
                        //richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
                case "In hóa đơn":                          //done
                    {
                        richtextbox_Display.ReadOnly = false;
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\ThanhToan.txt");
                        Clipboard.SetImage(Image.FromFile(@"HelpResources\ThanhToan.jpg"));
                        richtextbox_Display.AppendText("\n");
                        richtextbox_Display.Paste();
                        richtextbox_Display.ReadOnly = true;
                        break;
                    }
            }
        }
    }
}
