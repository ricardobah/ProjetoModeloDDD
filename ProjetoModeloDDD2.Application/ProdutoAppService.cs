
using System.Collections.Generic;
using ProjetoModeloDDD2.Application.Interface;
using ProjetoModeloDDD2.Domain.Entities;
using ProjetoModeloDDD2.Domain.Interfaces.Services;

namespace ProjetoModeloDDD2.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
     
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
