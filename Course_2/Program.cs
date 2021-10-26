using System;
using System.Globalization;

namespace Course_2 {
    class Program {
        static void Main(string[] args) {

            //Produto p = new Produto("TV",500.00,10);
            //Console.WriteLine(p);

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto() { Nome = "TV", Preco = 500.00, Quantidade = 20 };
           
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado do estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

        }
    }
}
