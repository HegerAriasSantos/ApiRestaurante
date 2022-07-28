using ApiRestaurante.Core.Application.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.ViewModels.Table
{
    public class TableViewModel:BaseViewModel
    {
        public int Id { get; set; }
        public int MaxDiners { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        #region Navigation Props
        public ICollection<OrderViewModel> Orders { get; set; }
        #endregion
    }
}
