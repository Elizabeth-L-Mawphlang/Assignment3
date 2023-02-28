using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment3
{
    class Program
    {

        static void Main(string[] args)
        {
            Student s = new Student (1, "tyti" ,"mca" ,4 ,"cs');
            s.DisplayData();
            s.GetMarks();
            s.DisplayResult();
        }
        public class Student
        {
            private int rollno;
            private string name;
            private string className;
            private int semester;
            private string branch;
            private int[] marks = new int[5];

            public Student(int rollno, string name, string className, int semester, string branch)
            {
                this.rollno = rollno;
                this.name = name;
                this.className = className;
                this.semester = semester;
                this.branch = branch;
            }

            public void GetMarks()
            {
                Console.WriteLine("Enter the marks for {name}:");
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.Write("Subject {i + 1}: ");
                    marks[i] = int.Parse(Console.ReadLine());
                }
                Console.ReadLine();
            }

            public void DisplayResult()
            {
                int sum = 0;
                foreach (int mark in marks)
                {
                    sum += mark;
                    if (mark < 35)
                    {
                        Console.WriteLine("Result: Failed");
                        return;
                    }
                }

                double average = sum / (double)marks.Length;

                if (average < 50)
                {
                    Console.WriteLine("Result: Failed");
                }
                else
                {
                    Console.WriteLine("Result: Passed");
                }
            }

            public void DisplayData()
            {
                Console.WriteLine("Roll No: {rollno}");
                Console.WriteLine("Name: {name}");
                Console.WriteLine("Class: {className}");
                Console.WriteLine("Semester: {semester}");
                Console.WriteLine("Branch: {branch}");
                Console.WriteLine("Marks:");
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.WriteLine("Subject {i + 1}: {marks[i]}");
                    Console.ReadLine();
                }
            }
        }
    }
}


