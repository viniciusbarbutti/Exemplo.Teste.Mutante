using System;

namespace BusinessRules
{
    public class Sorteio
    {
        public string Resultado { get; set; }
        public Sorteio(){}

        public void Sortear(int enteredValued)
        {
            if(enteredValued < 1 || enteredValued > 100)
            // if (!(enteredValued >= 1 && enteredValued <= 100))
            {
                Resultado = "Valor é inválido para o sorteio. Por favor entre com um valor de 1 a 100.";
                Console.WriteLine(Resultado);
            }
            else if ((enteredValued == 40 || enteredValued == 75 || enteredValued == 90))
            {
                Resultado = "Sortudo, Ganhou um carro!!!";
                Console.WriteLine(Resultado);
            }
            else
            {
                Resultado = "Tente novamente, quem sabe você ganha!";
                Console.WriteLine(Resultado);
            }
        }
    }
}
