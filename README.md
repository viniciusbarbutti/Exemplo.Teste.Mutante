# Exemplo.Teste.Mutante

Implementação da lógica para resolver o problema descrito abaixo, criação dos testes unitários e execução dos testes mutantes utilizando a ferramenta _Stryker_

## Regras de negócio

**DADOS DE ENTRADA:** Informe um número e pressione enter.

**PROCESSAMENTO:**

* **REGRA1:**
    * Os valores possíveis que o usuário pode informar vão de 1 a 100.
    * Caso seja informado um valor fora deste range:
        * **MENSAGEM DE SAÍDA:**  Valor é inválido para o sorteio. Por favor entre com um valor de 1 a 100.

* **REGRA2:**
    * Os valores 40, 75, 90 dão um carro de brinde para o usuário que informar um destes valores no console.
    * Caso o usuário acerte um dos números, devemos exibir a seguinte mensagem para o usuário:
        * **MENSAGEM SAÍDA:** Sortudo, ganhou um carro!!!.
    * Caso contrário, devemos exibir a seguinte mensagem para o usuário:
        * **MENSAGEM DE SAÍDA:** Tente novamente, quem sabe você ganha!

## Execução

1. Execução do Stryker:
Acessar a pasta do projeto _BusinessRulesTest_ e executar o comando

```console
dotnet stryker --reporters "['html']"
```

2. Os resultados da execução dos testes mutantes são localizados no diretório:
```directory
..\BusinessRulesTest\StrykerOutput
