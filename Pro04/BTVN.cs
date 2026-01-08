using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Pro04
{
    internal class BTVN
    {
    //    static int DemTu(string ten)
    //    {
    //        int dem = 0;
    //        foreach(char item in ten)
    //        {
    //            if(dem == ' ')
    //            {
    //                dem++;
    //            }
    //        }
    //        return dem+1;
    //    }
    //    static string TimTenDem(string ten)
    //    {
    //        int index1 = ten.IndexOf(" ");
    //        int index2 = ten.LastIndexOf(" ");
    //        return ten.Substring(index1 + 1, index2 - index1 - 1);
    //    }
    //    //meo, lengh = 3 ,i_max =2
    //    //a[2] = a[3]
    //    static void ChuanHoaKhoangTrang( ref string ten)
    //    {
    //        for (int i = 0; i < ten.Length-1; i++)
    //        {
    //            if (ten[i] == ten[i + 1])
    //            {
    //                ten.Remove(i,1);
    //                i--;
    //            }
    //        }
    //        if (ten[0]==' ') ten = ten.Remove(0,1);
    //        if (ten[ten.Length-1] == ' ') ten = ten.Remove(ten.Length-1,1);
    //    }
    //    //Vd "M_ _ _ E"
    //    //i=0
    //    //i=1 do s[1]= s[2] xoa tai i=1 => "M_ _ E"

    //    //Tiep tuc xet i=1
    //    //i=2 do s[2] != s[3] nen khong xoa 

    //    static void ChuanHoaTenRieng(  ref string ten)
    //    {
    //        string kq = "";
    //        ten=ten.ToLower();
    //        kq+=char.ToUpper(ten[0]);
    //        for (int i = 1; i < ten.Length; i++)
    //        {
    //            if (ten[i] == ' ')
    //            {
    //                kq += " ";
    //                kq += char.ToUpper(ten[i+1]);
    //                i++;
    //            }
    //            else
    //            {
    //                kq += ten[i];
    //            }
    //        }
    //        ten = kq;
    //    }
    //    //static void Main(string[] args)
    //    //{
    //    //    Console.OutputEncoding = Encoding.UTF8;
    //    //    string s = "le van meo";
    //    //    Console.WriteLine("So tu " + DemTu(s));
    //    //    Console.WriteLine("Ten dem = " + TimTenDem(s));
    //    //    //ChuanHoaKhoangTrang(ref s);
    //    //    ChuanHoaTenRieng(ref s);
    //    //    Console.WriteLine(s);
    //    //    Console.ReadKey();
    //    //}
    }
}
