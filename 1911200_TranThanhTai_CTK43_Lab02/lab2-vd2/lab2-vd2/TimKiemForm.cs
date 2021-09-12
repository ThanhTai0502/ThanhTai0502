using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_vd2
{
	public partial class TimKiemForm : Form
	{
		private QuanLyGiaoVien QuanLyGV;
		public TimKiemForm()
		{
			InitializeComponent();
		}

		public TimKiemForm(QuanLyGiaoVien QLGV) :this()
		{
			QuanLyGV = QLGV;
		}

		private void rdMaGV_CheckedChanged(object sender, EventArgs e)
		{
			if(rdMaGV.Checked)
			{
				lblTim.Text = rdMaGV.Text;
				txtTim.Text = "";
			}
		}

		private void rdHoTen_CheckedChanged(object sender, EventArgs e)
		{
			if(rdHoTen.Checked)
			{
				lblTim.Text = rdHoTen.Text;
				txtTim.Text = "";
			}
		}

		private void rdSDT_CheckedChanged(object sender, EventArgs e)
		{
			lblTim.Text =rdSDT.Text;
			txtTim.Text = "";
		}

		private void btnsearch_Click(object sender, EventArgs e)
		{
			var kieutimkiem = KieuTimKiem.TheoHoTen;
			if(rdMaGV.Checked)
			{
				kieutimkiem = KieuTimKiem.TheoMaSoGiaoVien;
			}
			else if(rdHoTen.Checked)
			{
				kieutimkiem = KieuTimKiem.TheoHoTen;
			}
			else if(rdSDT.Checked)
			{
				kieutimkiem = KieuTimKiem.TheoSDT;
			}
			var ketqua = QuanLyGV.Find(txtTim.Text, kieutimkiem);
			if(ketqua == null)
			{
				MessageBox.Show("Không xảy ra lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				var f = new TBGiaoVien();
				f.SetText(ketqua.ToString());
				f.ShowDialog();
			}
		}
	}
}
