using ControladoresGenericos.Responses;

namespace ControladoresGenericos.UnitsOfWorks
{
    public interface IGenericUnitOfWork<T> where T : class
    {
        Task<ActionResponse<IEnumerable<T>>> Get();
        Task<ActionResponse<T>> Get(int id);

        Task<ActionResponse<T>> Add(T model);

        Task<ActionResponse<T>> Update(T model);

        Task<ActionResponse<T>> Delete(int id);

        
    }
}
