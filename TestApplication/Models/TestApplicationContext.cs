using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class TestApplicationContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TestApplicationContext() : base("name=TestApplicationContext")
        {
        }

        public System.Data.Entity.DbSet<TestApplication.Models.Class> Classes { get; set; }

        public System.Data.Entity.DbSet<TestApplication.Models.Teacher> Teachers { get; set; }

        public System.Data.Entity.DbSet<TestApplication.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<TestApplication.Models.Semester> Semesters { get; set; }

        public System.Data.Entity.DbSet<TestApplication.Models.Grades> Grades { get; set; }
    }
}
