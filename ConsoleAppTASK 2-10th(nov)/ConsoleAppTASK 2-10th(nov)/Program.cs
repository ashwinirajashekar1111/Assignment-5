using System;
using System.Collections;
namespace ConsoleAppTASK_2_10th_nov_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList studentGrades = new ArrayList();


            //   studentGrades.Add(85);
            //   studentGrades.Add(92);
            // studentGrades.Add(78);
            // studentGrades.Add(95);
            // studentGrades.Add(88);
            // Console.WriteLine("Student Grades:");
            // foreach (var grade in studentGrades)
            // {
            //   Console.WriteLine(grade);
            // }

            //----------------------------------------TASK-2-----------------------------------------


            // ArrayList studentGrades = new ArrayList { 85, 92, 78, 95, 88 };
            // Console.WriteLine("Student Grades:");
            // foreach (var grade in studentGrades)
            // {
            //   Console.WriteLine(grade);
            // }
            // int sum = 0;
            //  foreach (var grade in studentGrades)
            //  {
            //     sum += (int)grade;
            // }

            // Console.WriteLine($"Sum of Grades: {sum}");

            //------------------------------------TASK-3---------------------------------

            // ArrayList studentGrades = new ArrayList { 85, 92, 78, 95, 88 };
            // studentGrades.Add(90);
            // Console.WriteLine("Updated Student Grades:");
            // foreach (var grade in studentGrades)
            // {
            //   Console.WriteLine(grade);
            // }

            //----------------------------------TASK-4--------------------------------

            // ArrayList studentGrades = new ArrayList { 85, 92, 78, 95, 88 };
            // studentGrades.Remove(78);
            // Console.WriteLine("Updated Student Grades:");
            // foreach (var grade in studentGrades)
            // {
            //    Console.WriteLine(grade);
            //  }

            //------------------------------------TASK-5---------------------------------------

            ArrayList studentGrades = new ArrayList { 85, 92, 78, 95, 88 };
            int indexOf95 = studentGrades.IndexOf(95);
            if (indexOf95 != -1)
            {
                studentGrades[indexOf95] = 96;
            }
            Console.WriteLine("Updated Student Grades:");
            foreach (var grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
