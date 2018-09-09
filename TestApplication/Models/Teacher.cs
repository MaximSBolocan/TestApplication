using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class Teacher
    {
        public virtual int ID { get; set; }
        public virtual string TName { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<Semester> Semesters { get; set; }
        // This is a test
    }
}