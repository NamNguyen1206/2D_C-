using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro13
{
    public class XuLyNhomMau
    {
        // Method for blood type compatibility check
        public static bool CoTheChoMau(NhomMauInfo nguoiCho, NhomMauInfo nguoiNhan)
        {
            // Checking ABO compatibility
            if (nguoiCho.ABO == LoaiNhomMau.O ||
                nguoiCho.ABO == nguoiNhan.ABO ||
                nguoiNhan.ABO == LoaiNhomMau.AB)
            {
                // Checking Rh compatibility
                if (nguoiCho.Rh == Rh.Am || nguoiNhan.Rh == Rh.Duong)
                    return true;  // Can donate
            }
            return false;  // Cannot donate
        }

        // The method KiemTraDiTruyen remains as before
        public static bool KiemTraDiTruyen(NhomMauInfo cha, NhomMauInfo me, NhomMauInfo con)
        {
            HashSet<LoaiNhomMau> ketQua = new HashSet<LoaiNhomMau>();

            if (cha.ABO == LoaiNhomMau.O && me.ABO == LoaiNhomMau.O)
                ketQua.Add(LoaiNhomMau.O);
            else if (cha.ABO == LoaiNhomMau.A && me.ABO == LoaiNhomMau.A)
            {
                ketQua.Add(LoaiNhomMau.A);
                ketQua.Add(LoaiNhomMau.O);
            }
            else if (cha.ABO == LoaiNhomMau.B && me.ABO == LoaiNhomMau.B)
            {
                ketQua.Add(LoaiNhomMau.B);
                ketQua.Add(LoaiNhomMau.O);
            }
            else if ((cha.ABO == LoaiNhomMau.A && me.ABO == LoaiNhomMau.B) ||
                     (cha.ABO == LoaiNhomMau.B && me.ABO == LoaiNhomMau.A))
            {
                ketQua.UnionWith(new[] {
                    LoaiNhomMau.O, LoaiNhomMau.A, LoaiNhomMau.B, LoaiNhomMau.AB
                });
            }
            else if (cha.ABO == LoaiNhomMau.AB || me.ABO == LoaiNhomMau.AB)
            {
                ketQua.UnionWith(new[] {
                    LoaiNhomMau.A, LoaiNhomMau.B, LoaiNhomMau.AB
                });
            }

            return ketQua.Contains(con.ABO);
        }
    }
}