using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosVectores
{
    class Program
    {
        public double Potencia1(int x, int y)
        {
            int i = 1, po = 1;
            while (i <= y)
            {
                po = po * x;
                i++;
            }
            return po;
        }

        public double Potencia2(int x, int y)
        {
            int i = 1, po = 1;
            do
            {
                po = po * x;
                i++;
            } while (i <= y);
            return po;
        }

        public double Potencia3(int x, int y)
        {
            if (x <= 0)
            {
                throw new Exception("X debe de ser positivo");
            }
            if (y <= 0)
            {
                throw new Exception("y debe de ser positivo");
            }
            int po = 1;
            for (int i = 1; i <= y; i++)
            {
                po = po * x;
            }
            return po;
        }
        public void EcuacionCuadrtica(int a, int b, int c)
        {
            double x1 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            double x2 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);

            Console.WriteLine("x1 = {1}, X2 = {0}", x1, x2);
        }

        public string Calificacion(double cal)
        {
            string res;
            if (cal >= 0 && cal < 5)
                res = "suspenso";
            else if (cal >= 5 && cal < 6.5)
                res = "aprobado";
            else if (cal >= 6.5 && cal < 8.5)
                res = "notable";
            else if (cal >= 8.5 && cal < 10)
                res = "sobresaliente";
            else
                res = "matrícula de honor";

            return res;
        }
        static void Main(string[] args)
        {
            EjerciciosVectores.Program obj = new EjerciciosVectores.Program();

            Console.WriteLine(obj.Potencia1(3, 4));

            Console.WriteLine(obj.Potencia2(2, 2));
            try
            {
                Console.WriteLine(obj.Potencia3(-5, 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
            obj.EcuacionCuadrtica(2, -8, 6);
            Console.WriteLine(obj.Calificacion(10));
            Console.ReadKey();
            //Console.WriteLine("x1 = {1}, X2 = {0}", x1, x2);
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
            double suma = 0;
            Console.WriteLine("\n Elementos del vector");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("elemento indice {0} -->{1}", (i + 1), x[i]);
                
            }
            for(int i =0;i<x.Length;i++)
            {
                suma += x[i];
            }
            Console.WriteLine("la sumatoria es {0}: ", suma);

            Console.WriteLine("el promedio es {0}: ", suma/x.Length);
        }
        public static void vectordiezelementos()
        {
            int[] x = new int[10];
            int num; 
            double suma = 0;
            
                for (int i = 0; i < x.Length; i++)
                {
                do
                {
                    
                    Console.WriteLine(" ingrese un numero");
                    i = int.Parse(Console.ReadLine());
                   
                }
                while (i <= 1000);
            }
        }
    }
}
