using CityInfo.API.Model;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        /// <summary>
        /// The property below is a singleton patern network
        /// It make sure that we work on the same store as long as we don't restart the server
        /// </summary>
        public static CitiesDataStore Current { get; } = new CitiesDataStore();//return an instance of the class

        public CitiesDataStore()
        {
            //Init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park."
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with that cathedral that was never really finished."
                },
                new CityDto()
                {
                    Id = 1,
                    Name = "Paris",
                    Description = "The one with that big iron towel."
                }
            };
        }
    }
}
