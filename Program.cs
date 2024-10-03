using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos_Basico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread hilo1 = new Thread(funcionHilo);

            Thread hilo2 = new Thread(funcionHilo);

            hilo1.Start();
            hilo2.Start();
        }
        
        public static void funcionHilo()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Hilo Principal "+ i);
                Thread.Sleep(500);
            }   
        }
         
        public static void funcionHilo2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hilo Principal " + i);
                Thread.Sleep(500);
            }
        }
    }
}
