using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_vd1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.ReSet();
		}
		private void ReSet()
		{
			this.cbbMaHV.Text = "";
			this.txtFullName.Text = "";
			this.dtpNgayDangKy.Value = DateTime.Now;
			this.rdNam.Checked = true;
			this.chkEngLishA.Checked = false;
			this.chkEngLishB.Checked = false;
			this.chkInformaticsA.Checked = false;
			this.chkInformaticsB.Checked = false;
			this.txtTotalMoney.Text = "";
		}

		private void btnPay_Click(object sender, EventArgs e)
		{
			int s = 0;
			if (chkInformaticsA.Checked)
				s += int.Parse(lblTienTHA.Text.Split('.')[0]);
			if (chkInformaticsB.Checked)
				s += int.Parse(lblTienTHB.Text.Split('.')[0]);
			if (chkEngLishA.Checked)
				s += int.Parse(lblTienTAA.Text.Split('.')[0]);
			if (chkEngLishB.Checked)
				s += int.Parse(lblTienTAB.Text.Split('.')[0]);
			this.txtTotalMoney.Text = s + ".000 đồng";
		}
	}
}
