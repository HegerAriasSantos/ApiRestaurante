using InternetBanking.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Domain.Entities
{
    public class IngredientDish : AuditableBaseEntity
    {
        public int IdDish { get; set; }
        public int IdIngredient { get; set; }
        public Dish JDish { get; set; }
        public Ingredient JIngredient { get; set; }
    }
}
