using System;
using System.Collections.Generic;

namespace _17_12_2020.classes

{
    public class Carrinho
    {
        public float ValorTotal { get; set; }
        
        List<Produto> listaDeProdutos = new List<Produto>();
        public void AdicionarProduto(Produto produto){
            listaDeProdutos.Add(produto);
        }

        public void RemoverProdutos(Produto produto)
        {
            listaDeProdutos.Remove(produto);
        }
        
        public void MostrarProdutos(){
            if(listaDeProdutos != null){
                foreach (var item in listaDeProdutos)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"R$ {item.Preco.ToString(" n2 ")} - Nome {item.Nome}");
                    Console.ResetColor();
                    
                    
                }
            }else{
                Console.WriteLine($"Nenhum produto cadastrado");
                
            }
        }
        public void AlterarItem(int _codigo, Produto _produtoNovo){
            listaDeProdutos.Find(produto => produto.Codigo == _codigo).Nome = _produtoNovo.Nome;
            listaDeProdutos.Find(produto => produto.Codigo == _codigo).Preco = _produtoNovo.Preco;
        }
    }
}