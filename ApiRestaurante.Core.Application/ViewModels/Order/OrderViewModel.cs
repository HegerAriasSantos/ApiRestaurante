using ApiRestaurante.Core.Application.ViewModels.Dish;
using ApiRestaurante.Core.Application.ViewModels.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.ViewModels.Order
{
    public class OrderViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public int IdTable { get; set; }
        public double TotalPrice { get; set; }
        public int Status { get; set; }

        #region Navigation Props
        public TableViewModel Table { get; set; }

        public ICollection<DishViewModel> Dishes { get; set; }
        #endregion
    }
}
