﻿using CityInfo.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]//this is what we pass in as the routing template
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        
        
        
        public ActionResult<IEnumerable<CityDto>> GetCities()
            
        {
            return Ok(CitiesDataStore.Current.Cities);
        }
        
        [HttpGet("{id}")]
        public ActionResult<CityDto>GetCity(int id)
        {
            //find city
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);

            if (cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);

            
        }
    }
}
