using System.Collections.Generic;
using ProjetoModeloDDD2.Domain.Entities;

namespace ProjetoModeloDDD2.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
