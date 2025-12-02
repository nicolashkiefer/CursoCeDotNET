namespace Aula06
{
    public class Program
    {
        public static void Main()
        {
            //Estrutura Condicional: If-Else

            Console.WriteLine("Digite a sua Idade: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Você é maior de Idade!");
            }else
                Console.WriteLine("Você é menor de Idade!");

            Console.WriteLine("=======Verificador de Par e Ímpares=======");
            Console.WriteLine("Digite um numero: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number%2 == 0)
            {
                Console.WriteLine("O número é PAR!");
            }else
                Console.WriteLine("O Número é ÍMPAR!");

        }
    }
}