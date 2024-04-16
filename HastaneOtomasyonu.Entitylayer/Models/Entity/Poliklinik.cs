using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.EntityLayer.Models.Entity
{
    public class Poliklinik
    {
        [Key]
        public int PoliklinikID { get; set; }
        public string PoliklinikAdı { get; set; }
    }
}
