using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Data.Interfaces;

namespace WebApp.Data.Mocks
{
    public class MockResults : IResults
    {
      
        public IEnumerable<Results> AllResults
        {
            get
            {
                return new List<Results>
                {
                    new Results{Name = "sfh", Surname = "ifhjd"}
                };
            }
        }
    }
}
