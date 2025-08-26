using System;
using System.Collections.Generic;

namespace Ejercicio
{
    public class Programa
    {
        static void Main(string[] args)
        {
            List<Pedidos> MisPedidos = new List<Pedidos>();
            string detalles = "";
            char opcion;
            do
            {
                Console.WriteLine("Ingrese la Descripcion de pedido");
                detalles = Console.ReadLine() ?? string.Empty; 
                MisPedidos.Add(new Pedidos(detalles));

                Console.WriteLine("Desea Ingresar Otro PEDIDO? (S/N):"); // Mensaje más claro

                // --- CAMBIO CLAVE AQUÍ ---
                ConsoleKeyInfo keyInfo = Console.ReadKey(); // Leer la tecla presionada
                opcion = keyInfo.KeyChar;                    // Obtener el char de la tecla
                Console.WriteLine();                         // Salto de línea después de ReadKey para limpiar la consola
                opcion = char.ToUpper(opcion);               // Convertir a mayúscula
                 // --- FIN DEL CAMBIO CLAVE ---
                
            } while (opcion == 'S');

            foreach (Pedidos i in MisPedidos)
            {
                i.Informacion();
            }
            Console.WriteLine(Pedidos.MostrarTotalDePedidos());
        }
    }

    public class Pedidos
    {
        private static int contadorDePedidos = 0;
        private static int siguienteID = 1;
        private int iD;
        private string detalles;

        public Pedidos(string Descripcion)
        {
            this.detalles = Descripcion;
            this.iD = siguienteID;
            siguienteID += 1;
            contadorDePedidos += 1;
        }

        public void Informacion(){
            Console.WriteLine($"Pedido ID: {iD}, Descripcion: {detalles} ");
        }
        public static string MostrarTotalDePedidos()
        {
            return $"Total de Pedidos realizados {contadorDePedidos}";
        }
    }

}