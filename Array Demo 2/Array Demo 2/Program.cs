using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Demo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Price[] fxPrices;

            //fxPrices[0] = new Price(0.88, "GBP");
            //fxPrices[1] = new Price(1.38, "USD");
            Price[] fxPrices = { new Price(0.98, "USD"), new Price(0.55, "DKK") };

            //for (int item = 0; item<fxPrices.Length; ++item)
            //{
            //Console.WriteLine("Element " + (item + 1) + " in the array is : " + fxPrices[item].Show());
            //}
            Console.WriteLine(fxPrices.Length);
            foreach (var p in fxPrices)
            {
                Console.WriteLine(p.Show());

            }
            int[,] sM = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 9, 8, 7 } };

            int[][] jagged = new int[3][];

            jagged[0] = new int[4] { 1, 2, 3, 4 };
            jagged[1] = new int[5] { 9, 8, 7, 6, 5 };
            jagged[2] = new int[2] { 6, 3 };

            Console.ReadLine();
        }
    }
}
