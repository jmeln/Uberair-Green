public class City
{
    //Private members
    private string cityName, state;
    private double latitude, longitude;
    private int timeZone, sunSet, passengersWaiting;
    //private Airport nearestLighted, nearestUnlighted;
    
    //Constructor
    public City()
    {
        cityName = "";
        state = "";
        latitude = 0.0;
        longitude = 0.0;
        timeZone = 0;
        sunSet = 0;
        passengersWaiting = 0;
    }
    //Overloaded constructor that takes all muteable parameters
    public City(string cityName, string state, double latitude, double longitude,
                    int timeZone, int sunSet, int passengersWaiting)
    {
        this.cityName = cityName;
        this.state = state;
        this.latitude = latitude;
        this.longitude = longitude;
        this.timeZone = timeZone;
        this.sunSet = sunSet;
        this.passengersWaiting = passengersWaiting;
    }
}
