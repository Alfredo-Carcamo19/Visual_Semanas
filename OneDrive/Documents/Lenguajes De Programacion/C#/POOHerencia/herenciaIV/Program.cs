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
            Mifoca.Pensar();

            Console.WriteLine("\t --Humano--");
            Humano alex = new Humano("Alex");
            alex.getNombre();
            alex.Pensar();

            Console.WriteLine("\t --Leon--");
            Leon Mileon = new Leon("Max");
            Mileon.getNombre();
            Mileon.Pensar();
        }
    }

    public class Mamiferos
    {
        private string NomSerVivo;
        public Mamiferos(string NombreSerVivo)
        {
            NomSerVivo = NombreSerVivo;
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Tengo un pensamiento Generico");
        }

        public void getNombre()
        {
            Console.WriteLine($"Nombre del ser Vivo {NomSerVivo}");
        }
        
    }

    public class Humano : Mamiferos
    {
        public Humano(string NombreHumano) : base(NombreHumano) { }
        public override void Pensar()
        {
            Console.WriteLine("Puedo Pensar y razonar");
        }
        public void Conducir()
        {
            Console.WriteLine("Puedo conducir autos y motos");
        }
    }

    public class Leon : Mamiferos
    {
        public Leon(string NombreLeon) : base(NombreLeon) { }
        public void Cazar() { Console.WriteLine("Puedo Cazar"); }
        public void Rugir() { Console.WriteLine("Puedo rugir"); }

        public override void Pensar()
        {
            Console.WriteLine("Pienso menos que los humanos....");
        }
    }
}
