    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static Pro13.XuLyNhomMau;

    namespace Pro13
    {
    public enum LoaiNhomMau
    {
        O,
        A,
        B,
        AB
    }

    public enum Rh
    {
        Duong,
        Am
    }

    public class NhomMau
    {
        public LoaiNhomMau LoaiNhomMau { get; set; }
        public Rh Rh { get; set; }

        public NhomMau(LoaiNhomMau loaiNhomMau, Rh rh)
        {
            LoaiNhomMau = loaiNhomMau;
            Rh = rh;
        }

        public override string ToString()
        {
            return $"{LoaiNhomMau} {Rh}";
        }
    }

    public class NhomMauInfo
    {
        public LoaiNhomMau ABO { get; set; }
        public Rh Rh { get; set; }

        public NhomMauInfo(LoaiNhomMau abo, Rh rh)
        {
            ABO = abo;
            Rh = rh;
        }
    }
}
