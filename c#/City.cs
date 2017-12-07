public class City
{//City class
 //By: Matt Schnider
 
    //Private members
    private string _cityName, _state;
    private double _latitude, _longitude;
    private int _timeZone, _sunSet;
    
    //Constructor
    public City(string cityName, string state, double latitude, double longitude,
                    int timeZone, int sunSet)
    {
        _cityName = cityName;
        _state = state;
        _latitude = latitude;
        _longitude = longitude;
        _timeZone = timeZone;
        _sunSet = sunSet;
    }
    //Public getters 
    public string CityName
    {  
         get{return _cityName;} 
    }
    public string State
    {
        get{return _state;}
    }
    public double Latitude
    {
        get{return _latitude;}
    }
    public double Longitude
    {
        get{return _longitude;}
    }
    public int TimeZone
    {
        get{return _timeZone;}
    }
    public int SunSet
    {
        get{return _sunSet;}
    }
}
