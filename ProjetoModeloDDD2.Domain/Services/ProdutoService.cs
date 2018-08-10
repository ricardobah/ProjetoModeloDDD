
using System.Collections.Generic;
using ProjetoModeloDDD2.Domain.Entities;
using ProjetoModeloDDD2.Domain.Interfaces.Repositories;
using ProjetoModeloDDD2.Domain.Interfaces.Services;

namespace ProjetoModeloDDD2.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscaPorNome(nome);
        }
    }
}
