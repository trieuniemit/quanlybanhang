namespace QuanLyBanHang.Forms
{
    partial class BanHangForm_LichSuBanHang
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
            this.dgvBanHangHistory = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimMa = new System.Windows.Forms.Button();
            this.tbMaDonHang = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.panelFill = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHangHistory)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBanHangHistory
            // 
            this.dgvBanHangHistory.AllowUserToAddRows = false;
            this.dgvBanHangHistory.AllowUserToDeleteRows = false;
            this.dgvBanHangHistory.AllowUserToResizeColumns = false;
            this.dgvBanHangHistory.AllowUserToResizeRows = false;
            this.dgvBanHangHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanHangHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvBanHangHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanHangHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBanHangHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvBanHangHistory.Name = "dgvBanHangHistory";
            this.dgvBanHangHistory.ReadOnly = true;
            this.dgvBanHangHistory.Size = new System.Drawing.Size(1001, 271);
            this.dgvBanHangHistory.TabIndex = 0;
            this.dgvBanHangHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanHangHistory_CellClick);
            this.dgvBanHangHistory.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanHangHistory_CellMouseEnter);
            this.dgvBanHangHistory.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanHangHistory_CellMouseLeave);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.btnTimMa);
            this.panelTop.Controls.Add(this.tbMaDonHang);
            this.panelTop.Controls.Add(this.btnShowAll);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.cbbUser);
            this.panelTop.Controls.Add(this.btnFilter);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.dtpToDate);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.dtpFromDate);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(5, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1001, 114);
            this.panelTop.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tìm theo mã";
            // 
            // btnTimMa
            // 
            this.btnTimMa.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTimMa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMa.ForeColor = System.Drawing.Color.White;
            this.btnTimMa.Location = new System.Drawing.Point(308, 71);
            this.btnTimMa.Name = "btnTimMa";
            this.btnTimMa.Size = new System.Drawing.Size(88, 26);
            this.btnTimMa.TabIndex = 9;
            this.btnTimMa.Text = "Tìm";
            this.btnTimMa.UseVisualStyleBackColor = false;
            this.btnTimMa.Click += new System.EventHandler(this.btnTimMa_Click);
            // 
            // tbMaDonHang
            // 
            this.tbMaDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaDonHang.Location = new System.Drawing.Point(121, 74);
            this.tbMaDonHang.Name = "tbMaDonHang";
            this.tbMaDonHang.Size = new System.Drawing.Size(181, 21);
            this.tbMaDonHang.TabIndex = 8;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(645, 72);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(73, 26);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "Tất Cả";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "bởi nhân viên";
            // 
            // cbbUser
            // 
            this.cbbUser.BackColor = System.Drawing.SystemColors.Window;
            this.cbbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Location = new System.Drawing.Point(744, 25);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(121, 24);
            this.cbbUser.TabIndex = 5;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(880, 24);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(73, 26);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "đến";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(361, 27);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(217, 23);
            this.dtpToDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Location = new System.Drawing.Point(82, 27);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(230, 23);
            this.dtpFromDate.TabIndex = 0;
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.dgvBanHangHistory);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(5, 119);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(1001, 271);
            this.panelFill.TabIndex = 2;
            // 
            // BanHangForm_LichSuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 395);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BanHangForm_LichSuBanHang";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Đơn hàng đã bán";
            this.Load += new System.EventHandler(this.BanHangForm_LichSuBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHangHistory)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBanHangHistory;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbUser;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox tbMaDonHang;
        private System.Windows.Forms.Button btnTimMa;
        private System.Windows.Forms.Label label4;
    }
}