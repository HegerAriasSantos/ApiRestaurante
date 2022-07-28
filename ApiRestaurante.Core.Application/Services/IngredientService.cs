using ApiRestaurante.Core.Application.Interfaces.Repositories;
using ApiRestaurante.Core.Application.Interfaces.Services;
using ApiRestaurante.Core.Application.ViewModels.Dish;
using ApiRestaurante.Core.Application.ViewModels.Ingredient;
using ApiRestaurante.Core.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.Services
{
    public class IngredientService : GenericService<Ingredient, IngredientViewModel, SaveIngredientViewModel>, IIngredientService
    {
        private readonly IIngredientRepository _ingRepository;
        private readonly IMapper _mapper;

        public IngredientService(IIngredientRepository ingRepository, IMapper mapper) : base(ingRepository, mapper)
        {
            _ingRepository = ingRepository;
            _mapper = mapper;
        }
    }
}
