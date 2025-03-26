using apiDoZeroTwo.DataBase;
using apiDoZeroTwo.Models;
using apiDoZeroTwo.Repositorio2.Interface;
using Microsoft.EntityFrameworkCore;

namespace apiDoZeroTwo.Repositorio2
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTarefas _dbContext;
        public UsuarioRepositorio(SistemaTarefas sistemaTarefasDBContext)
        {
            _dbContext = sistemaTarefasDBContext;
            
        }
        public async Task<tarefaModel> BuscarPorId(int id)
        {
           return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<tarefaModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<tarefaModel> Adicionar(tarefaModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }
        public async Task<tarefaModel> Atualizar(tarefaModel usuario, int id)
        {
            tarefaModel usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id}, não foi encontrado");
            }
            else
            {
                usuarioPorId.Name = usuario.Name;
                usuarioPorId.Email = usuario.Email;
                _dbContext.Usuarios.Update(usuarioPorId);
                await _dbContext.SaveChangesAsync();
                return usuarioPorId;
            }
        }

        public async Task<bool> Apagar(int id)
        {
            tarefaModel usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o ID: {id}, não foi encontrado");
            }
            else
            {
               _dbContext.Usuarios.Remove(usuarioPorId);
               await _dbContext.SaveChangesAsync();
               return true;
            }
        }


        
    }
}
