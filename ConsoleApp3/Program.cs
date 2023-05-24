using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class StringSet
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Лабораторная работа №{0}", 1);
                Console.WriteLine("Работа с множествами");
                int[] mnoj1 = new int[] { -7, -5, 2 };
                int[] mnoj2 = new int[] { -3, 0, 1 };
                int[] mnoj_univer = new int[] { -7, -5, -3, 0, 1, 2 };


                Console.WriteLine(" "); Console.WriteLine(" "); Console.WriteLine(" ");

                Console.WriteLine("Union");
                var objed = mnoj1.Union(mnoj2);
                foreach (var elem in objed)
                    Console.WriteLine(elem);

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine("perese4");
                try
                {
                    var perese4 = mnoj1.Intersect(mnoj2);
                    foreach (var elem in perese4)
                        Console.WriteLine(elem);
                    Console.WriteLine("pustoe mnojestvo");
                }
                catch { Console.WriteLine("Error"); }


                Console.WriteLine(" "); Console.WriteLine(" "); Console.WriteLine(" ");

                Console.WriteLine("A Exept B");

                var exept1 = mnoj1.Except(mnoj2);
                foreach (var elem in exept1)
                    Console.WriteLine(elem);

                Console.WriteLine(" "); Console.WriteLine(" "); Console.WriteLine(" ");

                Console.WriteLine("B Exept A");
                var exept2 = mnoj2.Except(mnoj1);
                foreach (var elem in exept1)
                    Console.WriteLine(elem);

                Console.WriteLine(" "); Console.WriteLine(" "); Console.WriteLine(" ");

                Console.WriteLine("exept union");
                var exe_union = exept1.Union(exept2);
                foreach (var elem in exe_union)
                    Console.WriteLine(elem);

                Console.WriteLine("dopolnenie mnoj1");
                var dopol1 = mnoj_univer.Except(mnoj1);
                foreach (var elem in dopol1)
                    Console.WriteLine(elem);


                Console.WriteLine("dopolnenie mnoj2");
                var dopol2 = mnoj_univer.Except(mnoj2);
                foreach (var elem in dopol2)
                    Console.WriteLine(elem);

                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}