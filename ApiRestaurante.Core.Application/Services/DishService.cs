using ApiRestaurante.Core.Application.Interfaces.Repositories;
using ApiRestaurante.Core.Application.Interfaces.Services;
using ApiRestaurante.Core.Application.ViewModels.Dish;
using ApiRestaurante.Core.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.Services
{
    public class DishService : GenericService<Dish, DishViewModel, SaveDishViewModel>, IDishService
    {
        private readonly IDishRepository _dishRepository;
        private readonly IMapper _mapper;

        public DishService(IDishRepository dishRepository, IMapper mapper) : base(dishRepository, mapper)
        {
            _dishRepository = dishRepository;
            _mapper = mapper;
        }
    }
}
