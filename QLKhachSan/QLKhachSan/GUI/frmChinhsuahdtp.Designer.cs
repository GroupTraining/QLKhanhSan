namespace QLKhachSan.GUI
{
    partial class frmChinhsuahdtp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewHdtp = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHdtp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHdtp
            // 
            this.dataGridViewHdtp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHdtp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHdtp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewHdtp.Location = new System.Drawing.Point(305, 1);
            this.dataGridViewHdtp.Name = "dataGridViewHdtp";
            this.dataGridViewHdtp.Size = new System.Drawing.Size(618, 356);
            this.dataGridViewHdtp.TabIndex = 0;
            this.dataGridViewHdtp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHdtp_CellClick);
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(12, 56);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 27);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Mã Phòng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(12, 122);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(91, 27);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Ngày Đến";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(12, 155);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(91, 27);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Ngày Trả";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Location = new System.Drawing.Point(109, 162);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(12, 304);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(94, 28);
            this.buttonX1.TabIndex = 9;
            this.buttonX1.Text = "Submit";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(174, 304);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(94, 28);
            this.buttonX2.TabIndex = 10;
            this.buttonX2.Text = "Xóa";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 12;
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(12, 89);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(91, 27);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "Tên Khách Hàng";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 225);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 20);
            this.textBox3.TabIndex = 16;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(12, 221);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(91, 27);
            this.labelX5.TabIndex = 15;
            this.labelX5.Text = "Thành Tiền";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(109, 192);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(92, 20);
            this.textBox4.TabIndex = 14;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(12, 188);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(91, 27);
            this.labelX6.TabIndex = 13;
            this.labelX6.Text = "Thời Gian Thuê";
            // 
            // frmChinhsuahdtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 358);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dataGridViewHdtp);
            this.Name = "frmChinhsuahdtp";
            this.Text = "frmChinhsuahdtp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHdtp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewHdtp;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TextBox textBox1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.TextBox textBox2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.TextBox textBox3;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.TextBox textBox4;
        private DevComponents.DotNetBar.LabelX labelX6;
    }
}