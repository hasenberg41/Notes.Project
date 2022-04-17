using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using Notes.Persistance.EntityTypeConfiguration;
using Notes.Domain;

namespace Notes.Persistance
{
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
