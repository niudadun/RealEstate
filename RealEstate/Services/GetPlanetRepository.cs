using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using RealEstate.Models;
using RealEstate.ViewModels;

namespace RealEstate.Services
{
    public class GetPlanetRepository : IGetPlanetRepository
    {
        
        private readonly DBContext _dBcontext;

        public GetPlanetRepository(DBContext dBContext)
        {
            _dBcontext = dBContext;
        }

        public PlanetViewModel GetAvailablePlanetsFromDB()
        {
            PlanetViewModel planetViewModel = new PlanetViewModel();
            try
            {
                
                planetViewModel.Planets = _dBcontext.PlanetObjs
                                        .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return planetViewModel;
        }

        public PlanetObj GetPlanet(int id)
        {
            PlanetObj planet = new PlanetObj();
            try
            {
                planet = _dBcontext.PlanetObjs.Where(i => i.PlanetObjId == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return planet;
        }

    }
}
