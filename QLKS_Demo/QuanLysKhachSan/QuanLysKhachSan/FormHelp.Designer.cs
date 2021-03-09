namespace QuanLysKhachSan
{
    partial class FormHelp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1.1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node1.2.1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node1.2", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node2.1");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeview_ItemList = new System.Windows.Forms.TreeView();
            this.richtextbox_Display = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeview_ItemList
            // 
            this.treeview_ItemList.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeview_ItemList.Location = new System.Drawing.Point(0, 0);
            this.treeview_ItemList.Name = "treeview_ItemList";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1.1";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Node1.2.1";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Node1.2";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Node1";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node2.1";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Node2";
            this.treeview_ItemList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6});
            this.treeview_ItemList.Size = new System.Drawing.Size(236, 523);
            this.treeview_ItemList.TabIndex = 0;
            // 
            // richtextbox_Display
            // 
            this.richtextbox_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtextbox_Display.Location = new System.Drawing.Point(236, 0);
            this.richtextbox_Display.Name = "richtextbox_Display";
            this.richtextbox_Display.Size = new System.Drawing.Size(538, 523);
            this.richtextbox_Display.TabIndex = 1;
            this.richtextbox_Display.Text = "";
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 523);
            this.Controls.Add(this.richtextbox_Display);
            this.Controls.Add(this.treeview_ItemList);
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.FormHelp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeview_ItemList;
        private System.Windows.Forms.RichTextBox richtextbox_Display;
    }
}