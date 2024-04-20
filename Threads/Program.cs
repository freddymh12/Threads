using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(MetodoSaludo);
            t.Start();

            Thread t2 = new Thread(MetodoSaludo);
            t2.Start();

            Console.WriteLine("Hola mundo desde thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola mundo desde thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola mundo desde thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola mundo desde thread 1");
            Thread.Sleep(500);
            Console.WriteLine("Hola mundo desde thread 1");
            Thread.Sleep(500);

            MetodoSaludo();
        }

        static void MetodoSaludo()
        {
            Console.WriteLine("Hola mundo desde thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola mundo desde thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola mundo desde thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola mundo desde thread 2");
            Thread.Sleep(500);
            Console.WriteLine("Hola mundo desde thread 2");
            Thread.Sleep(500);
        }
    }
}