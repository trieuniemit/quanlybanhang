namespace QuanLyBanHang.Forms
{
    partial class BanHangForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTienTra = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTienGui = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListProduct = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaSanPham = new System.Windows.Forms.TextBox();
            this.ptbAdd = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTienTra);
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbTienGui);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbKhachHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn Bán Hàng";
            // 
            // tbTienTra
            // 
            this.tbTienTra.Enabled = false;
            this.tbTienTra.Location = new System.Drawing.Point(623, 111);
            this.tbTienTra.Name = "tbTienTra";
            this.tbTienTra.ReadOnly = true;
            this.tbTienTra.Size = new System.Drawing.Size(200, 26);
            this.tbTienTra.TabIndex = 7;
            this.tbTienTra.Text = "0";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(623, 73);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(200, 26);
            this.tbTotal.TabIndex = 6;
            this.tbTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số tiền trả lại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng tiền";
            // 
            // tbTienGui
            // 
            this.tbTienGui.Location = new System.Drawing.Point(623, 35);
            this.tbTienGui.Name = "tbTienGui";
            this.tbTienGui.Size = new System.Drawing.Size(200, 26);
            this.tbTienGui.TabIndex = 3;
            this.tbTienGui.Text = "0";
            this.tbTienGui.LostFocus += new System.EventHandler(this.tbTienGui_LostFocus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiền KH trả";
            // 
            // tbKhachHang
            // 
            this.tbKhachHang.Location = new System.Drawing.Point(159, 38);
            this.tbKhachHang.Name = "tbKhachHang";
            this.tbKhachHang.Size = new System.Drawing.Size(258, 26);
            this.tbKhachHang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // dgvListProduct
            // 
            this.dgvListProduct.AllowUserToAddRows = false;
            this.dgvListProduct.AllowUserToDeleteRows = false;
            this.dgvListProduct.AllowUserToOrderColumns = true;
            this.dgvListProduct.AllowUserToResizeColumns = false;
            this.dgvListProduct.AllowUserToResizeRows = false;
            this.dgvListProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListProduct.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListProduct.Location = new System.Drawing.Point(13, 199);
            this.dgvListProduct.Name = "dgvListProduct";
            this.dgvListProduct.ReadOnly = true;
            this.dgvListProduct.RowHeadersVisible = false;
            this.dgvListProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListProduct.Size = new System.Drawing.Size(856, 240);
            this.dgvListProduct.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sản phẩm đã chọn";
            // 
            // tbMaSanPham
            // 
            this.tbMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaSanPham.Location = new System.Drawing.Point(15, 456);
            this.tbMaSanPham.Name = "tbMaSanPham";
            this.tbMaSanPham.Size = new System.Drawing.Size(143, 23);
            this.tbMaSanPham.TabIndex = 9;
            this.tbMaSanPham.Text = "Nhập mã sản phẩm...";
            this.tbMaSanPham.GotFocus += new System.EventHandler(this.tbMaSanPham_GotFocus);
            this.tbMaSanPham.LostFocus += new System.EventHandler(this.tbMaSanPham_LostFocus);
            // 
            // ptbAdd
            // 
            this.ptbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAdd.Image = global::QuanLyBanHang.Properties.Resources.plus;
            this.ptbAdd.Location = new System.Drawing.Point(165, 455);
            this.ptbAdd.Name = "ptbAdd";
            this.ptbAdd.Size = new System.Drawing.Size(26, 24);
            this.ptbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAdd.TabIndex = 10;
            this.ptbAdd.TabStop = false;
            this.ptbAdd.Click += new System.EventHandler(this.ptbAdd_Click);
            // 
            // BanHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 495);
            this.Controls.Add(this.ptbAdd);
            this.Controls.Add(this.tbMaSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvListProduct);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BanHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.BanHangForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTienGui;
        private System.Windows.Forms.TextBox tbTienTra;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbMaSanPham;
        private System.Windows.Forms.PictureBox ptbAdd;
    }
}