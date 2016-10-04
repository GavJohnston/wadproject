using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name;
            int result;

            Console.WriteLine("please enter name");
            name = string.Intern(Console.ReadLine());
            Console.WriteLine("Hello " + name);
            Console.WriteLine("please enter result between 1-100");
            result = int.Parse(Console.ReadLine());

            if (result <= 60)
            Console.WriteLine("failed. hate that"+name);

            if (result >= 60)
            Console.WriteLine("passed. fair play "+name);
            Console.ReadKey();
        }

    }
}


