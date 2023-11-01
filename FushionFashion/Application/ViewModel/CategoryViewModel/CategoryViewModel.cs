using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel.CategoryViewModel
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public EnumStatus Status { get; set; }
    }
}
