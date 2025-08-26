using System;

namespace Exepciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero;

            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Tipo de error: {ex.GetType().Name}");
    
                numero = 0;
            }
            Console.WriteLine($"numero : {numero}");
        }
    }
}