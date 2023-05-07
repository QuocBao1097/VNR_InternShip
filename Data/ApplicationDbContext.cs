using CourseEduWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace CourseEduWeb.Data
{
    public class ApplicationDbContext:DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<KhoaHoc> KhoaHoc { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
    }
}
