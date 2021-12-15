using System;
using System.Collections.Generic;

namespace Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student();
            firstStudent.age = 25;
            firstStudent.grades = new List<double>() { 2, 3 };
            firstStudent.name = "Gogi";
            PrintStudent(firstStudent);
        }
        static void PrintStudent(Student student)
        {
            Console.WriteLine(student.name);
        }
    }
    class Student
    {
        public string name;
        public int age;
        public List<double> grades;
    }
}
