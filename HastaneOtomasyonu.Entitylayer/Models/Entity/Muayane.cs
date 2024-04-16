using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.EntityLayer.Models.Entity
{
    public class Muayane
    {
        [Key]
        public int MuayaneId { get; set; }

        public DateTime MuayaneZamanı { get; set; }

        public int HastaID { get; set; }

        public virtual Hasta hasta { get; set; }
        public Klinik klinik { get; set; }

        public string? Teshis {  get; set; }

        public int KlinikID { get; set; }
        public int PoliklinikID { get; set; }
    }
}
