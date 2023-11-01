using Application.Interface;
using Application.Repository;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Infrastructure.Repository
{
    public class CategoryRepository: GenericRepository<Category>, ICategoryRepository
    {
        private readonly AppDBContext _appDBContext;
        private ICurrentTime _timeService;
        private IClaimService _claimService;

        public CategoryRepository(AppDBContext appDBContext, ICurrentTime currentTime,
            IClaimService claimService) : base(appDBContext, currentTime, claimService)
        {
            _appDBContext = appDBContext;
            _timeService = currentTime;
            _claimService = claimService;
        }

        public Task<Category> FindAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
