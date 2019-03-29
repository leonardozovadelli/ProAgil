using System.Threading.Tasks;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public interface iProAgilRepository
    {
         void Add<T> (T entity) where T : class;
         void Update<T> (T entity) where T : class;
         void Delete<T> (T entity) where T : class;

        Task<bool> SaveChangesAsync();

        //EVENTOS
        Task<Evento[]> GetAllEventoAsyncByTema(string Tema, bool includePalestrantes);
        Task<Evento[]> GetAllEventoAsync(bool includePalestrantes);
        Task<Evento> GetEventoAsyncById(int EventoId, bool includePalestrantes);
        Task<Palestrante> GetAllPalestrantesAsyncById(int PalestranteId, bool includeEventos);
        Task<Palestrante[]> GetPalestranteAsyncByName(string Name, bool includeEventos);
        
    }
}