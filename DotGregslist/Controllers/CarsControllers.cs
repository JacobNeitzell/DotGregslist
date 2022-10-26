namespace DotGregslist.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CarsController : ControllerBase
{
  private readonly CarsService _carsService;

  public CarsController(CarsService carsService)
  {
    _carsService = carsService;
  }

  [HttpGet]

  public ActionResult<List<Car>> GetCars()
  {
    try
    {
      List<Car> cars = _carsService.GetCars();
      return Ok(cars);
    }
    catch (Exception e)
    {

      return BadRequest(e.Message);
    }
  }
  [HttpPost]
  public ActionResult<Car> CreateCar([FromBody] Car carData)
  {
    try
    {
      Car car = _carsService.CreateCar(carData);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{id}")]

  public ActionResult<Car> GetCarId(int id)
  {
    try
    {
      var car = _carsService.GetCarId(id);
      return Ok(car);
    }
    catch (Exception e)
    {

      BadRequest(e.Message);
    }
  }




  [HttpDelete("{id}")]
  public ActionResult<Car> RemoveCar(int id)
  {
    try
    {
      return Ok(_carsService.RemoveCar(id));
    }
    catch (Exception e)
    {

      return BadRequest(e);
    }


  }


}