using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>

            // Create a data source by using a collection initializer.

{
   new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
   new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
   new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
   new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
   new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
   new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
   new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
   new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
   new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
   new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
   new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
   new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91} }
};

            // Create the query.

            IEnumerable<Student> studentQuery =
             from student in students
             where student.Scores[0] > 90
             //where student.Scores[0] > 90 && student.Scores[3] < 80
             //orderby student.Last ascending
             //orderby student.Scores[0] descending
             select student;

                    foreach (Student student in studentQuery)
                  {
                      Console.WriteLine("{0}, {1} {2}", student.Last, student.First, student.Scores[0]);

                  }

             /*
            //Another query using var
            var studentQuery2 =
             from stud in students
             where stud.Scores[0] > 80
             group stud by stud.Last[0];


            foreach (var studentGroup in studentQuery2)
            {
                Console.WriteLine("\n" + studentGroup.Key);
                foreach (Student student in studentGroup)
                {
                    Console.WriteLine("   {0}, {1}",
                              student.Last, student.First);
                }
            }


            */

          
            Console.ReadLine();


        }
    }

    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;
    }

    // Create a data source by using a collection initializer.


}

