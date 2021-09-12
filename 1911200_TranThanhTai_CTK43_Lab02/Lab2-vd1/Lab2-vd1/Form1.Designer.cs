
namespace Lab2_vd1
{
	partial class Form1
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
			this.label2 = new System.Windows.Forms.Label();
			this.cbbMaHV = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFullName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
			this.chkInformaticsA = new System.Windows.Forms.CheckBox();
			this.chkInformaticsB = new System.Windows.Forms.CheckBox();
			this.chkEngLishA = new System.Windows.Forms.CheckBox();
			this.chkEngLishB = new System.Windows.Forms.CheckBox();
			this.lblTienTHA = new System.Windows.Forms.Label();
			this.lblTienTHB = new System.Windows.Forms.Label();
			this.lblTienTAA = new System.Windows.Forms.Label();
			this.lblTienTAB = new System.Windows.Forms.Label();
			this.lblTotalMoney = new System.Windows.Forms.Label();
			this.txtTotalMoney = new System.Windows.Forms.TextBox();
			this.btnPay = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkCyan;
			this.label1.Location = new System.Drawing.Point(36, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(407, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mã Học Viên:";
			// 
			// cbbMaHV
			// 
			this.cbbMaHV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbMaHV.FormattingEnabled = true;
			this.cbbMaHV.Items.AddRange(new object[] {
            "1911200\t",
            "1911213\t",
            "1912345\t",
            "1911234",
            "1911456",
            "1911666",
            "1911777"});
			this.cbbMaHV.Location = new System.Drawing.Point(127, 85);
			this.cbbMaHV.Name = "cbbMaHV";
			this.cbbMaHV.Size = new System.Drawing.Size(121, 24);
			this.cbbMaHV.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(254, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Giới Tính:";
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Location = new System.Drawing.Point(334, 84);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(58, 21);
			this.rdNam.TabIndex = 2;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Location = new System.Drawing.Point(398, 85);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(47, 21);
			this.rdNu.TabIndex = 3;
			this.rdNu.TabStop = true;
			this.rdNu.Text = "Nữ";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "Họ Tên:";
			// 
			// txtFullName
			// 
			this.txtFullName.Location = new System.Drawing.Point(127, 131);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.Size = new System.Drawing.Size(318, 22);
			this.txtFullName.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 178);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 17);
			this.label5.TabIndex = 3;
			this.label5.Text = "Ngày Đăng Ký:";
			// 
			// dtpNgayDangKy
			// 
			this.dtpNgayDangKy.Location = new System.Drawing.Point(127, 173);
			this.dtpNgayDangKy.Name = "dtpNgayDangKy";
			this.dtpNgayDangKy.Size = new System.Drawing.Size(200, 22);
			this.dtpNgayDangKy.TabIndex = 5;
			// 
			// chkInformaticsA
			// 
			this.chkInformaticsA.AutoSize = true;
			this.chkInformaticsA.Location = new System.Drawing.Point(93, 227);
			this.chkInformaticsA.Name = "chkInformaticsA";
			this.chkInformaticsA.Size = new System.Drawing.Size(90, 21);
			this.chkInformaticsA.TabIndex = 6;
			this.chkInformaticsA.Text = "Tin học A";
			this.chkInformaticsA.UseVisualStyleBackColor = true;
			// 
			// chkInformaticsB
			// 
			this.chkInformaticsB.AutoSize = true;
			this.chkInformaticsB.Location = new System.Drawing.Point(93, 254);
			this.chkInformaticsB.Name = "chkInformaticsB";
			this.chkInformaticsB.Size = new System.Drawing.Size(92, 21);
			this.chkInformaticsB.TabIndex = 7;
			this.chkInformaticsB.Text = "Tin Học B";
			this.chkInformaticsB.UseVisualStyleBackColor = true;
			// 
			// chkEngLishA
			// 
			this.chkEngLishA.AutoSize = true;
			this.chkEngLishA.Location = new System.Drawing.Point(93, 281);
			this.chkEngLishA.Name = "chkEngLishA";
			this.chkEngLishA.Size = new System.Drawing.Size(108, 21);
			this.chkEngLishA.TabIndex = 8;
			this.chkEngLishA.Text = "Tiếng Anh A";
			this.chkEngLishA.UseVisualStyleBackColor = true;
			// 
			// chkEngLishB
			// 
			this.chkEngLishB.AutoSize = true;
			this.chkEngLishB.Location = new System.Drawing.Point(93, 308);
			this.chkEngLishB.Name = "chkEngLishB";
			this.chkEngLishB.Size = new System.Drawing.Size(108, 21);
			this.chkEngLishB.TabIndex = 9;
			this.chkEngLishB.Text = "Tiếng Anh B";
			this.chkEngLishB.UseVisualStyleBackColor = true;
			// 
			// lblTienTHA
			// 
			this.lblTienTHA.AutoSize = true;
			this.lblTienTHA.Location = new System.Drawing.Point(281, 227);
			this.lblTienTHA.Name = "lblTienTHA";
			this.lblTienTHA.Size = new System.Drawing.Size(96, 17);
			this.lblTienTHA.TabIndex = 2;
			this.lblTienTHA.Text = "300.000 đồng";
			// 
			// lblTienTHB
			// 
			this.lblTienTHB.AutoSize = true;
			this.lblTienTHB.Location = new System.Drawing.Point(281, 255);
			this.lblTienTHB.Name = "lblTienTHB";
			this.lblTienTHB.Size = new System.Drawing.Size(96, 17);
			this.lblTienTHB.TabIndex = 2;
			this.lblTienTHB.Text = "500.000 đồng";
			// 
			// lblTienTAA
			// 
			this.lblTienTAA.AutoSize = true;
			this.lblTienTAA.Location = new System.Drawing.Point(281, 281);
			this.lblTienTAA.Name = "lblTienTAA";
			this.lblTienTAA.Size = new System.Drawing.Size(96, 17);
			this.lblTienTAA.TabIndex = 2;
			this.lblTienTAA.Text = "400.000 đồng";
			// 
			// lblTienTAB
			// 
			this.lblTienTAB.AutoSize = true;
			this.lblTienTAB.Location = new System.Drawing.Point(281, 312);
			this.lblTienTAB.Name = "lblTienTAB";
			this.lblTienTAB.Size = new System.Drawing.Size(96, 17);
			this.lblTienTAB.TabIndex = 2;
			this.lblTienTAB.Text = "600.000 đồng";
			// 
			// lblTotalMoney
			// 
			this.lblTotalMoney.AutoSize = true;
			this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalMoney.Location = new System.Drawing.Point(139, 357);
			this.lblTotalMoney.Name = "lblTotalMoney";
			this.lblTotalMoney.Size = new System.Drawing.Size(82, 17);
			this.lblTotalMoney.TabIndex = 2;
			this.lblTotalMoney.Text = "Tổng Tiền";
			// 
			// txtTotalMoney
			// 
			this.txtTotalMoney.Location = new System.Drawing.Point(243, 347);
			this.txtTotalMoney.Multiline = true;
			this.txtTotalMoney.Name = "txtTotalMoney";
			this.txtTotalMoney.Size = new System.Drawing.Size(134, 35);
			this.txtTotalMoney.TabIndex = 10;
			// 
			// btnPay
			// 
			this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPay.Location = new System.Drawing.Point(62, 417);
			this.btnPay.Name = "btnPay";
			this.btnPay.Size = new System.Drawing.Size(102, 45);
			this.btnPay.TabIndex = 11;
			this.btnPay.Text = "Tính Tiền";
			this.btnPay.UseVisualStyleBackColor = true;
			this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(201, 417);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(102, 45);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(340, 417);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(102, 45);
			this.btnExit.TabIndex = 13;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 474);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnPay);
			this.Controls.Add(this.txtTotalMoney);
			this.Controls.Add(this.lblTotalMoney);
			this.Controls.Add(this.lblTienTAB);
			this.Controls.Add(this.lblTienTAA);
			this.Controls.Add(this.lblTienTHB);
			this.Controls.Add(this.lblTienTHA);
			this.Controls.Add(this.chkEngLishB);
			this.Controls.Add(this.chkEngLishA);
			this.Controls.Add(this.chkInformaticsB);
			this.Controls.Add(this.chkInformaticsA);
			this.Controls.Add(this.dtpNgayDangKy);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtFullName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.rdNu);
			this.Controls.Add(this.rdNam);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbbMaHV);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbbMaHV;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rdNam;
		private System.Windows.Forms.RadioButton rdNu;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
		private System.Windows.Forms.CheckBox chkInformaticsA;
		private System.Windows.Forms.CheckBox chkInformaticsB;
		private System.Windows.Forms.CheckBox chkEngLishA;
		private System.Windows.Forms.CheckBox chkEngLishB;
		private System.Windows.Forms.Label lblTienTHA;
		private System.Windows.Forms.Label lblTienTHB;
		private System.Windows.Forms.Label lblTienTAA;
		private System.Windows.Forms.Label lblTienTAB;
		private System.Windows.Forms.Label lblTotalMoney;
		private System.Windows.Forms.TextBox txtTotalMoney;
		private System.Windows.Forms.Button btnPay;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnExit;
	}
}

