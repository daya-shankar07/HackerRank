using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayHR
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            var newArray = arr.Reverse();
            foreach (var item in newArray)
            {
                Console.Write(String.Format("{0}{1}", item, " "));
            }
            Console.ReadLine();
        }
    }
}
