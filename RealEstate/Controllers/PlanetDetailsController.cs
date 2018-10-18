using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Services;
using RealEstate.Models;
using RealEstate.ViewModels;

namespace RealEstate.Controllers
{
    public class PlanetDetailsController : Controller
    {
        readonly IGetPlanetRepository _getPlanetRepository;
        public PlanetDetailsController(IGetPlanetRepository getPlanetRepository)
        {
            _getPlanetRepository = getPlanetRepository;
        }

        public IActionResult Index(int id)
        {
            PlanetObj planet = _getPlanetRepository.GetPlanet(id);
            PlanetDetailsViewModel Planet = new PlanetDetailsViewModel
            {
                Planet = planet
            };
            return View(Planet);
        }
    }
}