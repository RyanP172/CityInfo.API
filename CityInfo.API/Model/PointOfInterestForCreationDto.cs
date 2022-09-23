using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Model
{
    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage ="You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; } = String.Empty;
        [MaxLength(200)]
        public string? Description { get; set; }
        // Also need to check if all the rules adhere to
        // This can be done by [Apicontroller]
    }
}
