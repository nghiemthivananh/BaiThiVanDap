using Microsoft.EntityFrameworkCore;
using NghiemThiVanAnh078.Models;

namespace NghiemThiVanAnh078.Data
{
public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
            public DbSet<NTVA078> NTVA078 { get; set;}
            public DbSet<Lop> Lop { get; set;}
      

    }
 }
