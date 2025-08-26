using System;

namespace Delegados
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ObjetosDelegados Midelegado = new ObjetosDelegados(Bienvenida.MensajeBienvenida);
            Midelegado("Al Hotel Cinco Estrella.");
            Midelegado = new ObjetosDelegados(Despedida.MensajeDespedida);
            Midelegado("Vuelve Pronto.");
        }

        delegate void ObjetosDelegados(string Texto);
    }

    public class Bienvenida
    {

        public static void MensajeBienvenida(string Texto)
        {
            Console.WriteLine($"Bienvenido : {Texto}");
        }
    }
    
    public class Despedida {

        public static void MensajeDespedida(string Texto){
            Console.WriteLine($"Muchas Gracias Por Tu visita : {Texto}");
        } 
    }
}
