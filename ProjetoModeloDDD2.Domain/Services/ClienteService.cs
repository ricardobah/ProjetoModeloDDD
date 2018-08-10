

using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD2.Domain.Entities;
using ProjetoModeloDDD2.Domain.Interfaces.Repositories;
using ProjetoModeloDDD2.Domain.Interfaces.Services;

namespace ProjetoModeloDDD2.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
