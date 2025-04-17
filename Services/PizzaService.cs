using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Services
{
    public class PizzaService
    {
        private readonly static IEnumerable<Pizza> _pizzas = new 
            List<Pizza>
        {
            new Pizza
            {
                Name = "Pizza 1",
                Image = "pizza1.jpg",
                Price = 8.0
            },
            new Pizza
            {
                Name = "Pizza 2",
                Image = "pizza1.jpg",
                Price = 9.5
            },
            new Pizza
            {
                Name = "Pizza 3",
                Image = "pizza1.jpg",
                Price = 10.0
            },
            new Pizza
            {
                Name = "Pizza 4",
                Image = "pizza1.jpg",
                Price = 7.5
            },
            new Pizza
            {
                Name = "Pizza 5",
                Image = "pizza1.jpg",
                Price = 11.0
            },
            new Pizza
            {
                Name = "Pizza 6",
                Image = "pizza1.jpg",
                Price = 12.0
            },
            new Pizza
            {
                Name = "Pizza 7",
                Image = "pizza1.jpg",
                Price = 11.5
            },
            new Pizza
            {
                Name = "Pizza 8",
                Image = "pizza1.jpg",
                Price = 15.0
            },
            new Pizza
            {
                Name = "Pizza 9",
                Image = "pizza1.jpg",
                Price = 3.5
            },
            new Pizza
            {
                Name = "Pizza 10",
                Image = "pizza1.jpg",
                Price = 5.5
            }
        };

        public IEnumerable<Pizza> GetAllPizzas() => _pizzas;
        public IEnumerable<Pizza> GetPopularPizzas(int count = 6) =>
            _pizzas.OrderBy(p => Guid.NewGuid())
                .Take(count);

        public IEnumerable<Pizza> SearchPizzas(string serachTerm) =>
            string.IsNullOrWhiteSpace(serachTerm)
            ? _pizzas
            : _pizzas.Where(p => p.Name.Contains(serachTerm,
                StringComparison.OrdinalIgnoreCase));
    }
}
