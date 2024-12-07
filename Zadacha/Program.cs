using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList originalList = new LinkedList();
            originalList.Append(1);
            originalList.Append(2);
            originalList.Append(3);
            originalList.Append(4);
            originalList.Append(5);

            LinkedList evenList = originalList.SplitList("even");
            LinkedList oddList = originalList.SplitList("odd");

            Console.WriteLine("Spisuk s chetni chisla: ");
            evenList.PrintList();

            Console.WriteLine("Spisuk s nechetni chisla: ");
            oddList.PrintList();
        }
    }
}

