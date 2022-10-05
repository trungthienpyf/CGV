namespace QLCGV.Admin
{
    partial class LichChieu
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.maLichChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioKetThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lICHCHIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this._QLRPDataSet1 = new QLCGV._QLRPDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtlichchieu = new System.Windows.Forms.TextBox();
            this.txtlc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texttime1 = new System.Windows.Forms.TextBox();
            this.texttime2 = new System.Windows.Forms.TextBox();
            this.txtbatdau = new System.Windows.Forms.Label();
            this.comboTL = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICHCHIEUBindingSource)).BeginInit();
          
            ((System.ComponentModel.ISupportInitialize)(this._QLRPDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 450);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 450);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Thêm/Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLichChieuDataGridViewTextBoxColumn,
            this.gioBatDauDataGridViewTextBoxColumn,
            this.gioKetThucDataGridViewTextBoxColumn,
            this.ngayChieuDataGridViewTextBoxColumn,
            this.maPhongDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.lICHCHIEUBindingSource;
            this.dgv.Location = new System.Drawing.Point(397, 78);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(684, 364);
            this.dgv.TabIndex = 15;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // maLichChieuDataGridViewTextBoxColumn
            // 
            this.maLichChieuDataGridViewTextBoxColumn.DataPropertyName = "maLichChieu";
            this.maLichChieuDataGridViewTextBoxColumn.HeaderText = "maLichChieu";
            this.maLichChieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLichChieuDataGridViewTextBoxColumn.Name = "maLichChieuDataGridViewTextBoxColumn";
            this.maLichChieuDataGridViewTextBoxColumn.ReadOnly = true;
            this.maLichChieuDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioBatDauDataGridViewTextBoxColumn
            // 
            this.gioBatDauDataGridViewTextBoxColumn.DataPropertyName = "gioBatDau";
            this.gioBatDauDataGridViewTextBoxColumn.HeaderText = "gioBatDau";
            this.gioBatDauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioBatDauDataGridViewTextBoxColumn.Name = "gioBatDauDataGridViewTextBoxColumn";
            this.gioBatDauDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioBatDauDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioKetThucDataGridViewTextBoxColumn
            // 
            this.gioKetThucDataGridViewTextBoxColumn.DataPropertyName = "gioKetThuc";
            this.gioKetThucDataGridViewTextBoxColumn.HeaderText = "gioKetThuc";
            this.gioKetThucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioKetThucDataGridViewTextBoxColumn.Name = "gioKetThucDataGridViewTextBoxColumn";
            this.gioKetThucDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioKetThucDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayChieuDataGridViewTextBoxColumn
            // 
            this.ngayChieuDataGridViewTextBoxColumn.DataPropertyName = "ngayChieu";
            this.ngayChieuDataGridViewTextBoxColumn.HeaderText = "ngayChieu";
            this.ngayChieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayChieuDataGridViewTextBoxColumn.Name = "ngayChieuDataGridViewTextBoxColumn";
            this.ngayChieuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayChieuDataGridViewTextBoxColumn.Width = 125;
            // 
            // maPhongDataGridViewTextBoxColumn
            // 
            this.maPhongDataGridViewTextBoxColumn.DataPropertyName = "maPhong";
            this.maPhongDataGridViewTextBoxColumn.HeaderText = "maPhong";
            this.maPhongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhongDataGridViewTextBoxColumn.Name = "maPhongDataGridViewTextBoxColumn";
            this.maPhongDataGridViewTextBoxColumn.ReadOnly = true;
            this.maPhongDataGridViewTextBoxColumn.Width = 125;
            // 
            // lICHCHIEUBindingSource
            // 
            this.lICHCHIEUBindingSource.DataMember = "LICHCHIEU";
           
            // 
            // _QLRPDataSet2
            // 
          
            // 
            // _QLRPDataSet1
            // 
            this._QLRPDataSet1.DataSetName = "_QLRPDataSet1";
            this._QLRPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 50);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quản lý lịch chiếu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtlichchieu);
            this.groupBox1.Controls.Add(this.txtlc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.texttime1);
            this.groupBox1.Controls.Add(this.texttime2);
            this.groupBox1.Controls.Add(this.txtbatdau);
            this.groupBox1.Controls.Add(this.comboTL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(323, 384);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lịch chiếu ";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(191, 344);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 41);
            this.button4.TabIndex = 20;
            this.button4.Text = "Đồng ý chọn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ngày chiếu";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 43);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtlichchieu
            // 
            this.txtlichchieu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlichchieu.Location = new System.Drawing.Point(131, 65);
            this.txtlichchieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtlichchieu.Name = "txtlichchieu";
            this.txtlichchieu.Size = new System.Drawing.Size(173, 34);
            this.txtlichchieu.TabIndex = 12;
            // 
            // txtlc
            // 
            this.txtlc.AutoSize = true;
            this.txtlc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlc.Location = new System.Drawing.Point(-5, 65);
            this.txtlc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtlc.Name = "txtlc";
            this.txtlc.Size = new System.Drawing.Size(132, 27);
            this.txtlc.TabIndex = 11;
            this.txtlc.Text = "Mã lịch chiếu";
            this.txtlc.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(123, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giờ kết thúc";
            // 
            // texttime1
            // 
            this.texttime1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttime1.Location = new System.Drawing.Point(131, 118);
            this.texttime1.Margin = new System.Windows.Forms.Padding(4);
            this.texttime1.Name = "texttime1";
            this.texttime1.Size = new System.Drawing.Size(173, 34);
            this.texttime1.TabIndex = 5;
            // 
            // texttime2
            // 
            this.texttime2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttime2.Location = new System.Drawing.Point(131, 177);
            this.texttime2.Margin = new System.Windows.Forms.Padding(4);
            this.texttime2.Name = "texttime2";
            this.texttime2.Size = new System.Drawing.Size(173, 34);
            this.texttime2.TabIndex = 6;
            // 
            // txtbatdau
            // 
            this.txtbatdau.AutoSize = true;
            this.txtbatdau.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbatdau.Location = new System.Drawing.Point(-2, 121);
            this.txtbatdau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtbatdau.Name = "txtbatdau";
            this.txtbatdau.Size = new System.Drawing.Size(118, 27);
            this.txtbatdau.TabIndex = 3;
            this.txtbatdau.Text = "Giờ bắt đầu";
            // 
            // comboTL
            // 
            this.comboTL.DataSource = this.pHONGBindingSource;
            this.comboTL.DisplayMember = "maPhong";
            this.comboTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTL.FormattingEnabled = true;
            this.comboTL.Location = new System.Drawing.Point(131, 234);
            this.comboTL.Margin = new System.Windows.Forms.Padding(4);
            this.comboTL.Name = "comboTL";
            this.comboTL.Size = new System.Drawing.Size(173, 35);
            this.comboTL.TabIndex = 7;
            this.comboTL.ValueMember = "maPhong";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã phòng";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1006, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 19;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this._QLRPDataSet1;
            // 
            // pHONGTableAdapter
            // 
           
            // 
            // lICHCHIEUTableAdapter
            // 
         
            // 
            // LichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 528);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "LichChieu";
            this.Text = "LichChieu";
            this.Load += new System.EventHandler(this.LichChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICHCHIEUBindingSource)).EndInit();
           
            ((System.ComponentModel.ISupportInitialize)(this._QLRPDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtlichchieu;
        private System.Windows.Forms.Label txtlc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texttime1;
        private System.Windows.Forms.TextBox texttime2;
        private System.Windows.Forms.Label txtbatdau;
        private System.Windows.Forms.ComboBox comboTL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private _QLRPDataSet1 _QLRPDataSet1;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        
        
        private System.Windows.Forms.BindingSource lICHCHIEUBindingSource;
     
        private System.Windows.Forms.DataGridViewTextBoxColumn maLichChieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioBatDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioKetThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayChieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
    }
}