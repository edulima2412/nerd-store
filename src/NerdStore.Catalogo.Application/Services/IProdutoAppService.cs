using NerdStore.Catalogo.Application.ViewModels;

namespace NerdStore.Catalogo.Application.Services
{
    public interface IProdutoAppService : IDisposable
    {
        Task<IEnumerable<ProdutoViewModel>> ObterTodos();
        Task<ProdutoViewModel> ObterPorId(Guid id);
        Task<IEnumerable<ProdutoViewModel>> ObterPorCategoria(int codigo);
        Task<IEnumerable<CategoriaViewModel>> ObterCategorias();

        Task AdicionarProduto(ProdutoViewModel produtoViewModel);
        Task AtualizarProduto(ProdutoViewModel produtoViewModel);

        Task<ProdutoViewModel> DebitarEstoque(Guid produtoId, int quantidade);
        Task<ProdutoViewModel> ReporEstoque(Guid produtoId, int quantidade);
    }
}
