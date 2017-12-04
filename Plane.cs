using System;

public class Plane
{
    private double _fuel;
    private int _numPass, _timeZone,_removePass;

    public Plane(double fuel, int numPass, int timeZone)
    {
        _fuel = fuel;
        _numPass = numPass;
        _timeZone = timeZone;
    }

    public double fuel
    {
     get{return _fuel;}
    }

    public int numPass
    {
     get{return _numPass;}
    }

    public int timeZone
    {
     get{return _timeZone;}
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

    public void incTimezone(double x)
    {
        _timezone -= x; 
    }

    public void decTimezone(double x)
    {
        _timezone -= x; 
    }
}
