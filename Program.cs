using System;
using _17_12_2020.classes;

namespace _17_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(1, "Exemplo", 10);
            Produto produto2 = new Produto(2, "Exemplo 2", 11);
            Produto produto3 = new Produto(3, "Exemplo 3", 12);

            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarProduto(produto1);
            carrinho.AdicionarProduto(produto2);
            carrinho.AdicionarProduto(produto3);

            Produto produtoNovo = new Produto();
            produtoNovo.Nome = "Exemplo Novo";
            produtoNovo.Preco = 500;

            carrinho.AlterarItem(2, produtoNovo);

            carrinho.MostrarProdutos();
        }
    }
}
