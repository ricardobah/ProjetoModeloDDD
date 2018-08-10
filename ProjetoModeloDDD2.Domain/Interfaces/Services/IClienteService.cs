
using System.Collections.Generic;
using ProjetoModeloDDD2.Domain.Entities;

namespace ProjetoModeloDDD2.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
