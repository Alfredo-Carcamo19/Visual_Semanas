using System;

namespace herencia2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t --Mamiferos--");
            Mamiferos Mifoca = new Mamiferos();
            Mifoca.Reproduccion();
            Mifoca.Beber();

            Console.WriteLine("\t --Humano--");
            Humano alex = new Humano();

            alex.Conducir();
            alex.Reproduccion();

            Console.WriteLine("\t --Leon--");
            Leon Mileon = new Leon();

            Mileon.Cazar();
        }
    }

    public class Mamiferos
    {
        public void Beber()
        {
            Console.WriteLine("Bebo Leche");
        }
        public void Reproduccion()
        {
            Console.WriteLine("Me puedo reproducir");
        }
    }

    public class Humano : Mamiferos
    {
        public void Pensar()
        {
            Console.WriteLine("Puedo Pensar y razonar");
        }
        public void Conducir()
        {
            Console.WriteLine("Puedo conducir autos y motos");
        }
    }

    public class Leon(): Mamiferos
    {
        public void Cazar(){ Console.WriteLine("Puedo Cazar");}
        public void Rugir(){ Console.WriteLine("Puedo rugir");}
    }
}
