using System;
using System.Collections.Generic;

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
        }
    }
}
