using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class Semester
    {
        public virtual int ID { get; set;}
        public virtual string SemesterName { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<int>StudentsID { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
        public virtual List<int> TeachersID { get; set; }
    }
}