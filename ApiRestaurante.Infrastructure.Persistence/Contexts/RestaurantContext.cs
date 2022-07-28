using ApiRestaurante.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Infrastructure.Persistence.Contexts
{
    public class RestaurantContext:DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) { }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(ModelBuilder m)
        {
            #region Tables
            m.Entity<Dish>().ToTable("Dishes");
            m.Entity<Ingredient>().ToTable("Ingredients");
            m.Entity<Order>().ToTable("Orders");
            m.Entity<Table>().ToTable("Tables");
            #endregion

            #region Keys
            m.Entity<Dish>().HasKey(t => t.Id);
            m.Entity<Ingredient>().HasKey(t => t.Id);
            m.Entity<Order>().HasKey(t => t.Id);
            m.Entity<Table>().HasKey(t => t.Id);
            #endregion

            #region Relations
            //Table-Orders
            m.Entity<Table>()
                .HasMany<Order>(table => table.Orders)
                .WithOne(order => order.Table)
                .HasForeignKey(order => order.IdTable)
                .OnDelete(DeleteBehavior.Cascade);

            //Ingredients-Dishes
            m.Entity<Ingredient>()
                .HasMany(ing => ing.Dishes)
                .WithMany(dish => dish.Ingredients)
                .UsingEntity<IngredientDish>(
                    j => j
                        .HasOne(ingdish => ingdish.JDish)
                        .WithMany(ing => ing.IngredientDishes)
                        .HasForeignKey(ingdish => ingdish.IdDish),
                    j => j
                        .HasOne(ingdish => ingdish.JIngredient)
                        .WithMany(dish => dish.IngredientDishes)
                        .HasForeignKey(ingdish => ingdish.IdIngredient),
                    j =>
                    {
                        j.ToTable("IngredientDish");
                        j.HasKey(t => new { t.IdDish, t.IdIngredient });
                    }
                );

            //Orders-Dishes
            m.Entity<Order>()
                .HasMany(ord => ord.Dishes)
                .WithMany(dish => dish.Orders)
                .UsingEntity<OrderDish>(
                    j => j
                        .HasOne(ordish => ordish.JDish)
                        .WithMany(ord => ord.OrderDishes)
                        .HasForeignKey(ordish => ordish.IdDish),
                    j => j
                        .HasOne(ordish => ordish.JOrder)
                        .WithMany(dish => dish.OrderDishes)
                        .HasForeignKey(ordish => ordish.IdOrder),
                    j =>
                    {
                        j.ToTable("OrderDish");
                        j.HasKey(t => new { t.IdDish, t.IdOrder });
                    }
                );
            #endregion

            #region Props

            #region Dish
            m.Entity<Dish>().Property(t => t.Name).IsRequired();
            m.Entity<Dish>().Property(t => t.Price).IsRequired();
            m.Entity<Dish>().Property(t => t.People).IsRequired();
            m.Entity<Dish>().Property(t => t.Category).IsRequired();
            #endregion

            #region Ingredient
            m.Entity<Ingredient>().Property(t => t.Name).IsRequired();
            #endregion

            #region Order
            m.Entity<Order>().Property(t => t.IdTable).IsRequired();
            m.Entity<Order>().Property(t => t.TotalPrice).IsRequired();
            m.Entity<Order>().Property(t => t.Status).IsRequired();
            #endregion

            #region Table
            m.Entity<Table>().Property(t => t.MaxDiners).IsRequired();
            m.Entity<Table>().Property(t => t.Description).IsRequired();
            m.Entity<Table>().Property(t => t.Status).IsRequired();
            #endregion

            #endregion
        }
    }
}
