using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IRandomValues
    {
        public void RandomizeInts();

        

        public int AddFunc { get; }
        public int SubFunc { get; }
        public int MultFunc { get; }
        public int DivFunc { get; }

    }
}
