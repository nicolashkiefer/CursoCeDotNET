namespace Aula05
{
    public class Program
    {
        public static void Main()
        {
            //Operadores Aritméticos

            Console.WriteLine("=======Calculadora=======");
            Console.WriteLine("Digite o primeiro valor: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

           //Adição
            int sum = number1 + number2;
            Console.WriteLine("O valor da soma é "+sum);

            //Subtração
            int subtraction = number2 - number1;
            Console.WriteLine("O valor da subtração é "+subtraction);

            //Multiplicação
            int multiplication = number1 * number2;
            Console.WriteLine("O valor da multiplicação é "+multiplication);

            //Divição
            int division = number2 / number1;
            Console.WriteLine("O valor da divisão é "+division);

            //Modulo(Resto da divisão)
            int module = number1 % number2;
            Console.WriteLine("O valor do resto da divisão é "+module);

        }    
    }
}