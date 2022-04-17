using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notes.Domain;

namespace Notes.Persistance.EntityTypeConfiguration
{
    /// <summary>
    /// Конфигурационный класс главного домена
    /// </summary>
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(n => n.Id);
            builder.HasIndex(n => n.Id).IsUnique();
            builder.Property(n => n.Title).HasMaxLength(250);
        }
    }
}
