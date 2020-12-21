using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data.Interfaces
{
    public interface IResults
    {
        IEnumerable<Results> AllResults { get; }
    }
}
