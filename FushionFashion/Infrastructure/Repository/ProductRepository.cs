using Application.Interface;
using Application.Repository;
using Application.Service;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ProductRepository: GenericRepository<Product>, IProductRepository
    {
        private readonly AppDBContext _appDBContext;
        private ICurrentTime _timeService;
        private IClaimService _claimService;

        public ProductRepository(AppDBContext appDBContext, ICurrentTime currentTime,
            IClaimService claimService) : base(appDBContext, currentTime,claimService)
        {
            _appDBContext = appDBContext;
            _timeService = currentTime;
            _claimService = claimService;
        }

        public Task<Product> FindAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
