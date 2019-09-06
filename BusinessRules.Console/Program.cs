using System;
using BusinessRules;

namespace BusinessRules.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe um número e pressione enter:");
            var enteredValued = Convert.ToInt32(System.Console.ReadLine());

            var sorteio = new Sorteio();
            sorteio.Sortear(enteredValued);
        }
    }
}
