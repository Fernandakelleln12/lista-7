using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1

            //int totalItens = 0;
            //decimal valorTotal = 0;

            //Console.WriteLine("Bem-vindo ao programa de soma de preços de compras!");

            //while (true)
            //{
            //    Console.Write("Digite a quantidade de itens adquiridos (ou zero para sair): ");
            //    int quantidade = int.Parse(Console.ReadLine());

            //    if (quantidade <= 0)
            //        break;

            //    Console.Write("Digite o preço do produto: ");
            //    decimal preco = decimal.Parse(Console.ReadLine());

            //    totalItens += quantidade;
            //    valorTotal += quantidade * preco;

            //    Console.WriteLine("Produto adicionado com sucesso!\n");
            //}

            //Console.WriteLine("Quantidade total de itens adquiridos: " + totalItens);
            //Console.WriteLine("Valor total da compra: R$" + valorTotal);

            //Console.WriteLine("\nObrigado por utilizar o programa!");
            //Console.ReadKey();

            //exercicio 2
            //string nomeProduto;
            //int quantidade;
            //decimal preco;
            //decimal maxInvestido = decimal.MinValue;
            //decimal minInvestido = decimal.MaxValue;
            //string produtoMaxInvestido = "";
            //string produtoMinInvestido = "";

            //Console.WriteLine("Bem-vindo ao sistema de controle de estoque da Mercearia Bom Preço!");
            //Console.WriteLine("Digite os dados dos produtos. Para encerrar o cadastro, digite 'sair' como nome do produto.");

            //while (true)
            //{
            //    Console.Write("Nome do produto: ");
            //    nomeProduto = Console.ReadLine();

            //    if (nomeProduto.ToLower() == "sair")
            //        break;

            //    Console.Write("Quantidade: ");
            //    quantidade = int.Parse(Console.ReadLine());

            //    Console.Write("Preço: R$");
            //    preco = decimal.Parse(Console.ReadLine());

            //    decimal investido = quantidade * preco;

            //    if (investido > maxInvestido)
            //    {
            //        maxInvestido = investido;
            //        produtoMaxInvestido = nomeProduto;
            //    }

            //    if (investido < minInvestido)
            //    {
            //        minInvestido = investido;
            //        produtoMinInvestido = nomeProduto;
            //    }

            //    Console.WriteLine("Produto cadastrado com sucesso!\n");
            //}

            //Console.WriteLine("=== Relatório de Estoque ===");
            //Console.WriteLine("Produto com maior investimento: {0} (R${1})", produtoMaxInvestido, maxInvestido);
            //Console.WriteLine("Produto com menor investimento: {0} (R${1})", produtoMinInvestido, minInvestido);

            //Console.WriteLine("\nObrigado por utilizar o sistema de controle de estoque!");
            //Console.ReadKey();

            //exercicio 3
            //int numeroAvaliacoes;
            //double somaPesos = 0;

            //Console.WriteLine("Bem-vindo ao sistema de cadastro de pesos de avaliações!");
            //Console.Write("Digite o número de avaliações que você planeja oferecer: ");
            //numeroAvaliacoes = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= numeroAvaliacoes; i++)
            //{
            //    Console.Write("Digite o peso da avaliação {0}: ", i);
            //    double peso = double.Parse(Console.ReadLine());
            //    somaPesos += peso;
            //}

            //Console.WriteLine("\nSoma total dos pesos: {0}", somaPesos);

            //if (somaPesos < 100)
            //    Console.WriteLine("A soma total dos pesos é insuficiente.");
            //else if (somaPesos > 100)
            //    Console.WriteLine("A soma total dos pesos é excedente.");
            //else
            //    Console.WriteLine("A soma total dos pesos é adequada.");

            //Console.WriteLine("\nObrigado por utilizar o sistema de cadastro de pesos de avaliações!");
            //Console.ReadKey();

            //exercicio 4
            //Console.Write("Digite a sigla de um estado: ");
            //string sigla = Console.ReadLine().ToUpper();

            //string nomeEstado;

            //switch (sigla)
            //{
            //    case "AC":
            //        nomeEstado = "Acre";
            //        break;
            //    case "AL":
            //        nomeEstado = "Alagoas";
            //        break;
            //    case "AP":
            //        nomeEstado = "Amapá";
            //        break;
            //    case "AM":
            //        nomeEstado = "Amazonas";
            //        break;
            //    case "BA":
            //        nomeEstado = "Bahia";
            //        break;
            //    case "CE":
            //        nomeEstado = "Ceará";
            //        break;
            //    case "DF":
            //        nomeEstado = "Distrito Federal";
            //        break;
            //    case "ES":
            //        nomeEstado = "Espírito Santo";
            //        break;
            //    case "GO":
            //        nomeEstado = "Goiás";
            //        break;
            //    case "MA":
            //        nomeEstado = "Maranhão";
            //        break;
            //    case "MT":
            //        nomeEstado = "Mato Grosso";
            //        break;
            //    case "MS":
            //        nomeEstado = "Mato Grosso do Sul";
            //        break;
            //    case "MG":
            //        nomeEstado = "Minas Gerais";
            //        break;
            //    case "PA":
            //        nomeEstado = "Pará";
            //        break;
            //    case "PB":
            //        nomeEstado = "Paraíba";
            //        break;
            //    case "PR":
            //        nomeEstado = "Paraná";
            //        break;
            //    case "PE":
            //        nomeEstado = "Pernambuco";
            //        break;
            //    case "PI":
            //        nomeEstado = "Piauí";
            //        break;
            //    case "RJ":
            //        nomeEstado = "Rio de Janeiro";
            //        break;
            //    case "RN":
            //        nomeEstado = "Rio Grande do Norte";
            //        break;
            //    case "RS":
            //        nomeEstado = "Rio Grande do Sul";
            //        break;
            //    case "RO":
            //        nomeEstado = "Rondônia";
            //        break;
            //    case "RR":
            //        nomeEstado = "Roraima";
            //        break;
            //    case "SC":
            //        nomeEstado = "Santa Catarina";
            //        break;
            //    case "SP":
            //        nomeEstado = "São Paulo";
            //        break;
            //    case "SE":
            //        nomeEstado = "Sergipe";
            //        break;
            //    case "TO":
            //        nomeEstado = "Tocantins";
            //        break;
            //    default:
            //        nomeEstado = "Estado inválido";
            //        break;
            //}

            //Console.WriteLine("O estado correspondente à sigla {0} é: {1}", sigla, nomeEstado);
            //Console.ReadKey();  

            //exercicio 5
            //Console.WriteLine("Bem-vindo ao programa de definição de estações do ano!");
            //Console.WriteLine("Por favor, digite um número inteiro entre 1 e 12 representando um mês do ano.");

            //while (true)
            //{
            //    Console.Write("\nDigite um número inteiro (1 a 12): ");
            //    int mes = int.Parse(Console.ReadLine());

            //    string estacao;

            //    switch (mes)
            //    {
            //        case 12:
            //        case 1:
            //        case 2:
            //            estacao = "Verão";
            //            break;
            //        case 3:
            //        case 4:
            //        case 5:
            //            estacao = "Outono";
            //            break;
            //        case 6:
            //        case 7:
            //        case 8:
            //            estacao = "Inverno";
            //            break;
            //        case 9:
            //        case 10:
            //        case 11:
            //            estacao = "Primavera";
            //            break;
            //        default:
            //            Console.WriteLine("Mês inválido! Por favor, digite um número válido entre 1 e 12.");
            //            continue;
            //    }

            //    Console.WriteLine("A estação correspondente ao mês {0} é: {1}", mes, estacao);

            //    if (mes == 3 || mes == 9)
            //    {
            //        Console.Write("Esse mês contém duas estações. Digite '1' para considerar {0} como Primavera ou '2' para considerar como Outono: ", estacao);
            //        int opcao = int.Parse(Console.ReadLine());

            //        if (opcao == 1)
            //            estacao = "Primavera";
            //        else if (opcao == 2)
            //            estacao = "Outono";

            //        Console.WriteLine("A estação definida para o mês {0} é: {1}", mes, estacao);
            //    }

            //    Console.Write("\nDeseja verificar outra estação? (S/N): ");
            //    string resposta = Console.ReadLine();

            //    if (resposta.ToLower() != "s")
            //        break;
            //}

            //Console.WriteLine("\nObrigado por utilizar o programa de definição de estações do ano!");
            //Console.ReadKey();


   

        }
    }
    }

