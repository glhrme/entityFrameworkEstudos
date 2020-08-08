using System;
using System.Collections;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Promocao
    {
        public int Id { get; internal set; }
        public DateTime DataFim { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public string Descricao { get; internal set; }
        public IList<PromocaoProduto> Produto { get; set; }

        public Promocao()
        {
            this.Produto = new List<PromocaoProduto>();
        }

        public void IncluiProduto(Produto produto)
        {
            this.Produto.Add(new PromocaoProduto()
            {
                Produto = produto
            });
        }
    }
}