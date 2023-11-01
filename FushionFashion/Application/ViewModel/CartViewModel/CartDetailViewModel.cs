using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel.CartViewModel
{
    public class CartDetailViewModel
    {
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public Guid CartId { get; set; }
        public Cart? Cart { get; set; }
    }
}
