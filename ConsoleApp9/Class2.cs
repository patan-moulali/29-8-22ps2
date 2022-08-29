using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Class2
    {
        static void Main()
        {
            LinearQueue Q = new LinearQueue(5);

            Q.insert(10);
            Q.insert(20);
            Q.insert(30);
            Q.insert(40);
            Q.insert(50);

            Console.WriteLine("Items are : ");
            Q.printQueue();

            Q.delete();
            Q.delete();

            Console.WriteLine("Items are : ");
            Q.printQueue();
        }
    }
}
