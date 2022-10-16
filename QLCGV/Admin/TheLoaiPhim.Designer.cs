namespace QLCGV.Admin
{
    partial class TheLoaiPhim
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
            this.btnTroVe = new System.Windows.Forms.Button();
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(515, 346);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(128, 42);
            this.btnTroVe.TabIndex = 0;
            this.btnTroVe.Text = "Trở về trang chính";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.14783F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTieuDe.Location = new System.Drawing.Point(271, 9);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(285, 25);
            this.lbTieuDe.TabIndex = 1;
            this.lbTieuDe.Text = "QUẢN LÝ THỂ LOẠI PHIM";
            // 
            // TheLoaiPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTieuDe);
            this.Controls.Add(this.btnTroVe);
            this.Name = "TheLoaiPhim";
            this.Text = "TheLoaiPhim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Label lbTieuDe;
    }
}