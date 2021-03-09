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
            this.treeview_ItemList = new System.Windows.Forms.TreeView();
            this.richtextbox_Display = new System.Windows.Forms.RichTextBox();
            this.picturebox_Display = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Display)).BeginInit();
            this.SuspendLayout();
            // 
            // treeview_ItemList
            // 
            this.treeview_ItemList.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeview_ItemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeview_ItemList.Location = new System.Drawing.Point(0, 0);
            this.treeview_ItemList.Name = "treeview_ItemList";
            this.treeview_ItemList.Size = new System.Drawing.Size(259, 573);
            this.treeview_ItemList.TabIndex = 0;
            this.treeview_ItemList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeview_ItemList_AfterSelect);
            // 
            // richtextbox_Display
            // 
            this.richtextbox_Display.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richtextbox_Display.Dock = System.Windows.Forms.DockStyle.Top;
            this.richtextbox_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtextbox_Display.Location = new System.Drawing.Point(259, 0);
            this.richtextbox_Display.Name = "richtextbox_Display";
            this.richtextbox_Display.ReadOnly = true;
            this.richtextbox_Display.Size = new System.Drawing.Size(665, 272);
            this.richtextbox_Display.TabIndex = 1;
            this.richtextbox_Display.Text = "";
            // 
            // picturebox_Display
            // 
            this.picturebox_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturebox_Display.Location = new System.Drawing.Point(259, 272);
            this.picturebox_Display.Name = "picturebox_Display";
            this.picturebox_Display.Size = new System.Drawing.Size(665, 301);
            this.picturebox_Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_Display.TabIndex = 2;
            this.picturebox_Display.TabStop = false;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 573);
            this.Controls.Add(this.picturebox_Display);
            this.Controls.Add(this.richtextbox_Display);
            this.Controls.Add(this.treeview_ItemList);
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.FormHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeview_ItemList;
        private System.Windows.Forms.RichTextBox richtextbox_Display;
        private System.Windows.Forms.PictureBox picturebox_Display;
    }
}