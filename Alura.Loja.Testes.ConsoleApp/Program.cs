using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Nome = "Pão Francês";
            p.Categoria = "Padaria";
            p.PrecoUn = 0.5;
            p.Unidade = "Unidade";

            var compra = new Compra();
            compra.Quantidade = 10;
            compra.Produto = p;
            compra.Preco = p.PrecoUn * compra.Quantidade;

            using(var contexto = new LojaContext())
            {
                contexto.Produtos.Add(p);
                contexto.Compras.Add(compra);
                contexto.SaveChanges();
            }
        }
    }
}
