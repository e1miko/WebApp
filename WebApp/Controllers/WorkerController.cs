using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.Interfaces;

namespace WebApp.Controllers
{
    public class WorkerController : Controller
    {
        private readonly INewWorker worker;


        public WorkerController(INewWorker workerNew)
        {
            worker = workerNew;
        }

        public ViewResult Add(string category)
        {
            category = "";
            var results = worker.AllWorkers; //mocka net, potom s db vzjatj
            return View();
        }
    }
}
