using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.Interfaces;

namespace WebApp.Controllers
{
    public class ResultsController : Controller
    {
        private readonly IResults contrResults;
        private readonly IClient contrClient;


        public ResultsController(IResults resultcontr)
        {
            contrResults = resultcontr;
        }
        
        public ViewResult List(string category)
        {
            category = "";
           var results = contrResults.AllResults; //mocka net, potom s db vzjatj
            return View();
        }
    }
}
