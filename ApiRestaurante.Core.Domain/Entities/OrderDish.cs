using InternetBanking.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Domain.Entities
{
    public class OrderDish : AuditableBaseEntity
    {
        public int IdDish { get; set; }
        public int IdOrder { get; set; }
        public Dish JDish { get; set; }
        public Order JOrder { get; set; }
    }
}
