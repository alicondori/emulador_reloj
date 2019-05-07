using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//agregando la libreria
using System.Threading;

namespace emulador_reloj
{
    class Program
    {
        static void Main(string[] args)
        {
            int seg = 0, min = 0, hr = 0;
            Console.WriteLine("TIEMPO A EMULAR");
            Console.WriteLine("ingrese la hora");
            hr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el minuto");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese los segundos");
            seg = Convert.ToInt32(Console.ReadLine());

            //validacion de valores en hora, minuto y segundo
            if (hr>=0 & hr<24 & min >=0 & min < 60 & seg>=0 & seg<60)
            {
                for (int h = 0; h < 24; h++)
                {
                    for (int m = 0; m < 60; m++)
                    {
                        for (int s = 0; s < 60; s++)
                        {
                            Console.Clear();
                            Console.WriteLine("{0}:{1}:{2}", h, m, s);

                            if (h == hr & m == min & s == seg)
                            {
                                s = 60;
                                m = 60;
                                h = 24;
                            }

                            Thread.Sleep(1000);
                        }
                    }
                }
                Console.WriteLine("|||tiempo finalizado|||");
            }
            else
            {
                Console.WriteLine("valor ingresado fuera de rango\n0:0:0-23:59:59");
            }
            Console.ReadKey();
        }
    }
}
