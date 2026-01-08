using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro14
{
    public abstract class NhanVat
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }

        // Constructor để khởi tạo thuộc tính của nhân vật
        public NhanVat(string name, int W, int H)
        {
            Name = name;
            W = W;
            H = H;
        }

        // Phương thức kiểm tra va chạm với nhân vật khác
        public bool IsCollide(NhanVat other)
        {
            // Kiểm tra xem hộp bao quanh có giao nhau không
            bool isColliding = !(X + W <other.X || other.X + other.W <X || Y+H < other.Y || other.Y + other.H <Y);
            return isColliding;
        }
    }
}
