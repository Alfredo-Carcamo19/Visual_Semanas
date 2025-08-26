using System;
using System.Collections.Generic;

namespace Lambdass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*--Con un parametro--*/
            Cuadrado operacion = new Cuadrado(num => num * num);
            Console.WriteLine(operacion(5));

            /*--Con 2 parametros--*/
            Suma Op = new Suma((n1, n2) => n1 + n2);
            Console.WriteLine($"Resultado de la Suma : {Op(5, 10)}");


            /*--Con lista--*/
            List<int> Numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> NumerosPares = Numeros.FindAll(item => item % 2 == 0);
            NumerosPares.ForEach(actual => { Console.Write("Numero Par : "); Console.Write($"{actual} .\n"); });


            /*-- En Instancias --*/
            Persona p1 = new Persona();
            p1.Edad = 20;
            p1.Nombre = "Pedro";

            Persona p2 = new Persona();
            p2.Edad = 25;
            p2.Nombre = "PeDro";

            Iguales Comparacion = new Iguales((nomb1 , nomb2) => nomb1.Equals(nomb2,StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Son Iguales : {Comparacion(p1.Nombre,p2.Nombre)}");
        }
    }

    public delegate int Cuadrado(int numero);

    public delegate int Suma(int numero1, int numero2);

    public delegate bool Iguales(string Nombre1, string Nombre2);
    public class Persona
    {
        private string _nombre;
        private int _edad;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => _edad; set => _edad = value; }
    }

}
