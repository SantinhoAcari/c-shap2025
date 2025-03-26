using apiDoZeroTwo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apiDoZeroTwo.DataBase.Map
{
    public class TarefaMap : IEntityTypeConfiguration<tarefaModel>
    {
        public void Configure(EntityTypeBuilder<tarefaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
            
        }
    }
}
