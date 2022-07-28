using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.ViewModels.Order
{
    public class SaveOrderViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Debe proporcionar el Id de la mesa donde se hizo la orden")]
        public int IdTable { get; set; }
        
        [Required(ErrorMessage ="Debe proporcionar el sub total de la orden")]
        public double TotalPrice { get; set; }
        public int Status { get; set; }
    }
}
