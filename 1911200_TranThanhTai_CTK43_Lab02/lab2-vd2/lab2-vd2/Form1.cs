using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_vd2
{
	public partial class Form1 : Form
	{
		private object ob;

		QuanLyGiaoVien QuanLyGV = new QuanLyGiaoVien();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string lienhe = "https://dlu.edu.vn/";
			this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
			this.cbbMaSo.SelectedItem = this.cbbMaSo.Items[0];
		}

		private void btnChon_Click(object sender, EventArgs e)
		{
			int i = this.lbDanhSachMH.SelectedItems.Count - 1;
			while(i >= 0)
			{
				this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
				this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
				i--;
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int i = this.lbMonHocDay.SelectedItems.Count - 1;
			while (i >= 0)
			{
				this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
				this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
				i--;
			}
		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			Reset();
		}
		 
		public void Reset()
		{
			this.cbbMaSo.Text = "";
			this.txtHoten.Text = "";
			this.txtMail.Text = "";
			this.mtxtSoDT.Text = "";
			this.rdNam.Checked = true;

			for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
				chklbNgoaiNgu.SetItemChecked(i, false);

			foreach (object ob in this.lbMonHocDay.Items)
				this.lbDanhSachMH.Items.Add(ob);
			this.lbMonHocDay.Items.Clear();
		}

		private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string s = e.Link.LinkData.ToString();
			Process.Start(s);
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			TBGiaoVien tb = new TBGiaoVien();
			tb.SetText(GetGiaoVien().ToString());
			tb.ShowDialog();
		}

		public GiaoVien GetGiaoVien()
		{
			string gt = "Nam";
			if (rdNu.Checked)
				gt = "Nữ";
			GiaoVien gv = new GiaoVien();
			gv.MaSo = this.cbbMaSo.Text;
			gv.GioiTinh = gt;
			gv.HoTen = this.txtHoten.Text;
			gv.NgaySinh = this.dtpNgaySinh.Value;
			gv.Mail = this.txtMail.Text;
			gv.SoDT = this.mtxtSoDT.Text;

			List<string> ngoaingu = new List<string>();
			for (int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
			{
				if (chklbNgoaiNgu.GetItemChecked(i))
					ngoaingu.Add(chklbNgoaiNgu.Items[i].ToString());
			}

			DanhMucMonHoc mh = new DanhMucMonHoc();
			foreach (object ob in lbMonHocDay.Items)
			{
				mh.Them(new MonHoc(ob.ToString()));
			}

			gv.dsMonHoc = mh;

			return gv;
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			var TimKiemForm = new TimKiemForm();
			TimKiemForm.ShowDialog();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var giaovien = GetGiaoVien();

			var success = QuanLyGV.Add(giaovien);
			if (!success)
				MessageBox.Show("Giáo viên có mã số" + giaovien.MaSo + "đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				MessageBox.Show("Thêm giáo viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		
	}
}
