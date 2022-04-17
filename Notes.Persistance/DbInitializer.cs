namespace Notes.Persistance
{
    /// <summary>
    /// Класс, создающий при отсутствии базу данных на основе существующего контекста.
    /// </summary>
    public class DbInitializer
    {
        /// <summary>
        /// Метод, создающий БД
        /// </summary>
        /// <param name="context">Контекст главного домена</param>
        public static void Initialize(NotesDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
