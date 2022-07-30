using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.ViewModels.OrderDish
{
    public class OrderDishViewModel : BaseViewModel
    {
        public int DishId { get; set; }
        public int OrderId { get; set; }
    }
}
