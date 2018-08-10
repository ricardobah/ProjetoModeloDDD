
using System.Collections.Generic;
using ProjetoModeloDDD2.Domain.Entities;

namespace ProjetoModeloDDD2.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
