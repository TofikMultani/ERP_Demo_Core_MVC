using Microsoft.EntityFrameworkCore;
using ERP_Demo_Core_MVC.Models;

namespace ERP_Demo_Core_MVC.Models.DATABASEFOLDER
{
    public class SchoolDB : DbContext
    {
        public SchoolDB(DbContextOptions<SchoolDB> options)
            : base(options)
        {
        }

        public DbSet<StudentModel> Students { get; set; }
        public DbSet<TeacherModel> Teachers { get; set; }
    }
}