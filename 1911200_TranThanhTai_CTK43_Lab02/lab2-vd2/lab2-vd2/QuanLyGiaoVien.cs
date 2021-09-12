using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_vd2
{
	public class QuanLyGiaoVien
	{
		public List<GiaoVien> DSGV;
		public QuanLyGiaoVien()
		{
			DSGV = new List<GiaoVien>();
		}

		public GiaoVien this[int index]
		{
			get { return DSGV[index]; }
			set { DSGV[index] = value; }
		}

		public bool Add(GiaoVien giaovien)
		{
			var add = DSGV.Exists(gv => gv.MaSo == giaovien.MaSo);
			if (add) return false;

			DSGV.Add(giaovien);

			return true;
		}

		public GiaoVien Find(string value, KieuTimKiem kieutimkiem)
		{
			GiaoVien giaovien = null;

			switch(kieutimkiem)
			{
				case KieuTimKiem.TheoMaSoGiaoVien:
					giaovien = DSGV.Find(gv => gv.MaSo.Trim() == value.Trim());
					break;
				case KieuTimKiem.TheoHoTen:
					giaovien = DSGV.Find(gv => gv.HoTen.Trim() == value.Trim());
					break;
				case KieuTimKiem.TheoSDT:
					giaovien = DSGV.Find(gv => gv.SoDT.Trim() == value.Trim());
					break;
				default:
					break;
			}
			return giaovien;
		}
	}
}
