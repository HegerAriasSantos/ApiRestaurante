using ApiRestaurante.Infrastructure.Persistence.Contexts;
using ApiRestaurante.Core.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiRestaurante.Core.Domain.Entities;

namespace ApiRestaurante.Infrastructure.Persistence.Repositories
{
    public class IngredientDishRepository : GenericRepository<IngredientDish>, IIngredientDishRepository
    {
        private readonly RestaurantContext _dbContext;

        public IngredientDishRepository(RestaurantContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
