using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_LeHoangHuan.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<DiaNhac> DiaNhacs { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaNhac>().HasData(
                  new DiaNhac { Id = 1, TuaCD = "No Internet", NgheSi = "Aki", TrongNuoc = true, GiaBan = 100000, SoLuong = 50 },
                  new DiaNhac { Id = 2, TuaCD = "Là Tất Cả", NgheSi = "jaigon", TrongNuoc = true, GiaBan = 120000, SoLuong = 40 },
                  new DiaNhac { Id = 3, TuaCD = "nắng ấm", NgheSi = "Sơn Tùng", TrongNuoc = true, GiaBan = 100000, SoLuong = 20 },
                  new DiaNhac { Id = 4, TuaCD = "Chú Ché Loắt Choắt", NgheSi = "Dế Choắt", TrongNuoc = true, GiaBan = 100000, SoLuong = 10 },
                  new DiaNhac { Id = 5, TuaCD = "Để Ai Cần", NgheSi = "Bray", TrongNuoc = false, GiaBan = 100000, SoLuong = 15 },
                  new DiaNhac { Id = 6, TuaCD = "Yêu", NgheSi = "Aki", TrongNuoc = true, GiaBan = 100000, SoLuong = 24 }
                );

        }
    }
}
