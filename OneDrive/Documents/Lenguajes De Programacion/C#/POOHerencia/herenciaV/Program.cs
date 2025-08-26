using System;

namespace Ejercicio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
        }
    }

    public class Vehiculo
    {
        public void Arrancar()
        {
            Console.WriteLine("Arrancando Motor");
        }

        public void Parar()
        {
            Console.WriteLine("Parando Motor");
        }

        protected virtual void Conducir()
        {
            Console.WriteLine("Estoy Conduciendo Un Vehiculo ....");
        }
    }

    public class Avion:Vehiculo
    {
        public override void Conducir()
        {
            Console.WriteLine("Estoy Conduciendo El Avion ....");
        }
    }

    public class Auto:Vehiculo
    {
         public override void Conducir()
        {
            Console.WriteLine("Estoy Conduciendo El Auto ....");
        }
    }
}
