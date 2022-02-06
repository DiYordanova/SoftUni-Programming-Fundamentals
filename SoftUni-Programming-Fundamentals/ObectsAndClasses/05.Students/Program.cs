using System;
using System.Collections.Generic;

namespace _05.Students2
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] command = line.Split();
                string firstName = command[0];
                string lastName = command[1];
                string age = command[2];
                string homeTown = command[3];
                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;
                studentList.Add(student);
            }

            string town = Console.ReadLine();
        }
    }
}

