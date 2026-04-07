class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class

  int speed {get; set;}
  int batteryDrain {get; set;}
  int distance = 0;
  public int battery = 100;

  public RemoteControlCar(int s, int bat){
    batteryDrain = bat;
    speed = s;
  }

    public bool BatteryDrained()
    {
      if(battery >= batteryDrain){
        return false;
      }
      return true;
    }

    public int DistanceDriven()
    {

      return distance;
    }

    public void Drive()
    {
      if (battery >= batteryDrain){ 
        distance += speed;
        battery -= batteryDrain;
      }
    }

    public static RemoteControlCar Nitro()
    {
      return new RemoteControlCar(50,4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class

  int distance {get; set;}

  public RaceTrack(int dis){
    distance = dis;
  }

    public bool TryFinishTrack(RemoteControlCar car)
    {
      
      while(!car.BatteryDrained())
      {
        car.Drive();
        //Console.WriteLine("in the while loop");
      }

      int cardis = car.DistanceDriven();
      return (cardis >= distance);
    }
}
