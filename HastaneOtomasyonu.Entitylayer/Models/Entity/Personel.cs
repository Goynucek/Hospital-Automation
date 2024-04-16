using HastaneOtomasyonu.EntityLayer.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HastaneOtomasyonu.EntityLayer.Models.Entity
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string PersonelAdı { get; set; }
        public string PersonelSoyadı { get; set; }
        public int KlinikID { get; set; }
        public string Status { get; set; }
    }
}
