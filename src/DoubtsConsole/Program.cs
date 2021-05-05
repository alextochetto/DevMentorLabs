using DoubtsConsole.Service;
using System;
using System.Text;

namespace DoubtsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este projeto tem por objetivo esclarecer dúvidas, porém com uma conotação prática!");
            Console.WriteLine();
            Interpolacao();
            InterpolacaoOutrasFormas();
            InterpolacaoUsandoVAR();
            TryCatch();
            LancarUmaExcecao();
            UsandoAppendLine();
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

        /// <summary>
        /// try é uma tentativa de executar um código
        /// Caso ocorra um erro de alguma execução que estiver dentro do try, a exceção lançada será capturada no catch 
        /// O catch faz o tratamento necessário, mostra para o usuário uma mensagem amigável e continua com a execução do que vem depois
        /// Se você não usar try catch e ocorrer um erro na aplicação, todo o código que estiver depois de onde o erro ocorreu, 
        /// não erá executado e o usuário visualizará uma mensagem de erro não amigável
        /// </summary>
        static void TryCatch()
        {
            Console.WriteLine();
            int a = 2;
            int b = 0;
            decimal resultado;
            try
            {
                resultado = a / b;
                Console.WriteLine("Como um erro ocorreu na linha acima, esta mensagem não deve ser exibida");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Matematicamente uma divisão por zero nào é possível");
                Console.WriteLine($"Esta é a mensagem de erro gerada pelo C#: {ex.Message}");
                Console.WriteLine($"O stacktrace capturado pelo erro ocorrido, mostra o caminho percorrido no código: {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Independente de ocorrer um erro ou não, esta mensagem vai ser exibida");
            }
        }

        /// <summary>
        /// Eu como desenvolvedor, posso lançar uma exceção (erro) forçado através do uso do throw new ...
        /// </summary>
        static void LancarUmaExcecao()
        {
            Console.WriteLine();
            throw new ArgumentOutOfRangeException("Esta exceção foi lançada apenas como exemplo!"); // como parâmetro, eu posso escrever uma mensagem
        }

        /// <summary>
        /// O método AppendLine é da classe StringBuilder
        /// Este método cria um objeto que internamente cria uma linha cada vez que o método for chamado
        /// </summary>
        static void UsandoAppendLine()
        {
            Console.WriteLine();
            StringBuilder report = new StringBuilder();
            report.AppendLine("Linha 1");
            report.AppendLine("Linha 2");
            Console.WriteLine("Abaixo será escrito as linhas inseridas através do AppnedLine");
            Console.WriteLine(report.ToString());
        }

        /// <summary>
        /// Este método é apenas um exemplo de como criar e chamar métodos a partir de um objeto de uma classe
        /// </summary>
        static void UsandoClasseBankAccount()
        {
            BankAccountService banckAccountService = new BankAccountService(); // objecto bankAccount criado
            banckAccountService.RealizarDeposito(); // chamada do método
            banckAccountService.RealizarSaque();
            banckAccountService.RealizarTransferencia();
        }
    }
}
