using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Application.Repository
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category> FindAsync(Guid id);
    }
}
