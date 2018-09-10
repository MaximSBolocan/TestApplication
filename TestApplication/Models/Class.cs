using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class Class
    {
       
        public virtual int ID { get; set; }
        public virtual List<Student>Students { get; set; }
        public virtual List<int> StudentsID { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual int TeacherID { get; set; }
    }
}