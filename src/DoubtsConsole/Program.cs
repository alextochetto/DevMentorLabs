using System;

namespace DoubtsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este projeto tem por objetivo esclarecer dúvidas, porém com uma conotação prática!");
            Console.WriteLine();
            Interpolacao();
            Console.ReadKey();
        }

        /// <summary>
        /// A interpolação é o processo de criar o resultado como sendo uma string literal,
        /// juntando partes de outros valores
        /// Esta forma de interpolação, usando "$" foi introduzida no C# versão 6 
        /// https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/string-interpolation
        /// </summary>
        static void Interpolacao()
        {
            Console.WriteLine("Primeiro exemplo de interpolação");
            string nome = "Dev Mentor Labs";
            int ano = 2021;
            string resultado = $"O projeto {nome} foi criado no ano de {ano}.";
            Console.WriteLine("Resultado do exemplo de interpolação");
            Console.WriteLine(resultado);

            InterpolacaoOutrasFormas();
        }

        /// <summary>
        /// Este método mostra outras formas de chegar no mesmo resultado do método Interpolacao()
        /// </summary>
        static void InterpolacaoOutrasFormas()
        {
            Console.WriteLine();
            Console.WriteLine("Outras formas de interpolação");
            string nome = "Dev Mentor Labs";
            int ano = 2021;
            string resultado = "O projeto " + nome + " foi criado no ano de " + ano + ".";
            Console.WriteLine("Resultado 1");
            Console.WriteLine(resultado);

            Console.WriteLine();
            resultado = string.Format("O projeto {0} foi criado no ano de {1}.", nome, ano);
            Console.WriteLine("Resultado 2");
            Console.WriteLine(resultado);

            InterpolacaoUsandoVAR();
        }

        /// <summary>
        /// O VAR é apenas uma abastração do tipo da variável
        /// O VAR substitui o int, string, double, etc
        /// Substitui também o nome da classe na criação de um objeto
        /// </summary>
        static void InterpolacaoUsandoVAR()
        {
            Console.WriteLine();
            Console.WriteLine("Interpolação usando VAR como definição de variável");
            var nome = "Dev Mentor Labs";
            var ano = 2021;
            var resultado = $"O projeto {nome} foi criado no ano de {ano}.";
            Console.WriteLine("Resultado do exemplo de interpolação");
            Console.WriteLine(resultado);
        }
    }
}
