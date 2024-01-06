using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NghiemThiVanAnh078.Models
{
    public  class Lop
    {
    
    
        [Key]
      
        public string MaLop { get; set; }
        public string TenLop { get; set; }

        public string? Masinhvien { get; set; }
        [ForeignKey("Masinhvien")]
        public NTVA078? NTVA078 { get; set; } 
        
    
    }
}