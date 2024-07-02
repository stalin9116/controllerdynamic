using ControladoresGenericos.Repositories;
using ControladoresGenericos.Responses;

namespace ControladoresGenericos.UnitsOfWorks
{
    public class GenericUnitOfWork<T> : IGenericUnitOfWork<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenericUnitOfWork(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<ActionResponse<IEnumerable<T>>> Get() => await _repository.Get();

        public virtual async Task<ActionResponse<T>> Get(int id) => await _repository.Get(id);

        public virtual async Task<ActionResponse<T>> Add(T model) => await _repository.Add(model);

        public virtual async Task<ActionResponse<T>> Update(T model) => await _repository.Update(model);

        public virtual async Task<ActionResponse<T>> Delete(int id) => await _repository.Delete(id);


    }
}
