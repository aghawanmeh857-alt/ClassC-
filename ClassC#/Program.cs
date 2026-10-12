using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Student
    {
        // Fields
        public string Name;
        public int Age;
        public double Grade;

        // Constructor
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        // Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create 3 objects using Constructor
            Student student1 = new Student("Ahmad", 20, 85);
            Student student2 = new Student("Sara", 21, 92);
            Student student3 = new Student("Omar", 19, 78);

            Console.WriteLine("===== Student Information =====");
            Console.WriteLine();

            // Call DisplayInfo Method
            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();
        }
    }
}
//1.
//A class is a blueprint used to create objects
//2.
//An object is an instance of a class.
//3.
// Class Defines data and methods

// Object Has actual data

//4.
//    Encapsulation
//    Inheritance
//    Polymorphism
//    Abstraction

//5.A constructor is a special method that runs automatically when an object is created