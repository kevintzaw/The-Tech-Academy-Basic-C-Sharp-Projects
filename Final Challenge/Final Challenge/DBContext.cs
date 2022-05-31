using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Challenge
{
    class SchoolContext: DBContext
    {
        public SchoolContext(): base()
        {

        }

        public DBSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
