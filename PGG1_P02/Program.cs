using System;

namespace PGG1_P02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal b=0, at=0, ar=0, atriangulo=0, arectangulo=0;
            string inputUser;
            Console.WriteLine("Ingrese el Valor de la Base");
            inputUser = Console.ReadLine();
            if (String.IsNullOrEmpty(inputUser))
            {
                Console.WriteLine("No ingreso Ningun Valor");
            }
            else
            {
                if (Decimal.TryParse(inputUser, out b))
                {
                    b = Convert.ToDecimal(inputUser);
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros");
                }

            }
            Console.WriteLine("Ingrese el Valor de la Altura del Triangulo");
            inputUser = Console.ReadLine();
            if (String.IsNullOrEmpty(inputUser))
            {
                Console.WriteLine("No ingreso Ningun Valor");
            }
            else
            {
                if (Decimal.TryParse(inputUser, out at))
                {
                    at = Convert.ToDecimal(inputUser);
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros");
                }
            }
            Console.WriteLine("Ingrese el Valor de la Altura del Rectangulo");
            inputUser = Console.ReadLine();
            if (String.IsNullOrEmpty(inputUser))
            {
                Console.WriteLine("No ingreso Ningun Valor");
            }
            else
            {
                if (Decimal.TryParse(inputUser, out ar))
                {
                    ar = Convert.ToDecimal(inputUser);
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros");
                }
            }
            atriangulo = Math.Abs((b * at) / 2);
            arectangulo = Math.Abs(b * ar);
            Console.WriteLine($"Area Del Terrono es: {Math.Abs(atriangulo + arectangulo)} Metros");
        }
    }
}
