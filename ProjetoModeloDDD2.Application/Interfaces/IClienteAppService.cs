
using System.Collections.Generic;
using ProjetoModeloDDD2.Domain.Entities;

namespace ProjetoModeloDDD2.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
