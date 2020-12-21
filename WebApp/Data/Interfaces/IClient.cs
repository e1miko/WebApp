using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data.Interfaces
{
    interface IClient
    {
        IEnumerable<Client> AllClients { get; set; }
    }
}
