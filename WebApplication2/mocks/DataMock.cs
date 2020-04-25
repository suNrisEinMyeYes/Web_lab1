using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using WebApplication2.Services;

namespace WebApplication2.mocks
{
    public class DataMock : IRandomValues
    {
        Random rnd = new Random();

        public int a = 0;
        public int b = 0;

        public DataMock()
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

        public int DivFunc
        {
            get
            {
                return a / b;

            }
        }
        
        public string DivbynullException
        {
            get
            {
                return "Divide by 0!";
            }
        }
        
    }
}
