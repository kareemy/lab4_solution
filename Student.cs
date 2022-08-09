using System;

namespace lab4
{
    public class Student
    {
        public int StudentId {get; set;}
        public string FirstName {get; set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public string Classification {get; set;} = string.Empty;
        public string Major {get; set;} = string.Empty;
        public double GPA {get; set;}
    }
}