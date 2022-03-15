using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise2
{
    public class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "Notebook", Price = 2.99},
            new Product(){Name = "Stapler", Price = 15.99},
            new Product(){Name = "Pencils", Price = 4.99},
            new Product(){Name = "Whiteboard", Price = 9.99},
        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from mongo database");
            return Products;
        }
        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a mongo database");
        }
    }
}
