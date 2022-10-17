namespace QuanLyPhongTro.ChildForm
{
    partial class frmXuLyPhong
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
            this.grbContent = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbHoatdong = new System.Windows.Forms.CheckBox();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoaiphong = new System.Windows.Forms.ComboBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBotton = new System.Windows.Forms.Panel();
            this.grbContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbContent
            // 
            this.grbContent.Controls.Add(this.btnHuy);
            this.grbContent.Controls.Add(this.btnXacnhan);
            this.grbContent.Controls.Add(this.label3);
            this.grbContent.Controls.Add(this.label2);
            this.grbContent.Controls.Add(this.ckbHoatdong);
            this.grbContent.Controls.Add(this.txtTenphong);
            this.grbContent.Controls.Add(this.label1);
            this.grbContent.Controls.Add(this.cbbLoaiphong);
            this.grbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbContent.Location = new System.Drawing.Point(10, 0);
            this.grbContent.Name = "grbContent";
            this.grbContent.Size = new System.Drawing.Size(893, 430);
            this.grbContent.TabIndex = 5;
            this.grbContent.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(454, 244);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(137, 31);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Location = new System.Drawing.Point(277, 244);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(137, 31);
            this.btnXacnhan.TabIndex = 6;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(166, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(166, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên phòng";
            // 
            // ckbHoatdong
            // 
            this.ckbHoatdong.AutoSize = true;
            this.ckbHoatdong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ckbHoatdong.Checked = true;
            this.ckbHoatdong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbHoatdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckbHoatdong.ForeColor = System.Drawing.Color.White;
            this.ckbHoatdong.Location = new System.Drawing.Point(277, 193);
            this.ckbHoatdong.Name = "ckbHoatdong";
            this.ckbHoatdong.Size = new System.Drawing.Size(101, 20);
            this.ckbHoatdong.TabIndex = 3;
            this.ckbHoatdong.Text = "Hoạt động";
            this.ckbHoatdong.UseVisualStyleBackColor = false;
            // 
            // txtTenphong
            // 
            this.txtTenphong.Location = new System.Drawing.Point(277, 148);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(493, 22);
            this.txtTenphong.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(166, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại phòng";
            // 
            // cbbLoaiphong
            // 
            this.cbbLoaiphong.FormattingEnabled = true;
            this.cbbLoaiphong.Location = new System.Drawing.Point(274, 96);
            this.cbbLoaiphong.Name = "cbbLoaiphong";
            this.cbbLoaiphong.Size = new System.Drawing.Size(497, 24);
            this.cbbLoaiphong.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(903, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(10, 430);
            this.pnlRight.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(10, 430);
            this.pnlLeft.TabIndex = 3;
            // 
            // pnlBotton
            // 
            this.pnlBotton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotton.Location = new System.Drawing.Point(0, 430);
            this.pnlBotton.Name = "pnlBotton";
            this.pnlBotton.Size = new System.Drawing.Size(913, 10);
            this.pnlBotton.TabIndex = 4;
            // 
            // frmXuLyPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 440);
            this.Controls.Add(this.grbContent);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBotton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmXuLyPhong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xử Lý Phòng";
            this.Load += new System.EventHandler(this.frmXuLyPhong_Load);
            this.grbContent.ResumeLayout(false);
            this.grbContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbContent;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBotton;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbHoatdong;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLoaiphong;
    }
}