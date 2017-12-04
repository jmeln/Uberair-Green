using System;

public class Plane
{
    private double _fuel;
    private int _numPass, _timezone;

    // Constructor
    public Plane(double fuel, int numPass, int timezone)
    {
        _fuel = fuel;
        _numPass = numPass;
        _timezone = timezone;
    }
    
    // Return the variable
    public double fuel
    {
     get{return _fuel;}
    }

    public int numPass
    {
     get{return _numPass;}
    }
    public int timezone
    {
     get{return _timezone;}
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

    // Increase pass by x
    public void incPass(int x)
    {
       _numPass += x;
    }
    
    // Decrease pass by x
    public void decPass(int x)
    {
        _numPass -=x;
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
}
