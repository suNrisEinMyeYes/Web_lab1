using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.mocks
{
    public class DataMock : IRandomValues
    {
        public DataPass data { get; set; } = new DataPass();
        
        
    }
}
