using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task_17_9.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual Corse Corses { get; set; }
    }
}