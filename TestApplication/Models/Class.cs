﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class Class
    {
       
        public virtual int ID { get; set; }
        public virtual int TeacherID { get; set; }
        public virtual int StudentID { get; set; }

    }
}