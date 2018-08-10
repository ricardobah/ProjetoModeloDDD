using ProjetoModeloDDD2.Domain.Entities;
using ProjetoModeloDDD2.Domain.Interfaces.Repositories;
using ProjetoModeloDDD2.Infra.Data.Repositories;

namespace ProjetoModeloDDD2.MVC.App_Start
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}