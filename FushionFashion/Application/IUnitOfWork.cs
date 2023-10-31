using Application.Repository;

namespace Application
{
    public interface IUnitOfWork
    {
        public IProductRepository ProductRepository { get; }
        public Task<int> SaveChangeAsync();
    }
}
