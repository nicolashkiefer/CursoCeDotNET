namespace Aula03;

public class Program
{
    public static void Main()
    {
        //Constantes
        int number = 30;

        number = 20;

        Console.WriteLine("O valor antigo da variavel é: " + number);

        number = 10;

        Console.WriteLine("O valor novo da variavel é: " + number);

        //=======

        const int numberConst = 1000;

        /**
        Não é possível atribuir número a variável constante
        numberConst = 2000;
        **/

        Console.WriteLine("O valor da constante é: " + numberConst);

        //Variavel diversa, onde a primeira informação inserida é referente a varialvel
        var variable = 200;

        //Não é possível adicionar "Nicolas" pois var foi definido como int
        variable = "Nicolas";

        //Já na variavel dinâmico e sempre levado em conta a última variavel informada.
        dynamic variable2 = 10;

        variable2 = "Nicolas";

    }
}