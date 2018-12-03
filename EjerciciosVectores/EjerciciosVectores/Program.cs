using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            vectorInicializar();
            Console.ReadKey();
        }
        public static void vectorInicializar()
        {
            int[] x = new int[8];
            x[0] = 10;
            x[1] = 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;
            Console.WriteLine("\n Elementos del vector");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("elemento indice {0} -->{1}", (i + 1), x[i]);
            }
        }
    }
}
