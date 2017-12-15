using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    class Common
    {
        private static Random _random = new Random();

        public static int GetEmployeeIndex(int storeIndex)
        {
            switch(storeIndex)
            {
                case 1:
                {
                    return _random.Next(1, 4);
                }
                case 2:
                {
                    return _random.Next(4, 6);
                }
                case 3:
                {
                    return _random.Next(6, 8);
                }
                case 4:
                {
                    return _random.Next(8, 11);
                }
                case 5:
                {
                    return _random.Next(11, 13);
                }
                case 6:
                {
                    return _random.Next(13, 15);
                }
                default:
                {
                    throw new Exception("Not hnadled storre" + storeIndex);
                }
            }

            return 0;
        }

        /// <param name="min">in</param>
        /// <param name="max">in</param>
        /// <returns></returns>
        public static int GetRandInt(int min, int max)
        {
            return _random.Next(min, max + 1);
        }

        public static double GetRandDouble()
        {
            return _random.NextDouble();
        }
    }
}
