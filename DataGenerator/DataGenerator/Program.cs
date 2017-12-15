using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    class Program
    {
        private static Random _random;

        static void Main(string[] args)
        {
            MakeSimulation(InsertIntoHistory.FactArray());
            Console.ReadLine();
        }

        private static DateTime RandomDay()
        {
            DateTime start = new DateTime(2014, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(_random.Next(range));
        }

        private static void MakeSimulation(object[,] array)
        {
            for(int j = 0; j < array.Length; j++)
            {
                _random = new Random();
                int product = int.Parse(array[j, 0].ToString());
                float productPrice = float.Parse(array[j, 1].ToString());
                Queries queries = new Queries();
                int rand = Common.GetRandInt(40, 100);
                for (int i = 0; i < rand; i++)
                {
                    queries.CreateFact(productId: product, price: productPrice, quantity: Common.GetRandInt(10, 30), date: RandomDay());
                }
            }

            return;
        }
    }
}
