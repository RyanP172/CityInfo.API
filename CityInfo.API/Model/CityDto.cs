﻿namespace CityInfo.API.Model
{
    public class CityDto
    {
        public int Id { get; set; } 
        public string Name { get; set; } = String.Empty;
        public string? Description { get; set; }
    }
}
