using System;

namespace ClasedeStatic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t----Antes de Instanciar----");
            Console.WriteLine($"Total de Perros :{Perros.Contador()}");

            Console.WriteLine("\t----Despues de Instanciar----");
            Perros Miperro1 = new Perros();
            Console.WriteLine($"Total de Perros :{Perros.Contador()}");
            Console.ReadKey();
        }
    }

    public class Perros
    {
        private static int contador = 0;
        public Perros()
        {
            contador += 1;
        }

        public static int Contador() => contador;
    }
}

