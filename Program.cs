using System;
using System.Linq;

namespace Live_Coding_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var array_one = new int[] { 1, 5, 2 };
            var array_two = new int[] { 3, 6, 4 };
            var zipped_array = array_one.Zip(array_two);

            foreach (var item in zipped_array)
                Console.WriteLine(item);
        }
    }
}
