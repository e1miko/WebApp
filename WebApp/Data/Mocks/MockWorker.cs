using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.Interfaces;
using WebApp.Models;

namespace WebApp.Data.Mocks
{
    public class MockWorker : INewWorker
    {
       

        public IEnumerable<INewWorker> newWorker
        {
            get
            {
                return new Add<>
                {
                    new NewWorker {Name = "sfh", Surname = "ifhjd"}
                };
            }
        }
    }
}
