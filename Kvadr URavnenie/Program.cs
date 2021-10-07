using System;

namespace Kvadr_URavnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            string otv = " ";
            //ax^2+bx+c
            //D=b^2-4ac
            new Reshenie(1, 4, -1).raschet(out otv);
            
            Console.WriteLine(otv);
            Console.ReadKey();
            

        }

        class Reshenie
        {
            private double a;
            private double b;
            private double c;
            private double D;
            private double x1;
            private double x2;
            public string otv;
            public Reshenie(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public void raschet(out string otv)
            {
                D = Math.Pow (b, 2) - 4 * a * c;
                if (D > 0 || D == 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    otv = $"x1= {x1}\n x2= {x2}";
                    
                }

                else
                {
                    otv = $"Действительных корней нет";
                }
            }

        }
    }
}     
