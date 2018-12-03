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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.lbLogout = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsMainMenu = new System.Windows.Forms.ToolStrip();
            this.parentBanHang = new System.Windows.Forms.ToolStripDropDownButton();
            this.itemBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLichSu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.parentSanPham = new System.Windows.Forms.ToolStripDropDownButton();
            this.itemSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLoaiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.parentThongKe = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.parentCaNhan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.parentNhanVien = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.parentCaiDat = new System.Windows.Forms.ToolStripButton();
            this.ptbLogout = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tsMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabMain.Location = new System.Drawing.Point(6, 87);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Drawing.Point(0, 0);
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1080, 575);
            this.tabMain.TabIndex = 0;
            this.tabMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabMain_MouseClick);
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbLogout.Location = new System.Drawing.Point(902, 39);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(74, 18);
            this.lbLogout.TabIndex = 16;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.Location = new System.Drawing.Point(978, 18);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(59, 13);
            this.lbPosition.TabIndex = 15;
            this.lbPosition.Text = "<Chức vụ>";
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(806, 15);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(173, 20);
            this.lbUserName.TabIndex = 14;
            this.lbUserName.Text = "<Họ và tên>";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.ptbLogout);
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Controls.Add(this.lbLogout);
            this.panel2.Controls.Add(this.lbPosition);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(6, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 73);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tsMainMenu);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 72);
            this.panel1.TabIndex = 8;
            // 
            // tsMainMenu
            // 
            this.tsMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.tsMainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parentBanHang,
            this.toolStripSeparator1,
            this.parentSanPham,
            this.toolStripSeparator2,
            this.parentThongKe,
            this.toolStripSeparator3,
            this.parentCaNhan,
            this.toolStripSeparator4,
            this.parentNhanVien,
            this.toolStripSeparator5,
            this.parentCaiDat});
            this.tsMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsMainMenu.Location = new System.Drawing.Point(1, 0);
            this.tsMainMenu.Name = "tsMainMenu";
            this.tsMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsMainMenu.Size = new System.Drawing.Size(631, 73);
            this.tsMainMenu.TabIndex = 8;
            this.tsMainMenu.Text = "toolStrip1";
            // 
            // parentBanHang
            // 
            this.parentBanHang.AutoSize = false;
            this.parentBanHang.AutoToolTip = false;
            this.parentBanHang.DoubleClickEnabled = true;
            this.parentBanHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemBanHang,
            this.itemLichSu});
            this.parentBanHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.parentBanHang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.parentBanHang.Image = global::QuanLyBanHang.Properties.Resources.shopping_cart_64;
            this.parentBanHang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.parentBanHang.Name = "parentBanHang";
            this.parentBanHang.Size = new System.Drawing.Size(100, 70);
            this.parentBanHang.Text = "Bán Hàng";
            this.parentBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.parentBanHang.DoubleClick += new System.EventHandler(this.parentBanHang_DoubleClick);
            // 
            // itemBanHang
            // 
            this.itemBanHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.itemBanHang.Name = "itemBanHang";
            this.itemBanHang.Size = new System.Drawing.Size(186, 24);
            this.itemBanHang.Text = "Bán Hàng";
            this.itemBanHang.Click += new System.EventHandler(this.itemBanHang_Click);
            // 
            // itemLichSu
            // 
            this.itemLichSu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.itemLichSu.Name = "itemLichSu";
            this.itemLichSu.Size = new System.Drawing.Size(186, 24);
            this.itemLichSu.Text = "Đơn hàng đã bán";
            this.itemLichSu.Click += new System.EventHandler(this.itemLichSu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // parentSanPham
            // 
            this.parentSanPham.AutoSize = false;
            this.parentSanPham.AutoToolTip = false;
            this.parentSanPham.DoubleClickEnabled = true;
            this.parentSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSanPham,
            this.itemLoaiSanPham});
            this.parentSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.parentSanPham.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.parentSanPham.Image = global::QuanLyBanHang.Properties.Resources.product_cart_64;
            this.parentSanPham.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.parentSanPham.Name = "parentSanPham";
            this.parentSanPham.Size = new System.Drawing.Size(100, 70);
            this.parentSanPham.Text = "Sản Phẩm";
            this.parentSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.parentSanPham.DoubleClick += new System.EventHandler(this.parentSanPham_DoubleClick);
            // 
            // itemSanPham
            // 
            this.itemSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.itemSanPham.Name = "itemSanPham";
            this.itemSanPham.Size = new System.Drawing.Size(168, 24);
            this.itemSanPham.Text = "Sản phẩm";
            this.itemSanPham.Click += new System.EventHandler(this.itemSanPham_Click);
            // 
            // itemLoaiSanPham
            // 
            this.itemLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.itemLoaiSanPham.Name = "itemLoaiSanPham";
            this.itemLoaiSanPham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemLoaiSanPham.Size = new System.Drawing.Size(168, 24);
            this.itemLoaiSanPham.Text = "Loại sản phẩm";
            this.itemLoaiSanPham.Click += new System.EventHandler(this.itemLoaiSanPham_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 70);
            // 
            // parentThongKe
            // 
            this.parentThongKe.AutoSize = false;
            this.parentThongKe.AutoToolTip = false;
            this.parentThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.parentThongKe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.parentThongKe.Image = global::QuanLyBanHang.Properties.Resources.list_64;
            this.parentThongKe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.parentThongKe.Name = "parentThongKe";
            this.parentThongKe.Size = new System.Drawing.Size(100, 70);
            this.parentThongKe.Text = "Thống Kê";
            this.parentThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.parentThongKe.Click += new System.EventHandler(this.parentThongKe_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 70);
            // 
            // parentCaNhan
            // 
            this.parentCaNhan.AutoSize = false;
            this.parentCaNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.parentCaNhan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.parentCaNhan.Image = global::QuanLyBanHang.Properties.Resources.infomation_64;
            this.parentCaNhan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.parentCaNhan.Name = "parentCaNhan";
            this.parentCaNhan.Size = new System.Drawing.Size(100, 70);
            this.parentCaNhan.Text = "Cá Nhân";
            this.parentCaNhan.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.parentCaNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.parentCaNhan.ToolTipText = "Thông tin cá nhân";
            this.parentCaNhan.Click += new System.EventHandler(this.parentCaNhan_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 70);
            // 
            // parentNhanVien
            // 
            this.parentNhanVien.AutoSize = false;
            this.parentNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.parentNhanVien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.parentNhanVien.Image = global::QuanLyBanHang.Properties.Resources.users_64;
            this.parentNhanVien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.parentNhanVien.Name = "parentNhanVien";
            this.parentNhanVien.Size = new System.Drawing.Size(100, 70);
            this.parentNhanVien.Text = "Nhân Viên";
            this.parentNhanVien.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.parentNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.parentNhanVien.ToolTipText = "Quản lý nhân viên";
            this.parentNhanVien.Click += new System.EventHandler(this.parentNhanVien_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.AutoSize = false;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 70);
            // 
            // parentCaiDat
            // 
            this.parentCaiDat.AutoSize = false;
            this.parentCaiDat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.parentCaiDat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.parentCaiDat.Image = global::QuanLyBanHang.Properties.Resources.settings_64;
            this.parentCaiDat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.parentCaiDat.Name = "parentCaiDat";
            this.parentCaiDat.Size = new System.Drawing.Size(100, 70);
            this.parentCaiDat.Text = "Cài Đặt";
            this.parentCaiDat.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.parentCaiDat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.parentCaiDat.ToolTipText = "Cấu hình phần mềm";
            this.parentCaiDat.Click += new System.EventHandler(this.parentCaiDat_Click);
            // 
            // ptbLogout
            // 
            this.ptbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbLogout.Image = global::QuanLyBanHang.Properties.Resources.shutdown_161;
            this.ptbLogout.Location = new System.Drawing.Point(879, 39);
            this.ptbLogout.Name = "ptbLogout";
            this.ptbLogout.Size = new System.Drawing.Size(20, 20);
            this.ptbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogout.TabIndex = 19;
            this.ptbLogout.TabStop = false;
            this.ptbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1091, 668);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabMain);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsMainMenu.ResumeLayout(false);
            this.tsMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabMain;
        private Label lbLogout;
        private Label lbPosition;
        private Label lbUserName;
        private PictureBox ptbLogout;
        private Panel panel2;
        private Panel panel1;
        private ToolStrip tsMainMenu;
        private ToolStripDropDownButton parentBanHang;
        private ToolStripMenuItem itemBanHang;
        private ToolStripMenuItem itemLichSu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton parentSanPham;
        private ToolStripMenuItem itemSanPham;
        private ToolStripMenuItem itemLoaiSanPham;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton parentCaNhan;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton parentNhanVien;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton parentCaiDat;
        private ToolStripButton parentThongKe;


    }
}

