using System;

public class Plane
{
    private double _fuel;
    private int _numPass, _timezone;

    public Plane(double fuel, int numPass, int timezone)
    {
        _fuel = fuel;
        _numPass = numPass;
        _timezone = timezone;
    }

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

    public void incFuel(double x)
    {
        _fuel -= x; 
    }

    public void decFuel(double x)
    {
        _fuel -= x; 
    }

    public void incPass(int x)
    {
       _numPass += x;
    }
    public void decPass(int x)
    {
        _numPass -=x;
    }

    public void incTimezone(int x)
    {
        _timezone -= x; 
    }

    public void decTimezone(int x)
    {
        _timezone -= x; 
    }
}
