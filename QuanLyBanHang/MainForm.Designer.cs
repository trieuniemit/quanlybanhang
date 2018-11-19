using System.Windows.Forms;
namespace QuanLyBanHang
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbBanHang = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbSanPham = new System.Windows.Forms.Label();
            this.ptbSanPham = new System.Windows.Forms.PictureBox();
            this.ptbBanHang = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabMain.Location = new System.Drawing.Point(6, 88);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Drawing.Point(0, 0);
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1080, 568);
            this.tabMain.TabIndex = 0;
            this.tabMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabMain_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbBanHang);
            this.panel1.Controls.Add(this.ptbBanHang);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 68);
            this.panel1.TabIndex = 1;
            // 
            // lbBanHang
            // 
            this.lbBanHang.AutoSize = true;
            this.lbBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbBanHang.Location = new System.Drawing.Point(5, 46);
            this.lbBanHang.Name = "lbBanHang";
            this.lbBanHang.Size = new System.Drawing.Size(81, 18);
            this.lbBanHang.TabIndex = 1;
            this.lbBanHang.Tag = "";
            this.lbBanHang.Text = "Bán Hàng";
            this.lbBanHang.Click += new System.EventHandler(this.ptbBanHang_Click_lbBanHang_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(6, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 86);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbSanPham);
            this.panel3.Controls.Add(this.ptbSanPham);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Location = new System.Drawing.Point(155, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(91, 68);
            this.panel3.TabIndex = 2;
            // 
            // lbSanPham
            // 
            this.lbSanPham.AutoSize = true;
            this.lbSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSanPham.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbSanPham.Location = new System.Drawing.Point(5, 46);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(85, 18);
            this.lbSanPham.TabIndex = 1;
            this.lbSanPham.Tag = "";
            this.lbSanPham.Text = "Sản Phẩm";
            // 
            // ptbSanPham
            // 
            this.ptbSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbSanPham.Image = global::QuanLyBanHang.Properties.Resources.product_cart_64;
            this.ptbSanPham.Location = new System.Drawing.Point(20, -1);
            this.ptbSanPham.Name = "ptbSanPham";
            this.ptbSanPham.Size = new System.Drawing.Size(56, 55);
            this.ptbSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSanPham.TabIndex = 0;
            this.ptbSanPham.TabStop = false;
            this.ptbSanPham.Tag = "";
            // 
            // ptbBanHang
            // 
            this.ptbBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbBanHang.Image = ((System.Drawing.Image)(resources.GetObject("ptbBanHang.Image")));
            this.ptbBanHang.Location = new System.Drawing.Point(20, -1);
            this.ptbBanHang.Name = "ptbBanHang";
            this.ptbBanHang.Size = new System.Drawing.Size(56, 55);
            this.ptbBanHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBanHang.TabIndex = 0;
            this.ptbBanHang.TabStop = false;
            this.ptbBanHang.Tag = "";
            this.ptbBanHang.Click += new System.EventHandler(this.ptbBanHang_Click_lbBanHang_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1091, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabMain);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBanHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabMain;
        private Panel panel1;
        private PictureBox ptbBanHang;
        private Label lbBanHang;
        private Panel panel2;
        private Panel panel3;
        private Label lbSanPham;
        private PictureBox ptbSanPham;


    }
}

