using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Final_Challenge
{
    class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }


    }
}
