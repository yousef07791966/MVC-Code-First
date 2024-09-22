using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task_17_9.Models
{
    public class Corse
    {
        public int CorseId { get; set; }
        public string CorseName { get; set; }

        public virtual Student students { get; set; }
    }
}