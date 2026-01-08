using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro11
{
    internal class ThongTinDinhDuong
    {
        public float Carb { get; set; }
        public float Fat { get; set; }
        public float FatBaoHoa { get; set; }
        public float Protein { get; set; }
        public float Calo { get; set; }

        public ThongTinDinhDuong(float carb, float fat, float fatBaoHoa, float protein, float calo)
        {
            Carb = carb;
            Fat = fat;
            FatBaoHoa = fatBaoHoa;
            Protein = protein;
            Calo = calo;
        }
    }
}
