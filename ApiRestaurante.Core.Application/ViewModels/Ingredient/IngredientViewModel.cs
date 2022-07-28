using ApiRestaurante.Core.Application.ViewModels.Dish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.ViewModels.Ingredient
{
    public class IngredientViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<DishViewModel> Dishes { get; set; }
    }
}
