using CarInventoryREST.DbModel;
using CarInventoryREST.Models;
using CarInventoryREST.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarInventoryREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarInventoryController : ControllerBase

    {
        private readonly ApplicationDbContext dbContext;

        public CarInventoryController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetCars() 
        {
            var allCars = dbContext.Cars.ToList();

            return Ok(allCars); 
        
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetCarsById(Guid id) 
        { 
            
           var car = dbContext.Cars.Find(id);

            if (car == null)
            {

                return BadRequest();
            }

            return Ok(car);
        
        }

        [HttpPost]

        public IActionResult AddCars(AddCars addCars)
        {
            var carEntity = new Cars()
            {
                ModelId = addCars.ModelId,
                YearId = addCars.YearId,
                Color = addCars.Color,
                EngineId = addCars.EngineId,


            };

            dbContext.Cars.Add(carEntity);
            dbContext.SaveChanges();

            return Ok(carEntity);   
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateCars(Guid id, UpdatsCars updatsCars) 
        {
            var car = dbContext.Cars.Find(id);

            if (car == null)
            {
                return BadRequest();
            }
            
            car.ModelId = updatsCars.ModelId;  
            car.YearId = updatsCars.YearId;
            car.Color = updatsCars.Color;   
            car.EngineId = updatsCars.EngineId;

            dbContext.SaveChanges();


            return Ok(car);
        }

        [HttpDelete]
        [Route("{id:guid}")]

        public IActionResult DeleteCars(Guid id)
        {
            var car = dbContext.Cars.Find(id);

            if (car == null) 
            {
                return NotFound();
            }

            dbContext.Cars.Remove(car);

            dbContext.SaveChanges();

            return Ok(car);
        }

    }
}
