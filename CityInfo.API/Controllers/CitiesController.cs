using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]//this is what we pass in as the routing template
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        /// <summary>
        /// JsonResult class return data as Json object
        /// </summary>
        /// <returns></returns>
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(
                CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
        }
    }
}
