using System;

namespace Introdução_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int Alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    Alcool = Alcool + 1;
                }
                else if (tipo == 2)
                {
                    Gasolina = Gasolina + 1;
                }
                else if (tipo == 3)
                {
                    Diesel = Diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool = " + Alcool);
            Console.WriteLine("Gasolina = " + Gasolina);
            Console.WriteLine("Diesel = " + Diesel);

        }
    }
}
