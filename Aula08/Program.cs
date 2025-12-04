namespace Aula08
{
    public class Program
    {
        public static void Main()
        {
            //Operadores Relacionais
            
            Console.WriteLine("=======Operdaores Relacionais=======");
            Console.WriteLine("Digite o primeiro número: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int y = Convert.ToInt32(Console.ReadLine());

            bool condition = x ==y; 

            //Operador de Igualdade (==)
            if(x == y)
            {
                Console.WriteLine("Os dois valores são iguais!");
            }else
                Console.WriteLine("Os dois números são diferentes!");

            //Operador de Diferenã(!=)
            if(x != y)
            {
                Console.WriteLine("Os dois números são diferentes!");
            }else
                Console.WriteLine("Os dois valores são iguais!");

            //Operador Maior que (>)
            if(x > y)
            {
                Console.WriteLine("O valor de "+x+" é Maior!");
            }else
                Console.WriteLine("O valor de "+x+" Não é Maior");

            //Operador Maior que (<)
            if(x < y)
            {
                Console.WriteLine("O valor de "+x+" é Menor!");
            }else
                Console.WriteLine("O valor de "+x+" Não é Menor");

            //Operador Maior ou Igual (>=)
            if(x >= y)
            {
                Console.WriteLine("O valor de "+x+" é Maior ou Igual ao outro valor!");
            }else
                Console.WriteLine("O valor de "+x+" Não é Maior ou Igual ao outro valor!");

            //Operador Menor ou Igual (<=)
            if(x <= y)
            {
                Console.WriteLine("O valor de "+x+" é Menor ou Igual ao outro valor!");
            }else
                Console.WriteLine("O valor de "+x+" Não é Menor ou Igual ao outro valor!");

        }
    }
}