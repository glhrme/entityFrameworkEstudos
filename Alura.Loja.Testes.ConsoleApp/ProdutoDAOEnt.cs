using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class ProdutoDAOEnt : IProdutoDAO, IDisposable
    {
        private LojaContext contexto { get; set; }

        public ProdutoDAOEnt()
        {
            contexto = new LojaContext();
        }
        public void AdicionaProduto(Produto produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void EditarProduto(Produto produto)
        {
            contexto.Produtos.Update(produto);
            contexto.SaveChanges();
        }

        public void ExcluirProduto(Produto produto)
        {
            contexto.Produtos.Remove(produto);
            contexto.SaveChanges();
        }

        public IList<Produto> Produtos()
        {
            return contexto.Produtos.ToList();
        }
    }
}
