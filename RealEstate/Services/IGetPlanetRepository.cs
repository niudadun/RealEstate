using RealEstate.Models;
using RealEstate.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Services
{
    public interface IGetPlanetRepository
    {
        /// <summary>
        /// Get all available planets in database.
        /// </summary>
        /// <returns>A list of planet details</returns>
        PlanetViewModel GetAvailablePlanetsFromDB();

        /// <summary>
        /// Get a planet based on planet name in database.
        /// </summary>
        /// <param name="name">planet name</param>
        /// <returns>a object of planet</returns>
        PlanetObj GetPlanet(int id);
    }
}
