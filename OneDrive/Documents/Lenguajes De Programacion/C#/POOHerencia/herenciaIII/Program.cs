using System;

namespace herencia2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t --Mamiferos--");
            Mamiferos Mifoca = new Mamiferos("Foca");
            Mifoca.getNombre();

            Console.WriteLine("\t --Humano--");
            Humano alex = new Humano("Alex");
            alex.getNombre();
            

            Console.WriteLine("\t --Leon--");
            Leon Mileon = new Leon("Max");
            Mileon.getNombre();
           
        }
    }

    public class Mamiferos
    {
        private string NomSerVivo;
        public Mamiferos(string NombreSerVivo)
        {
            NomSerVivo = NombreSerVivo;
        }
        public void Beber()
        {
            Console.WriteLine("Bebo Leche");
        }
        public void Reproduccion()
        {
            Console.WriteLine("Me puedo reproducir");
        }

        public void getNombre()
        {
            Console.WriteLine($"Nombre del ser Vivo {NomSerVivo}");
        }
        
    }

    public class Humano : Mamiferos
    {
        public Humano(string NombreHumano) : base(NombreHumano) { }
        public void Pensar()
        {
            Console.WriteLine("Puedo Pensar y razonar");
        }
        public void Conducir()
        {
            Console.WriteLine("Puedo conducir autos y motos");
        }
    }

    public class Leon: Mamiferos
    {
        public Leon(string NombreLeon) : base(NombreLeon) { }
        public void Cazar() { Console.WriteLine("Puedo Cazar"); }
        public void Rugir(){ Console.WriteLine("Puedo rugir");}
    }
}
