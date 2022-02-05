using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        //public override string ToString()
        //{
        //    return $"{FirstName} {LastName}: {Grade:f2}";
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
            string[] command = Console.ReadLine()
                .Split();

                Student student = new Student
                {
                    FirstName = command[0],
                    LastName = command[1],
                    Grade = double.Parse(command[2])
                };
                students.Add(student);
            }
           
                List<Student> sorted = students.OrderByDescending(x => x.Grade).ToList();
            
            foreach (var student in sorted)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
