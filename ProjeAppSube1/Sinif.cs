using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAppSube1
{
    internal class Sinif
    {
        public int SinifId { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(20)]
        [Required]
        public string SinifAd { get; set; }
        
        [Column(TypeName = "Varchar")]
        [MaxLength(20)]
        [Required]
        public string SinifKontenjan { get; set; }
        public List<Ogrenci> Ogrenci { get; set; }  
        public override string ToString()
        {
            return SinifAd;
        }
    }
}
