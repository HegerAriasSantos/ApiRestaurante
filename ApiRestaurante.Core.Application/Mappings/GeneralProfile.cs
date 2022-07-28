using ApiRestaurante.Core.Application.DTOs.User;
using ApiRestaurante.Core.Application.ViewModels.Dish;
using ApiRestaurante.Core.Application.ViewModels.Ingredient;
using ApiRestaurante.Core.Application.ViewModels.Order;
using ApiRestaurante.Core.Application.ViewModels.Table;
using ApiRestaurante.Core.Application.ViewModels.User;
using ApiRestaurante.Core.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.Mappings
{
    public class GeneralProfile:Profile
    {
        public GeneralProfile()
        {
            CreateMap<RegisterResponse, UserViewModel>()
                .ReverseMap();

            CreateMap<RegisterRequest, SaveUserViewModel>()
                .ForMember(d => d.HasError, o => o.Ignore())
                .ForMember(d => d.Error, o => o.Ignore())
                .ReverseMap();

            CreateMap<Dish, SaveDishViewModel>()
                .ForMember(d => d.HasError, o => o.Ignore())
                .ForMember(d => d.Error, o => o.Ignore())
                .ForMember(d => d.IngredientIds, o => o.Ignore())
                .ReverseMap()
                .ForMember(d => d.Created, o => o.Ignore())
                .ForMember(d => d.CreatedBy, o => o.Ignore())
                .ForMember(d => d.Modified, o => o.Ignore())
                .ForMember(d => d.ModifiedBy, o => o.Ignore())
                .ForMember(d => d.Ingredients, o => o.Ignore())
                .ForMember(d => d.IngredientDishes, o => o.Ignore())
                .ForMember(d => d.Orders, o => o.Ignore())
                .ForMember(d => d.OrderDishes, o => o.Ignore())
                ;

            CreateMap<Dish, DishViewModel>()
                .ForMember(d => d.HasError, o => o.Ignore())
                .ForMember(d => d.Error, o => o.Ignore())
                .ReverseMap()
                .ForMember(d => d.Created, o => o.Ignore())
                .ForMember(d => d.CreatedBy, o => o.Ignore())
                .ForMember(d => d.Modified, o => o.Ignore())
                .ForMember(d => d.ModifiedBy, o => o.Ignore())
                .ForMember(d => d.IngredientDishes, o => o.Ignore())
                .ForMember(d => d.OrderDishes, o => o.Ignore())
                ;

            CreateMap<Ingredient, SaveIngredientViewModel>()
                .ForMember(d => d.HasError, o => o.Ignore())
                .ForMember(d => d.Error, o => o.Ignore())
                .ReverseMap()
                .ForMember(d => d.Created, o => o.Ignore())
                .ForMember(d => d.CreatedBy, o => o.Ignore())
                .ForMember(d => d.Modified, o => o.Ignore())
                .ForMember(d => d.ModifiedBy, o => o.Ignore())
                .ForMember(d => d.IngredientDishes, o => o.Ignore())
                .ForMember(d => d.Dishes, o => o.Ignore())
                ;

            CreateMap<Ingredient, IngredientViewModel>()
                .ForMember(d => d.HasError, o => o.Ignore())
                .ForMember(d => d.Error, o => o.Ignore())
                .ReverseMap()
                .ForMember(d => d.Created, o => o.Ignore())
                .ForMember(d => d.CreatedBy, o => o.Ignore())
                .ForMember(d => d.Modified, o => o.Ignore())
                .ForMember(d => d.ModifiedBy, o => o.Ignore())
                .ForMember(d => d.IngredientDishes, o => o.Ignore())
                ;

            CreateMap<Order, SaveOrderViewModel>()
                .ForMember(d => d.HasError, o => o.Ignore())
                .ForMember(d => d.Error, o => o.Ignore())
                .ReverseMap()
                .ForMember(d => d.Created, o => o.Ignore())
                .ForMember(d => d.CreatedBy, o => o.Ignore())
                .ForMember(d => d.Modified, o => o.Ignore())
                .ForMember(d => d.ModifiedBy, o => o.Ignore())
                .ForMember(d => d.Table, o => o.Ignore())
                .ForMember(d => d.Dishes, o => o.Ignore())
                .ForMember(d => d.OrderDishes, o => o.Ignore())
                ;

            CreateMap<Order, OrderViewModel>()
                .ForMember(d => d.HasError, o => o.Ignore())
                .ForMember(d => d.Error, o => o.Ignore())
                .ReverseMap()
                .ForMember(d => d.Created, o => o.Ignore())
                .ForMember(d => d.CreatedBy, o => o.Ignore())
                .ForMember(d => d.Modified, o => o.Ignore())
                .ForMember(d => d.ModifiedBy, o => o.Ignore())
                .ForMember(d => d.OrderDishes, o => o.Ignore())
                ;

            CreateMap<Table, SaveTableViewModel>()
                .ForMember(d => d.HasError, o => o.Ignore())
                .ForMember(d => d.Error, o => o.Ignore())
                .ReverseMap()
                .ForMember(d => d.Created, o => o.Ignore())
                .ForMember(d => d.CreatedBy, o => o.Ignore())
                .ForMember(d => d.Modified, o => o.Ignore())
                .ForMember(d => d.ModifiedBy, o => o.Ignore())
                .ForMember(d => d.Orders, o => o.Ignore())
                ;

            CreateMap<Table, TableViewModel>()
                .ForMember(d => d.HasError, o => o.Ignore())
                .ForMember(d => d.Error, o => o.Ignore())
                .ReverseMap()
                .ForMember(d => d.Created, o => o.Ignore())
                .ForMember(d => d.CreatedBy, o => o.Ignore())
                .ForMember(d => d.Modified, o => o.Ignore())
                .ForMember(d => d.ModifiedBy, o => o.Ignore())
                ;


        }
    }
}
