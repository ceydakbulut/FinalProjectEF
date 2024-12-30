using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjeAppSube1
{
    internal class Ogrenci
    {
        public int OgrenciID { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(20)]
        [Required] 
        public string Ad { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(20)]
        [Required]
        public string Soyad { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(20)]
        [Required]
        public string Numara { get; set; }
        public int SinifId { get; set; } // *1e cok
        public Sinif Sinif { get; set; } // sınıflar tablosundan bir obje türettik Navigation Property *(1 e cok)

        public ICollection<OgrenciDers> OgrenciDers { get; set; } // coka cok   

       
    }
}
