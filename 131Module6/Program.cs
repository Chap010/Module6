using System;
using System.Collections.Generic;

namespace _131Module6
{
    class Program
    {
        static void Main()
        {
            int[] myArray = new int[5] {1,2,3,4,5};

            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
            myArray[4] = 5;

            Console.WriteLine("Arrays Values: ");
            foreach (var item in myArray)
            {
                Console.WriteLine(item );
            }

            List<string> mylista = new List<string>();
            mylista.Add("1");
            mylista.Add("2");
            mylista.Add("3");
            mylista.Add("4");
            mylista.Add("5");
            mylista.Add("6");
            mylista.Add("7");
            mylista.Add("8");
            mylista.Add("9");
            mylista.Add("10");
            Console.WriteLine("");
            Console.WriteLine("List Values Values: ");
            foreach (var item in mylista)
            {
                Console.WriteLine(item);
            }
        }

    }

}
