using Microsoft.EntityFrameworkCore;
using Notes.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace Notes.Application.Interfaces
{
    /// <summary>
    /// Главный интерфейс домена для работы с классами контекста.
    /// Служит решением для работы с методами и полями интерфейса, а не классами контекста напрямую
    /// </summary>
    public interface INotesDbContext
    {
        /// <summary>
        /// Classic primary for context
        /// </summary>
        public DbSet<Note> Notes { get; set; }
        /// <summary>
        /// Метод, реализация которого должна выполнятся посредством расширения класса DbContext.
        /// Сохраняет все изменения, внесенные в этом контексте, в базу данных. 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
