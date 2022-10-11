namespace QLCGV.Admin
{
    partial class KhachHang
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTieuDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(32, 322);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 49;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(1058, 226);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellContentClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(85, 16);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 33);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(306, 16);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 34);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(580, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 33);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Location = new System.Drawing.Point(32, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AcceptsReturn = true;
            this.txtTimKiem.Location = new System.Drawing.Point(875, 27);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(148, 22);
            this.txtTimKiem.TabIndex = 6;
            // 
            // btnTieuDe
            // 
            this.btnTieuDe.AutoSize = true;
            this.btnTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTieuDe.ForeColor = System.Drawing.Color.Red;
            this.btnTieuDe.Location = new System.Drawing.Point(373, 20);
            this.btnTieuDe.Name = "btnTieuDe";
            this.btnTieuDe.Size = new System.Drawing.Size(416, 26);
            this.btnTieuDe.TabIndex = 6;
            this.btnTieuDe.Text = "QUẢN LÝ THÔNG TIN KHÁCH HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(155, 103);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(196, 22);
            this.txtID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên KH: ";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(155, 146);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(196, 22);
            this.txtTenKH.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "SĐT: ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(155, 182);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(196, 22);
            this.txtSDT.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mật khẩu: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Địa chỉ: ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(618, 110);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(268, 22);
            this.txtDiaChi.TabIndex = 16;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(618, 65);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(268, 22);
            this.txtMatKhau.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(618, 19);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtMatKhau);
            this.groupBox2.Location = new System.Drawing.Point(32, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1058, 171);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 560);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTieuDe);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label btnTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}