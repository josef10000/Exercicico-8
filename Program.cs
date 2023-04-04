namespace Exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ler temperatura em Celsius
            Console.Write("Digite a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            // Converter para Fahrenheit
            double fahrenheit = (9 * celsius + 160) / 5;

            // Exibir resultado
            Console.WriteLine("{0} graus Celsius equivalem a {1} graus Fahrenheit", celsius, fahrenheit);

            Console.ReadKey();
        }
    }
}