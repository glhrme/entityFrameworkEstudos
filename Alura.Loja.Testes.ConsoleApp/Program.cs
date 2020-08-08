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
            var p1 = new Produto()
            {
                Nome = "Suco",
                PrecoUn = 1.5,
                Categoria = "Bebida",
                Unidade = "Litros"
            };
            var promocaoPascoa = new Promocao();
            promocaoPascoa.Descricao = "Pascoa Lek";
            promocaoPascoa.DataInicio = DateTime.Now;
            promocaoPascoa.DataFim = DateTime.Now.AddDays(15);

            promocaoPascoa.IncluiProduto(p1);
            //promocaoPascoa.Produto.Add(new Produto());
            //promocaoPascoa.Produto.Add(new Produto());

            using (var contexto = new LojaContext())
            {
                contexto.Promocoes.Add(promocaoPascoa);
                contexto.SaveChanges();
            }
        }
    }
}
