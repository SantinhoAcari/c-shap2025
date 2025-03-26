using apiDoZeroTwo.Models;

namespace apiDoZeroTwo.Repositorio2.Interface
{
    public interface IUsuarioRepositorio
    {
        Task<List<tarefaModel>> BuscarTodosUsuarios();
        Task<tarefaModel> BuscarPorId(int id);
        Task<tarefaModel> Adicionar(tarefaModel usuario);
        Task<tarefaModel> Atualizar(tarefaModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}
