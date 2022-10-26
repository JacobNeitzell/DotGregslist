namespace DotGregslist.Services;

public class CarsService
{
  private readonly CarsRepository _carsRepo;


  public CarsService(CarsRepository carsRepo)
  {
    _carsRepo = carsRepo;
  }

  public List<Car> GetCars()
  {
    return _carsRepo.GetCars();
  }

  public Car CreateCar(Car carData)
  {
    return _carsRepo.CreateCar(carData);
  }
  public List<Car> GetCarId(int id)
  {
    var car = _carsRepo;
    if (car == null)
    {
      throw new Exception("Inavlid ID");
    }
    return car;
  }

  public Car RemoveCar(int id)
  {
    Car car = GetCarId(id);
    return _carsRepo.RemoveCar(id);
  }

}