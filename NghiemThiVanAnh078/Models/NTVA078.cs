using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NghiemThiVanAnh078.Models
{
     
    public class NTVA078
    {
        [Key]
        public string Masinhvien { get; set; }
        public int Tuoi { get; set; }

        public double Diem { get; set; }

    }
}