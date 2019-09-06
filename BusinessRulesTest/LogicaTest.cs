using System;
using BusinessRules;
using FluentAssertions;
using Xunit;

namespace BusinessRulesTest
{
    public class LogicaTest
    {
        [Fact]
        public void Verificar_Valor_Menor_Que_Um()
        {
            // Arrange
               var sorteio = new Sorteio(); 
               var resultadoEsperado = "Valor é inválido para o sorteio. Por favor entre com um valor de 1 a 100.";
            // Act
               sorteio.Sortear(-1); 
            // Assert
            sorteio.Resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void Verificar_Valor_Maior_Que_Cem()
        {
            // Arrange
               var sorteio = new Sorteio(); 
               var resultadoEsperado = "Valor é inválido para o sorteio. Por favor entre com um valor de 1 a 100.";
            // Act
               sorteio.Sortear(101); 
            // Assert
            sorteio.Resultado.Should().Be(resultadoEsperado);
        }
        [Fact]
        public void Verificar_Valor_Sorteado_Quarenta()
        {
            // Arrange
               var sorteio = new Sorteio(); 
               var resultadoEsperado = "Sortudo, Ganhou um carro!!!";
            // Act
               sorteio.Sortear(40); 
            // Assert
            sorteio.Resultado.Should().Be(resultadoEsperado);
        }

        [Fact]
        public void Verificar_Valor_Sorteado_Igua_Um()
        {
            // Arrange
               var sorteio = new Sorteio(); 
               var resultadoEsperado = "Tente novamente, quem sabe você ganha!";
            // Act
               sorteio.Sortear(1); 
            // Assert
            sorteio.Resultado.Should().Be(resultadoEsperado);
        }

                [Fact]
        public void Verificar_Valor_Sorteado_Igua_Cem()
        {
            // Arrange
               var sorteio = new Sorteio(); 
               var resultadoEsperado = "Tente novamente, quem sabe você ganha!";
            // Act
               sorteio.Sortear(100); 
            // Assert
            sorteio.Resultado.Should().Be(resultadoEsperado);
        }
    }
}
