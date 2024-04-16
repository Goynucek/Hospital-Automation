using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.EntityLayer.Models.Entity
{
    public class Klinik
    {
        [Key]
        public int KlinikID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string KlinikAdı { get; set; }

        public int PoliklinikID { get; set; }

        public Poliklinik Poliklinik { get; set; }
    }
}
