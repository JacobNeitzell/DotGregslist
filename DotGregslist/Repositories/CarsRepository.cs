namespace DotGregslist.Repositories;

public class CarsRepository
{
  private readonly IDbConnection _db;

  public CarsRepository(IDbConnection db)
  {
    _db = db;
  }

  public List<Car> GetCars()
  {
    var sql = "SELECT * FROM cars";
    return _db.Query<Car>(sql).ToList();


  }

  public Car CreateCar(Car carData)
  {
    var sql = @"
    INSERT INTO cars(
      make, model, year, price, description, imgUrl
    )
    VALUES(
      @Make, @Model, @Year, @Price, @Description, @ImgUrl
    );
    SELECT LAST_INSERT_ID();
    ";

    carData.Id = _db.ExecuteScalar<int>(sql, carData);
    return carData;

  }

  public Car GetCarId(int id)
  {
    return id;
  }


  public Car RemoveCar(int id)
  {
    var sql = "DELETE FROM cars WHERE @id = id ;";
    _db.Execute(sql);
  }




}