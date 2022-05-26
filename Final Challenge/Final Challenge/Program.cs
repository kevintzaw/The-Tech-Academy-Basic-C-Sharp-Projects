using System;
using System.Data.Entity;

namespace Final_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new studentDatabaseContext())
            //Create a new student entry
            Console.Write("Enter a first name for the student: ");
            var exampleName = Console.ReadLine();

            var posts = new studentPost { personName = exampleName };
            db.studentDatabases.Add(posts);
            db.SaveChanges();

            // Display all students from the database
            var query = from b in DbSet.studentDatabases
                        orderby b.personName
                        select b;
            Console.WriteLine("All students in the database: ");
            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    public class studentDatabase
    {
        public string name { get; set; }
        public int idenNumber { get; set; }
    }

    public class studentPost
    {
        public int PostId { get; set; }
        public string personName { get; set; }
        public int idenNumber { get; set; }
    }

    public class studentDatabaseContext : studentPostsContext
    {
        public DbSet<studentDatabase> studentDatabases { get; set; }
        public DbSet<studentPost> studentPosts { get; set; }

    }
}
