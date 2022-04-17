using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using Notes.Persistance.EntityTypeConfiguration;
using Notes.Domain;

namespace Notes.Persistance
{
    /// <summary>
    /// Контекст главного домена. Одно из реализаций интерфейса INotesDbContext
    /// </summary>
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get; set; }
        public NotesDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(model);
        }
    }
}
