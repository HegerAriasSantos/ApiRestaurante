using ApiRestaurante.Core.Application.ViewModels.Dish;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.ViewModels.Ingredient
{
    public class SaveIngredientViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe proporcionar un nombre para el ingrediente")]
        public string Name { get; set; }
    }
}
