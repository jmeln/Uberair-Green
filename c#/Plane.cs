using System;

public class Plane
{
    private double _fuel;
    private int _numPass, _timezone;
    private List<Passenger> pass = new List<Passenger>; 

    // Constructor
    
    public Plane(double fuel, int numPass, int timezone)
    {
        _fuel = fuel;
        _numPass = numPass;
        _timezone = timezone;
    }
    
    // Return the variable
    public double Fuel
    {
     get{return _fuel;}
    }

    public int NumPass
    {
     get{return _numPass;}
    }
    public int Timezone
    {
     get{return _timezone;}
    }

    public Passenger[] Pass
    {
        get{return _pass;}
    }

    // Increase fuel by x
    public void incFuel(double x)
    {
        _fuel += x; 
    }
    
    // Decrease fuel by x
    public void decFuel(double x)
    {
        _fuel -= x; 
    }

    // Add a new passenger to the plane
    public void addPass(Passenger x)
    {
        pass.Add(x);
       _numPass += 1;
    }
    
    // Remove a passenger from the plane
    public void removePass(Passenger x)
    {
        pass.Remove(new Passenger(){passengerID = x.PassengerID});
        _numPass -= 1;
    }

    // Increase timezone by x
    public void incTimezone(int x)
    {
        _timezone += x; 
    }

    // Decrease timezone by x
    public void decTimezone(int x)
    {
        _timezone -= x; 
    }

    public bool full()
    {
        if (_numPass==10)
            return false;
        else
            return true;
    }
}
