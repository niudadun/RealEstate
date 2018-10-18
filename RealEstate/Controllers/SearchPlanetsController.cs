using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Services;
using RealEstate.ViewModels;

namespace RealEstate.Controllers
{
    public class SearchPlanetsController : Controller
    {
        readonly IGetPlanetRepository _getPlanetRepository;
        public SearchPlanetsController(IGetPlanetRepository getPlanetRepository)
        {
            _getPlanetRepository = getPlanetRepository;
        }
        public IActionResult Index()
        {
            PlanetViewModel planets = _getPlanetRepository.GetAvailablePlanetsFromDB();
            return View(planets);
        }
    }
}