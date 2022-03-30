using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission13.Models;

namespace mission13.Controllers
{
    public class HomeController : Controller
    {
        private IBowlersRepository _repository { get; set; }

        public HomeController(IBowlersRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var bowlers = _repository.Bowlers.ToList();

            return View(bowlers);
        }
    }
}
