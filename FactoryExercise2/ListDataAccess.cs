using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "Hamburger", Price = 4},
            new Product(){Name = "Fries", Price = 1.50},
            new Product(){Name = "Cheeseburger", Price = 4.50},
            new Product(){Name = "Soda", Price = 2.99},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from List database");
            return Products;
        }
        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a list database");
        }
    }
}
