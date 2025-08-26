using System;

namespace GetandSet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Planilla Salario1 = new Planilla();

            Salario1.Salario = -200;
            Console.WriteLine($"Salario del trabajador es {Salario1.Salario}");
        }
    }

    public class Planilla
    {
        private double _salario;

        public double Salario
        {
            get => _salario;
            set => _salario = Verificacion(value);
        }

        private double Verificacion(double salario)
        {
            if (salario < 0)
            {
                Console.WriteLine("El Salario no puede ser negativo por defecto se asigna un 0 al Salario del trabajador.");
                return 0;
            }
            else
            {
                return salario;
            }
        }

    }
}