using System;
using System.Globalization;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exibe uma mensagem pedindo o nome completo do usuário
            Console.WriteLine("Entre com o seu nome completo: ");
            // Lê o nome completo digitado pelo usuário
            string nome = Console.ReadLine();

            // Exibe uma mensagem pedindo a quantidade de quartos
            Console.WriteLine("Quantos quartos tem em sua casa?");
            // Lê o número de quartos e converte para inteiro
            int quartos = int.Parse(Console.ReadLine());

            // Exibe uma mensagem pedindo o preço de um produto
            Console.WriteLine("Entre com o preço de um produto: ");
            // Lê o valor e converte para double, respeitando a cultura (ponto como separador decimal)
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Solicita ao usuário que digite sobrenome, idade e altura em uma única linha
            Console.WriteLine("Escreva o seu últimmo nome, idade e altura(na mesma linha) ");
            // Divide a entrada em partes separadas por espaço e armazena em um vetor de strings
            string[] vet = Console.ReadLine().Split(' ');
            // Atribui cada elemento do vetor a uma variável correspondente
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            // Exibe todos os dados formatados de forma organizada
            Console.WriteLine(" Dados digitados: ");
            Console.WriteLine("Nome completo: " + nome);
            Console.WriteLine("Quartos: " + quartos);
            Console.WriteLine("Preço do produto: " + produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Sobrenome: " + sobrenome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
