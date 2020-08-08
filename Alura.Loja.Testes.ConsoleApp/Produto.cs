using System.Collections;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Produto
    {
        public int Id { get;  set; }
        public string Nome { get;  set; }
        public string Categoria { get;  set; }
        public double PrecoUn { get;  set; }
        public string Unidade { get;  set; }
        public IList<PromocaoProduto> Promocao { get; set; }
    }
}