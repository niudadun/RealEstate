using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;
using RealEstate.Services;
using RealEstate.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RealEstate.Controllers
{
    public class PlanetsController : Controller
    {
        readonly IGetPlanetRepository _getPlanetRepository;
        public PlanetsController(IGetPlanetRepository getPlanetRepository)
        {
            _getPlanetRepository = getPlanetRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            PlanetViewModel planets = _getPlanetRepository.GetAvailablePlanetsFromDB();
            return View(planets);
        }
    }
}
