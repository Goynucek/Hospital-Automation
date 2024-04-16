using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.EntityLayer.Models.Entity
{
    public class Giris
    {
        [Key]
        public int GirisId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int PersonelID { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
