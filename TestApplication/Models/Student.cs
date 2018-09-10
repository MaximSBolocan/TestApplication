using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class Student
    {
        public virtual int ID { get; set; }
        public virtual string SName { get; set; }
        public virtual string SLastName { get; set; }
        public virtual int SAge { get; set; }
        public virtual Class SClass { get; set; }
        public virtual int ClassID { get; set; }
        public virtual Teacher STeacher { get; set; }
        public virtual int TeacherID { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual int SemesterID { get; set; }
        // this is a test of the GhitHub 
    }
}