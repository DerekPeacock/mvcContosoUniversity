using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace mvcContosoUniversity.Models
{
    public class ContosoContext : DbContext
    {
        public ContosoContext() : base("DefaultConnection")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrolment> Enrolments { get; set; }
        public DbSet<Course> Courses { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}