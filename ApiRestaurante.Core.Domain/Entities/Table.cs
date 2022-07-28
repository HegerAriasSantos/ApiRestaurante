using InternetBanking.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Domain.Entities
{
    public class Table:AuditableBaseEntity
    {
        public int MaxDiners { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        #region Navigation Props
        public ICollection<Order> Orders { get; set; }
        #endregion
    }
}
