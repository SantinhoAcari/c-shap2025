using apidozerotwo.models;
using apiDoZeroTwo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apiDoZeroTwo.DataBase.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<TarefaModel>
    {
        public void Configure(EntityTypeBuilder<TarefaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Description).HasMaxLength(1590);
            builder.Property(x => x.Status).IsRequired();
            
        }
    }
}
