using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace HastaneOtomasyonu.EntityLayer.Models.Entity
{
    public class Hasta
    {
        [Key]
        public int HastaID { get; set; }
        public string HastaAdı { get; set; }
        public string HastaSoyadı { get; set; }
        public string HastaTCNO { get; set; }
        public string KanGrubu { get; set; }
        public string? Hastalık { get; set; }
        public ICollection<Muayane> Muayane { get; set;}
    }
}
