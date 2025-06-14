namespace grade
{
    partial class Form3
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGView_0993 = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbox_BienSo0993 = new System.Windows.Forms.ComboBox();
            this.btnOK_0993 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBaoDuong_0993 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoKM_0993 = new System.Windows.Forms.TextBox();
            this.txtGiaTien_0993 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DateTime_0993 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGView_0993)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(493, 679);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGView_0993
            // 
            this.dataGView_0993.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGView_0993.Location = new System.Drawing.Point(143, 369);
            this.dataGView_0993.Name = "dataGView_0993";
            this.dataGView_0993.Size = new System.Drawing.Size(795, 304);
            this.dataGView_0993.TabIndex = 12;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(28, 637);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(28, 543);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 10;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(28, 464);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(28, 369);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(75, 23);
            this.btnHienThi.TabIndex = 8;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thông tin bảo dưỡng xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(140, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Chọn biển số";
            // 
            // cmbox_BienSo0993
            // 
            this.cmbox_BienSo0993.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_BienSo0993.FormattingEnabled = true;
            this.cmbox_BienSo0993.Location = new System.Drawing.Point(305, 103);
            this.cmbox_BienSo0993.Name = "cmbox_BienSo0993";
            this.cmbox_BienSo0993.Size = new System.Drawing.Size(150, 21);
            this.cmbox_BienSo0993.TabIndex = 15;
            // 
            // btnOK_0993
            // 
            this.btnOK_0993.Location = new System.Drawing.Point(502, 101);
            this.btnOK_0993.Name = "btnOK_0993";
            this.btnOK_0993.Size = new System.Drawing.Size(75, 23);
            this.btnOK_0993.TabIndex = 16;
            this.btnOK_0993.Text = "OK";
            this.btnOK_0993.UseVisualStyleBackColor = true;
            this.btnOK_0993.Click += new System.EventHandler(this.btnOK_0993_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(140, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Gói bảo dưỡng";
            // 
            // cmbBaoDuong_0993
            // 
            this.cmbBaoDuong_0993.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaoDuong_0993.FormattingEnabled = true;
            this.cmbBaoDuong_0993.Location = new System.Drawing.Point(305, 150);
            this.cmbBaoDuong_0993.Name = "cmbBaoDuong_0993";
            this.cmbBaoDuong_0993.Size = new System.Drawing.Size(150, 21);
            this.cmbBaoDuong_0993.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(140, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(140, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giá tiền";
            // 
            // txtSoKM_0993
            // 
            this.txtSoKM_0993.Location = new System.Drawing.Point(305, 197);
            this.txtSoKM_0993.Name = "txtSoKM_0993";
            this.txtSoKM_0993.Size = new System.Drawing.Size(150, 20);
            this.txtSoKM_0993.TabIndex = 21;
            // 
            // txtGiaTien_0993
            // 
            this.txtGiaTien_0993.Location = new System.Drawing.Point(305, 239);
            this.txtGiaTien_0993.Name = "txtGiaTien_0993";
            this.txtGiaTien_0993.Size = new System.Drawing.Size(150, 20);
            this.txtGiaTien_0993.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(140, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày Bảo Dưỡng";
            // 
            // DateTime_0993
            // 
            this.DateTime_0993.Location = new System.Drawing.Point(305, 283);
            this.DateTime_0993.Name = "DateTime_0993";
            this.DateTime_0993.Size = new System.Drawing.Size(200, 20);
            this.DateTime_0993.TabIndex = 24;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1009, 711);
            this.Controls.Add(this.DateTime_0993);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaTien_0993);
            this.Controls.Add(this.txtSoKM_0993);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBaoDuong_0993);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOK_0993);
            this.Controls.Add(this.cmbox_BienSo0993);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGView_0993);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Thông tin bảo dưỡng";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGView_0993)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGView_0993;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbox_BienSo0993;
        private System.Windows.Forms.Button btnOK_0993;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBaoDuong_0993;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoKM_0993;
        private System.Windows.Forms.TextBox txtGiaTien_0993;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateTime_0993;
    }
}