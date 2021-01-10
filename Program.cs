using System;
using System.Collections.Generic;
using System.Linq;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
                new Student {FirstName = "Jamie", LastName = "Lannister", Classification = "Senior", Major = "General Business", GPA = 1.72},
                new Student {FirstName = "Cersei", LastName = "Lannister", Classification = "Senior", Major = "Computer Information Systems", GPA = 3.02},
                new Student {FirstName = "Daenerys", LastName = "Targaryen", Classification = "Junior", Major = "Marketing", GPA = 4.00},
                new Student {FirstName = "Jon", LastName = "Snow", Classification = "Freshman", Major = "Marketing", GPA = 4.00},
                new Student {FirstName = "Arya", LastName = "Stark", Classification = "Senior", Major = "Computer Information Systems", GPA = 3.70},
                new Student {FirstName = "Davos", LastName = "Seaworth", Classification = "Freshman", Major = "Computer Information Systems", GPA = 1.50},
                new Student {FirstName = "Tyrion", LastName = "Lannister", Classification = "Sophomore", Major = "Accounting", GPA = 2.80},
                new Student {FirstName = "Robert", LastName = "Baratheon", Classification = "Sophomore", Major = "Economics", GPA = 3.50},
                new Student {FirstName = "Khal", LastName = "Drogo", Classification = "Junior", Major = "General Business", GPA = 3.00},
                new Student {FirstName = "Jorah", LastName = "Mormont", Classification = "Junior", Major = "Economics", GPA = 1.00},
            };

            /***** QUERY 1: Select studnets with a GPA of 2.0 or less *****/
            var query1QS = from s in students
                where s.GPA <= 2.00
                select s;
            
            Console.WriteLine("---Query 1 Query Syntax---");
            foreach (var s in query1QS)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}\t{s.GPA:N} GPA");
            }

            var query1MS = students.Where(s => s.GPA <= 2.00);
            Console.WriteLine("\n---Query 1 Method Syntax---");
            foreach (var s in query1MS)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}\t{s.GPA:N} GPA");
            }

            /***** QUERY 2: Select studnets with a GPA between 2.0 and 3.0 inclusive *****/
            var query2QS = from s in students
                            where s.GPA >= 2.00
                            where s.GPA <= 3.00
                            select s;
            Console.WriteLine("\n---Query 2 Query Syntax---");
            foreach (var s in query2QS)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}\t{s.GPA:N} GPA");
            }

            var query2MS = students.Where(s => s.GPA >= 2.00)
                                    .Where(s => s.GPA <= 3.00);
            Console.WriteLine("\n---Query 2 Method Syntax---");
            foreach (var s in query2MS)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}\t{s.GPA:N} GPA");
            }

            /***** QUERY 3: Select just the last name of students with a GPA equal to 4.0
             ***** In this query, I want you to use the select clause/method with projection
             *****/
            var query3QS = from s in students
                            where s.GPA == 4.00
                            select s.LastName;
            Console.WriteLine("\n---Query 3 Query Syntax---");
            foreach (var s in query3QS)
            {
                Console.WriteLine($"{s}");
            }

            var query3MS = students.Where(s => s.GPA == 4.00)
                                    .Select(s => s.LastName);
            Console.WriteLine("\n---Query 3 Method Syntax---");
            foreach (var s in query3MS)
            {
                Console.WriteLine($"{s}");
            }

            /***** QUERY 4: Sort all students by GPA from highest to lowest *****/
            var query4QS = from s in students
                            orderby s.GPA descending
                            select s;
            Console.WriteLine("\n---Query 4 Query Syntax---");
            foreach (var s in query4QS)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}\t{s.GPA:N} GPA");
            }

            var query4MS = students.OrderByDescending(s => s.GPA);
            Console.WriteLine("\n---Query 4 Method Syntax---");
            foreach (var s in query4MS)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}\t{s.GPA:N} GPA");
            }

            /***** QUERY 5: Own query chaining TWO methods together *****/
            // Juniors with a GPA of at least 3.00 are eligible for the Kings Landing Scholarship
            var query5QS = from s in students
                            where s.Classification == "Junior"
                            where s.GPA >= 3.00
                            orderby s.GPA descending
                            select s;
            Console.WriteLine("\n---Query 5 Query Syntax---");
            foreach (var s in query5QS)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}\t{s.GPA:N} GPA");
            }

            var query5MS = students.Where(s => s.Classification == "Junior")
                                    .Where(s => s.GPA >= 3.00)
                                    .OrderByDescending(s => s.GPA);
            Console.WriteLine("\n---Query 5 Method Syntax---");
            foreach (var s in query5MS)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}\t{s.GPA:N} GPA");
            }
        }
    }
}
