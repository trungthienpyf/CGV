namespace QLCGV.User
{
    partial class Ve
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTroVe = new System.Windows.Forms.Button();
            this.pnVe = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vé đã mua";
            // 
            // lbTroVe
            // 
            this.lbTroVe.BackColor = System.Drawing.Color.Red;
            this.lbTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTroVe.ForeColor = System.Drawing.Color.White;
            this.lbTroVe.Location = new System.Drawing.Point(948, 26);
            this.lbTroVe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbTroVe.Name = "lbTroVe";
            this.lbTroVe.Size = new System.Drawing.Size(106, 39);
            this.lbTroVe.TabIndex = 1;
            this.lbTroVe.Text = "Trở về";
            this.lbTroVe.UseVisualStyleBackColor = false;
            this.lbTroVe.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnVe
            // 
            this.pnVe.ColumnCount = 1;
            this.pnVe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnVe.Location = new System.Drawing.Point(95, 98);
            this.pnVe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnVe.Name = "pnVe";
            this.pnVe.RowCount = 8;
            this.pnVe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnVe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnVe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnVe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnVe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnVe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnVe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnVe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.pnVe.Size = new System.Drawing.Size(867, 426);
            this.pnVe.TabIndex = 2;
            // 
            // Ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnVe);
            this.Controls.Add(this.lbTroVe);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ve";
            this.Text = "Ve";
            this.Load += new System.EventHandler(this.Ve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lbTroVe;
        private System.Windows.Forms.TableLayoutPanel pnVe;
    }
}