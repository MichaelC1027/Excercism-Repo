public class Car{
  public int battery {get; set;}
  public int distance {get; set;}

  public Car(){
    battery = 100;
    distance = 0;
  }

  public Car(int bat){
    battery = bat;
    distance = 0;
  }
}


class RemoteControlCar
{
  Car car = new Car(100);

    public static RemoteControlCar Buy()
    {
      return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
      return $"Driven {car.distance} meters";
    }

    public string BatteryDisplay()
    {
      if(car.battery > 0){
        return $"Battery at {car.battery}%";
      }
      return "Battery empty";
    }

    public void Drive()
    {
      if(car.battery > 0){
        car.distance += 20;
        car.battery -= 1;
      }
    }
}

