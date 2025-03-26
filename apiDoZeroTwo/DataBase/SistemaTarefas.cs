using apidozerotwo.models;
using apiDoZeroTwo.DataBase.Map;
using apiDoZeroTwo.Models;
using Microsoft.EntityFrameworkCore;

namespace apiDoZeroTwo.DataBase
{
    public class SistemaTarefas : DbContext 
    {
        public SistemaTarefas(DbContextOptions<SistemaTarefas> options)
            : base(options)
        {
        {
            public DbSet<TarefaModel> Usuarios { get; set; }
            public DbSet<TarefaModel> tarefas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }

    }
    }
}
