using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class DataPass
    {

        Random rnd = new Random();

        public int a = 0;
        public int b = 0;

        public DataPass()
        {
            RandomizeInts();
        }
        public void RandomizeInts()
        {
            a = Math.Abs(rnd.Next() % 100);
            b = Math.Abs(rnd.Next() % 100);
        }

        public int AddFunc
        {
            get
            {
                return a + b;
            }
        }

        public int SubFunc
        {
            get
            {
                return a - b;
            }
        }

        public int MultFunc
        {
            get
            {
                return a * b;
            }
        }

        public string DivFunc
        {
            get
            {
                if (b == 0)
                {
                    return "Divide by 0!";
                }
                    return (a / b).ToString();

            }
        }

        
    }
}
