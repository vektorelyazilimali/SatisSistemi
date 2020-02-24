using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisSistemi.Models
{
    public class model_tblusers
    {
        public int id { get; set; }
        public int personel_id { get; set; }
        public string kullanici_adi { get; set; }
        public string sifre { get; set; }
        public int sil_id { get; set; }
    }
}
