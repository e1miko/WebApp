using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data.Interfaces
{
    public interface INewWorker
    {
        IEnumerable<INewWorker> newWorker { get; }
    }
}
