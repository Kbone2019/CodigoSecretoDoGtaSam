using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Coisas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produtop;
            double precop = 0;
            int quantidade = 0;
            int escolha = 0;
            double res = 0;
            int p0 = 0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            
            List<string> produto = new List<string>();
            List<double> preco = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Cadastre um Produto para Vender: ");
                produtop = Console.ReadLine();
                produto.Add(produtop);
                Console.WriteLine("Coloque um Preço para este Produto: ");
                precop = double.Parse(Console.ReadLine());
                preco.Add(precop);
                Console.Clear();
                Console.WriteLine($"!{produtop} com o preço de {precop} adicionado!");
                //Thread.Sleep(2000);
            }
            Console.Clear();
            Console.WriteLine($"1 = {produto[0]} R${preco[0]:F2}");
            Console.WriteLine($"2 = {produto[1]} R${preco[1]:F2}");
            Console.WriteLine($"3 = {produto[2]} R${preco[2]:F2}");
            Console.WriteLine($"4 = {produto[3]} R${preco[3]:F2}");
            Console.WriteLine($"5 = {produto[4]} R${preco[4]:F2}");
            Console.WriteLine($"-1 = finalizar a compra");
            escolha = int.Parse(Console.ReadLine());
            escolha = escolha - 1;
            while (escolha != -2)
            {
                Console.WriteLine("Qual a quantidade?");
                quantidade = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 0:
                        p0+=quantidade;
                        res += quantidade * preco[escolha];
                        break;
                    case 1:
                        p1+=quantidade;
                        res += quantidade * preco[escolha];
                        break;
                    case 2:
                        p2+=quantidade;
                        res += quantidade * preco[escolha];
                        break;
                    case 3:
                        p3+=quantidade;
                        res += quantidade * preco[escolha];
                        break;
                    case 4:
                        p4+=quantidade;
                        res += quantidade * preco[escolha];
                        break;
                }
                    
            Console.Clear();
            Console.WriteLine($"1 = {produto[0]} R${preco[0]:F2}");
            Console.WriteLine($"2 = {produto[1]} R${preco[1]:F2}");
            Console.WriteLine($"3 = {produto[2]} R${preco[2]:F2}");
            Console.WriteLine($"4 = {produto[3]} R${preco[3]:F2}");
            Console.WriteLine($"5 = {produto[4]} R${preco[4]:F2}");
            Console.WriteLine($"-1 = finalizar a compra");
            escolha = int.Parse(Console.ReadLine());
            escolha = escolha - 1;

            }
            Console.Clear();
            Console.WriteLine("o valor total a pagar é: ");
            Console.WriteLine($"R$ {res:F2}");
            Console.WriteLine("você comprou");
            Console.WriteLine($"{p0} {produto[0]}");
            Console.WriteLine($"{p1} {produto[1]}");
            Console.WriteLine($"{p2} {produto[2]}");
            Console.WriteLine($"{p3} {produto[3]}");
            Console.WriteLine($"{p4} {produto[4]}");
            Console.ReadKey();
        }
    }
}
