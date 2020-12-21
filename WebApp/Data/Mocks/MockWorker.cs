using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Data.Interfaces;


namespace WebApp.Data.Mocks
{
    public class MockWorker : INewWorker
    {
        public IEnumerable<NewWorker> AllWorkers {
            get
            {
                return new List<NewWorker>
                {
                    new NewWorker {Name = "sfh", Surname = "ifhjd"}
                };
            }
        }
    }
}
