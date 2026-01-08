using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro06
{
    internal class DongVat
    {
        private string ten;
        private int tuoi;
        //set : Giup gan gia tri
        //get : Giup lay gia tri
        public void SetTen(string t)
        {
            this.ten = ten;
        }
        public void SetTuoi(int t)
        {
            this.tuoi = t;
        }
        public string GetTen()
        {
            return ten; 
        }
        public int GetTuoi()
        {
            return tuoi;
        }
        public void ThongTin()
        {
            Console.WriteLine($"Ten:{this.ten}," + $"Tuoi: {this.tuoi}");
        }
    }
}
