using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.ViewModels.IngredientDish
{
    public class IngredientDishViewModel : BaseViewModel
    {
        public int DishId { get; set; }
        public int IngredientId { get; set; }
    }
}
