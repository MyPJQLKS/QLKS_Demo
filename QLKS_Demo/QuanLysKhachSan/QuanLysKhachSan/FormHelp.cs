﻿using System;
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
                case "Danh sách phòng":                     //done
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSPhong.txt");
                        picturebox_Display.Image = Image.FromFile(@"HelpResources\DSPhong.jpg");
                        break;
                    }
                case "Tạo thẻ phòng thuê":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"");
                        break;
                    }
                case "Sửa đổi thông tin phòng thuê":        //done
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSPhong.txt");
                        picturebox_Display.Image = Image.FromFile(@"HelpResources\DSPhong.jpg");
                        break;
                    }
                case "Thông tin loại phòng":                //done
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSLoaiPhong.txt");
                        picturebox_Display.Image = Image.FromFile(@"HelpResources\DSLoaiPhong.jpg");
                        break;
                    }
                case "Thông tin thẻ phòng thuê":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"");
                        break;
                    }
                case "Danh sách khách":                     //done
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSKhach.txt");
                        picturebox_Display.Image = Image.FromFile(@"HelpResources\DSKhach.jpg");
                        break;
                    }
                case "Danh sách dịch vụ":                   //done
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSDichVu.txt");
                        picturebox_Display.Image = Image.FromFile(@"HelpResources\DSDichVu.jpg");
                        break;
                    }
                case "Tạo/Thêm thẻ dịch vụ":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\");
                        break;
                    }
                case "Thêm dịch vụ mới":                    //done
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSDichVu.txt");
                        picturebox_Display.Image = Image.FromFile(@"HelpResources\DSDichVu.jpg");
                        break;
                    }
                case "Thông tin dịch vụ":                   //done
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"HelpResources\DSDichVu.txt");
                        picturebox_Display.Image = Image.FromFile(@"HelpResources\DSDichVu.jpg");
                        break;
                    }
                case "Thông tin nhân viên":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"");
                        break;
                    }
                case "Đổi mật khẩu tài khoản":
                    {
                        richtextbox_Display.Text = File.ReadAllText(@"");
                        break;
                    }

            }
        }
    }
}
