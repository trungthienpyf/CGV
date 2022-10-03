namespace QLCGV.Admin
{
    partial class Phim
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPhim = new System.Windows.Forms.TextBox();
            this.textTg = new System.Windows.Forms.TextBox();
            this.comboTL = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();

            this._QLRPDataSet = new QLCGV._QLRPDataSet();
            this.lICHCHIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lICHCHIEUTableAdapter = new QLCGV._QLRPDataSetTableAdapters.LICHCHIEUTableAdapter();
            this.maLichChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioBatDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioKetThucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayChieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this._QLRPDataSet1 = new QLCGV._QLRPDataSet1();
            //this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.pHONGTableAdapter = new QLCGV._QLRPDataSet1TableAdapters.PHONGTableAdapter();
            //((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            //this.groupBox1.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this._QLRPDataSet)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.lICHCHIEUBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this._QLRPDataSet1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            //this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thông tin phim";
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
            this.dgv.Location = new System.Drawing.Point(347, 82);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.Size = new System.Drawing.Size(684, 364);
            this.dgv.TabIndex = 2;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên phim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(98, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thời gian";
            // 
            // textPhim
            // 
            this.textPhim.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhim.Location = new System.Drawing.Point(131, 118);
            this.textPhim.Margin = new System.Windows.Forms.Padding(4);
            this.textPhim.Name = "textPhim";
            this.textPhim.Size = new System.Drawing.Size(173, 34);
            this.textPhim.TabIndex = 5;
            // 
            // textTg
            // 
            this.textTg.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTg.Location = new System.Drawing.Point(131, 177);
            this.textTg.Margin = new System.Windows.Forms.Padding(4);
            this.textTg.Name = "textTg";
            this.textTg.Size = new System.Drawing.Size(173, 34);
            this.textTg.TabIndex = 6;
            // 
            // comboTL
            // 
            this.comboTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTL.FormattingEnabled = true;
            this.comboTL.Location = new System.Drawing.Point(131, 234);
            this.comboTL.Margin = new System.Windows.Forms.Padding(4);
            this.comboTL.Name = "comboTL";
            this.comboTL.Size = new System.Drawing.Size(173, 35);
            this.comboTL.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thể loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mô tả";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(131, 295);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(173, 102);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 486);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thêm/Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 486);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textMa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.textPhim);
            this.groupBox1.Controls.Add(this.textTg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboTL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(323, 422);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phim";
            // 
            // textMa
            // 
            this.textMa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.textMa.Location = new System.Drawing.Point(131, 65);
            this.textMa.Margin = new System.Windows.Forms.Padding(4);
            this.textMa.Name = "textMa";
            this.textMa.Size = new System.Drawing.Size(173, 34);

            this.textMa.Location = new System.Drawing.Point(98, 53);
            this.textMa.Name = "textMa";
            this.textMa.Size = new System.Drawing.Size(131, 29);

            this.textMa.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Phim";
            // 

            // _QLRPDataSet
            // 
            this._QLRPDataSet.DataSetName = "_QLRPDataSet";
            this._QLRPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lICHCHIEUBindingSource
            // 
            this.lICHCHIEUBindingSource.DataMember = "LICHCHIEU";
            this.lICHCHIEUBindingSource.DataSource = this._QLRPDataSet;
            // 
            // lICHCHIEUTableAdapter
            // 
            this.lICHCHIEUTableAdapter.ClearBeforeFill = true;
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
            // _QLRPDataSet1
            // 
          
           
            // 
            // pHONGBindingSource
            // 
            
            // 
            // pHONGTableAdapter
            // 
           
            // 


            // Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Phim";
            this.Text = "Phim";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._QLRPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lICHCHIEUBindingSource)).EndInit();
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPhim;
        private System.Windows.Forms.TextBox textTg;
        private System.Windows.Forms.ComboBox comboTL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textMa;
        private System.Windows.Forms.Label label2;
        private _QLRPDataSet _QLRPDataSet;
        private System.Windows.Forms.BindingSource lICHCHIEUBindingSource;
        private _QLRPDataSetTableAdapters.LICHCHIEUTableAdapter lICHCHIEUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLichChieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioBatDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioKetThucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayChieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongDataGridViewTextBoxColumn;
    }
}