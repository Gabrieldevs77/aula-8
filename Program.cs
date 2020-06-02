using System;

namespace aula_8{
    
     class Program
    {
        static void Main(string[] args)
        {
            cartaodecredito visa = new cartaodecredito();

            System.Console.WriteLine("Digite a data do pagamento");
            visa.data = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Data digitada: "+visa);
        }
    }
}

