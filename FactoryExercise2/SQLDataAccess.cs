using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "Xbox", Price = 350},
            new Product(){Name = "Playstation", Price = 399},
            new Product(){Name = "Blender", Price = 50},
            new Product(){Name = "Laptop", Price = 1999},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from SQL database");
            return Products;
        }
        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a SQL database");
        }
    }
}
