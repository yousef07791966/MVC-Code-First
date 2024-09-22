using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace task_17_9.Models
{
    public class DBContext  : DbContext
    {
        public DBContext() : base("yousef")
        {
        }
        public DbSet <Student> Students { get; set; }

        public DbSet <Corse> corses { get; set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{



        //    base.OnModelCreating(modelBuilder);
        //}

        //public System.Data.Entity.DbSet<task_17_9.Models.Classes> Classes { get; set; }

    }

}