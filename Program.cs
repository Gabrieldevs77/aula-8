using System;

namespace aula_8
{
    class Program
    {
        static void Main(string[] args)
        {
            personagem tony = new personagem();

            tony.nome = "Tony Stark";
            tony.armadura = "MK LXXXV";
            tony.idade = 37;
           
           Console.WriteLine(tony.atacar());
            Console.WriteLine(tony.defender());


            }
    }
}
