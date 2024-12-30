using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjeAppSube1;

namespace ProjeAppSube1
{
    internal class Ders
    {
        public int DersID { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(20)]
        [Required]
        public string DersAd { get; set;}

        [Column(TypeName = "Varchar")]
        [MaxLength(20)]
        [Required]
        public string DersKod { get; set; }
        public ICollection<OgrenciDers> OgrenciDers { get; set; } 
    }
}
//Ara tablodaki navigasyon property sayesinde:
//Ogrenciden Derslere erişebilirsin.
//Derslerden Ogrencilere erişebilirsin.
