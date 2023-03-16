using System;

namespace Lesson1Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal pig = new Pig();
            Animal dog = new Dog();

            animal.AnimalSound();
            pig.AnimalSound();
            dog.AnimalSound();

            //Student s1 = new Student();

            //s1.SetName("Oncum");
            //s1.SetSurname("Yilmaz");
            //s1.SetStudentNumber(12345);
            //s1.SetMidtermGrade(98);
            //s1.SetFinalGrade(88);
            //s1.SetProjectGrade(78);


            //Console.WriteLine("Student Name Is: " + s1.GetName());
            //Console.WriteLine("Student Surname Is: " + s1.GetSurname());
            //Console.WriteLine("Student Number Is: " + s1.GetStudentNumber());
            //Console.WriteLine("Student Total Grade Is: " + s1.CalculateTotalGrade());
        }
    }
}
