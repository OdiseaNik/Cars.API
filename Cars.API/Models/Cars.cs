using Microsoft.AspNetCore.Mvc;

namespace Cars.API.Models
{
    public class Car
    {
        public String Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }


    }
}
