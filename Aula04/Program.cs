namespace Aula04;

public class Program
{
    public static void Main()
    {
        //Output de dados
        Console.WriteLine("Saída!");

        Console.WriteLine("--------Cadastro de Usuário--------");

        //Solicitar o nome
        Console.WriteLine("Digite seu nome: ");
        string name = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Nome do Usuário: "+ name);
        Console.WriteLine("Idade do Usuário: "+ age);

    }
}