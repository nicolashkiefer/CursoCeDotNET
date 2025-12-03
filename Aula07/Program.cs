namespace Aula07
{
    public class Program
    {
        public static void Main()
        {
            //Operadores de Atribuição
            
            Console.WriteLine("\n========Operadores de Atribuição========");

            //Inicializar a variável
            int x = 10;
            Console.WriteLine("\nValor Inicial da variável: "+x);

            //Operador de Atribuição Simples (=)
            x = 20;
            Console.WriteLine("\nAtribuição Simpres (=)");
            Console.WriteLine("Valor de x: "+x);

            //Operadores de Atribuição Composta Incremento (++)
            x++; // x = x(20) + 1

            Console.WriteLine("\nAtribuição Composta Incremento (++)"); 
            Console.WriteLine("Novo Valor: "+x);

            //Operadores de Atribuição Composta (+=)
            x+=10; // x = x(20) + 10

            Console.WriteLine("\nAtribuição Composta (+=)"); 
            Console.WriteLine("Novo Valor: "+x);

            //Operadores de Atribuição Composta (-=)
            x-=10; // x = x(20) - 10

            Console.WriteLine("\nAtribuição Composta (-=)"); 
            Console.WriteLine("Novo Valor: "+x);

            //Operadores de Atribuição Composta (*=)
            x*=10; // x = x(20) * 10

            Console.WriteLine("\nAtribuição Composta (*=)"); 
            Console.WriteLine("Novo Valor: "+x);

            //Operadores de Atribuição Composta (/=)
            x/=10; // x = x(20) / 10

            Console.WriteLine("\nAtribuição Composta (/=)"); 
            Console.WriteLine("Novo Valor: "+x+"\n");

        }
    }
}
