
namespace lab2_vd2
{
	partial class TimKiemForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdSDT = new System.Windows.Forms.RadioButton();
			this.rdHoTen = new System.Windows.Forms.RadioButton();
			this.rdMaGV = new System.Windows.Forms.RadioButton();
			this.lblTim = new System.Windows.Forms.Label();
			this.txtTim = new System.Windows.Forms.TextBox();
			this.btnsearch = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdSDT);
			this.groupBox1.Controls.Add(this.rdHoTen);
			this.groupBox1.Controls.Add(this.rdMaGV);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(24, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(447, 100);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "MỤC TÌM KIẾM";
			// 
			// rdSDT
			// 
			this.rdSDT.AutoSize = true;
			this.rdSDT.Location = new System.Drawing.Point(295, 38);
			this.rdSDT.Name = "rdSDT";
			this.rdSDT.Size = new System.Drawing.Size(125, 20);
			this.rdSDT.TabIndex = 2;
			this.rdSDT.TabStop = true;
			this.rdSDT.Text = "Số Điện Thoại";
			this.rdSDT.UseVisualStyleBackColor = true;
			this.rdSDT.CheckedChanged += new System.EventHandler(this.rdSDT_CheckedChanged);
			// 
			// rdHoTen
			// 
			this.rdHoTen.AutoSize = true;
			this.rdHoTen.Location = new System.Drawing.Point(179, 38);
			this.rdHoTen.Name = "rdHoTen";
			this.rdHoTen.Size = new System.Drawing.Size(77, 20);
			this.rdHoTen.TabIndex = 1;
			this.rdHoTen.TabStop = true;
			this.rdHoTen.Text = "Họ Tên";
			this.rdHoTen.UseVisualStyleBackColor = true;
			this.rdHoTen.CheckedChanged += new System.EventHandler(this.rdHoTen_CheckedChanged);
			// 
			// rdMaGV
			// 
			this.rdMaGV.AutoSize = true;
			this.rdMaGV.Location = new System.Drawing.Point(20, 38);
			this.rdMaGV.Name = "rdMaGV";
			this.rdMaGV.Size = new System.Drawing.Size(120, 20);
			this.rdMaGV.TabIndex = 0;
			this.rdMaGV.TabStop = true;
			this.rdMaGV.Text = "Mã Giáo Viên";
			this.rdMaGV.UseVisualStyleBackColor = true;
			this.rdMaGV.CheckedChanged += new System.EventHandler(this.rdMaGV_CheckedChanged);
			// 
			// lblTim
			// 
			this.lblTim.AutoSize = true;
			this.lblTim.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTim.Location = new System.Drawing.Point(21, 162);
			this.lblTim.Name = "lblTim";
			this.lblTim.Size = new System.Drawing.Size(99, 16);
			this.lblTim.TabIndex = 1;
			this.lblTim.Text = "Mã Giáo Viên";
			// 
			// txtTim
			// 
			this.txtTim.Location = new System.Drawing.Point(129, 159);
			this.txtTim.Name = "txtTim";
			this.txtTim.Size = new System.Drawing.Size(232, 22);
			this.txtTim.TabIndex = 2;
			// 
			// btnsearch
			// 
			this.btnsearch.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsearch.Location = new System.Drawing.Point(393, 155);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(75, 30);
			this.btnsearch.TabIndex = 3;
			this.btnsearch.Text = "Tìm";
			this.btnsearch.UseVisualStyleBackColor = true;
			this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
			// 
			// TimKiemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 212);
			this.Controls.Add(this.btnsearch);
			this.Controls.Add(this.txtTim);
			this.Controls.Add(this.lblTim);
			this.Controls.Add(this.groupBox1);
			this.Name = "TimKiemForm";
			this.Text = "Tìm thông tin giáo viên";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdSDT;
		private System.Windows.Forms.RadioButton rdHoTen;
		private System.Windows.Forms.RadioButton rdMaGV;
		private System.Windows.Forms.Label lblTim;
		private System.Windows.Forms.TextBox txtTim;
		private System.Windows.Forms.Button btnsearch;
	}
}