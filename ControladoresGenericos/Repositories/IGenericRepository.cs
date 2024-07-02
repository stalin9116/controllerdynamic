using ControladoresGenericos.Responses;

namespace ControladoresGenericos.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<ActionResponse<T>> Get(int id);

        Task<ActionResponse<IEnumerable<T>>> Get();

        Task<ActionResponse<T>> Add(T entity);

        Task<ActionResponse<T>> Update(T entity);

        Task<ActionResponse<T>> Delete(int id);


    }
}
