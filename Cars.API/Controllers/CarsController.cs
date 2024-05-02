using System.Reflection;
using Cars.API.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cars.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet("All")]
        public IActionResult GetCars()
        {
        
            var allCars = new List<Cars.API.Models.Car>()
            {
                new Cars.API.Models.Car()
                {
                    Brand = "Mercedes",
                    Model = "E class",
                    Price = 10000,
                    Year = 2020,
       

                },
                new Cars.API.Models.Car()
                {
                    Brand = "Audi",
                    Model = "A6",
                    Price = 15000,
                    Year = 2019,
                },
                new Cars.API.Models.Car()
                {
                    Brand = "Volkwagen",
                    Model = "Golf",
                    Price = 9000,
                    Year = 2013,
                },
                new Cars.API.Models.Car()
                {
                    Brand = "Ford",
                    Model = "Focus",
                    Price = 4500,
                    Year = 2012,
                },

            };

            return Ok(allCars);
        }

        [HttpGet("Brand")]
        public IActionResult GetCarByBrand(string Brand)
        
        
        {
            var newCar = new Models.Car()
            {
                Brand = "Mercedes",
                Model = "E class",
                Price = 10000,
                Year = 2020,
            };
            
           

            return Ok(newCar);
        }

        [HttpGet("Model")]
        public IActionResult GetCarByModel(string Model)


        {
            var newCar = new Models.Car()
            {
                Brand = "Audi",
                Model = "A6",
                Price = 15000,
                Year = 2019,
            };



            return Ok(newCar);
        }

        [HttpPost("Brand")]
        public IActionResult AddNewCar([FromBody] PostCarsDto payload)
        {
            return Ok(payload);
        }


        [HttpPut("Model")]
        public IActionResult UpdateCar([FromBody] PutCarsDto payload, int Model)
        {
            return Ok(payload);
        }

        [HttpPut("Brand")]
        public IActionResult UpdateCar([FromBody] PutCarsDto payload, string Brand)
        {
            return Ok(payload);
        }


        [HttpDelete("Brand")]
        public IActionResult DeleteBrand(int Brand)
        {
            return Ok();
        }

        [HttpDelete("Model")]
        public IActionResult DeleteModel(int Brand)
        {
            return Ok();
        }

    }
}
   
