using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAppSube1
{
    internal class OgrenciDers
    {
        public int OgrenciID { get; set; }
        public Ogrenci Ogrenci { get; set; } 
        public int DersID { get; set; }
        public Ders Dersler { get; set; }
        
        
    }
}
