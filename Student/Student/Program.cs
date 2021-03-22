using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("CSE");
            Department d2 = new Department("EEE");

            Student s1 = new Student("Sabbir","21-11111-1",3.50);
            Student s2 = new Student("Sakib","21-11112-1",3.00);
            Student s3 = new Student("Karim","21-11113-1",3.50);
            Student s4 = new Student("Fahim","21-11114-1",3.00);

            d1.AddStudent(s1, s2);
            d2.AddStudent(s3);
            d2.AddStudent(s4);

            d1.PrintStudent();
            d2.PrintStudent();

            Console.ReadLine();

        }
    }
}
