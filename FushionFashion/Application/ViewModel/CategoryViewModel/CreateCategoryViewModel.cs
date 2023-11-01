using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel.CategoryViewModel
{
    public class CreateCategoryViewModel
    {
        public string? Name { get; set; }
        public EnumStatus Status { get; set; }
    }
}
