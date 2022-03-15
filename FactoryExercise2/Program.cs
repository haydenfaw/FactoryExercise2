using System;
using System.Threading;

namespace FactoryExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string listType;
            IDataAccess db;
            bool isParseable = false;
            do
            {
                //Console.Clear();
                isParseable = true;
                Console.WriteLine($"What database would you like to use: a List, SQL, or Mongo?");
                listType = Console.ReadLine();
                db = DataAccessFactory.GetDataAccessType(listType);
                if(listType.ToLower() != "sql" && listType != "mongo" && listType != "list" )
                {
                    isParseable = false; 
                    Console.WriteLine($"That input will not work, please type 'list', 'sql', or 'mongo'");
                    Thread.Sleep(1000);
                }
                
            } while (isParseable == false);

            var products = db.LoadData(); 
            db.SaveData();           

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
            }
        }
    }
}
