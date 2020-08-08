using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    interface IProdutoDAO
    {
        void ExcluirProduto(Produto produto);
        void AdicionaProduto(Produto produto);
        void EditarProduto(Produto produto);
        IList<Produto> Produtos();
    }
}
