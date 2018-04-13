namespace QLKhachSan.GUI
{
    partial class frmTimkiemhdtp
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
            this.lbNTTTK = new System.Windows.Forms.Label();
            this.txtNTTTK = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvTimKiemHDTP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHDTP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNTTTK
            // 
            this.lbNTTTK.AutoSize = true;
            this.lbNTTTK.Location = new System.Drawing.Point(94, 73);
            this.lbNTTTK.Name = "lbNTTTK";
            this.lbNTTTK.Size = new System.Drawing.Size(151, 13);
            this.lbNTTTK.TabIndex = 0;
            this.lbNTTTK.Text = "NHẬP THÔNG TIN TÌM KIẾM";
            // 
            // txtNTTTK
            // 
            this.txtNTTTK.Location = new System.Drawing.Point(363, 66);
            this.txtNTTTK.Name = "txtNTTTK";
            this.txtNTTTK.Size = new System.Drawing.Size(156, 20);
            this.txtNTTTK.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(269, 127);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvTimKiemHDTP
            // 
            this.dgvTimKiemHDTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemHDTP.Location = new System.Drawing.Point(52, 176);
            this.dgvTimKiemHDTP.Name = "dgvTimKiemHDTP";
            this.dgvTimKiemHDTP.Size = new System.Drawing.Size(541, 150);
            this.dgvTimKiemHDTP.TabIndex = 3;
            // 
            // frmTimkiemhdtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 354);
            this.Controls.Add(this.dgvTimKiemHDTP);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtNTTTK);
            this.Controls.Add(this.lbNTTTK);
            this.Name = "frmTimkiemhdtp";
            this.Text = "frmTimkiemhdtp";
            this.Load += new System.EventHandler(this.frmTimkiemhdtp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemHDTP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNTTTK;
        private System.Windows.Forms.TextBox txtNTTTK;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvTimKiemHDTP;
    }
}