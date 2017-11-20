using System;

public class Plane
{
    private double plane_fuel,plane_subtractFuel;
    private int plane_numPass, plane_timeZone,plane_addPass,plane_removePass;

    public Plane(double fuel, double subtractFuel, int numPass, int timeZone, int addPass, int removePass)
    {
        plane_fuel = fuel;
        plane_subtractFuel = subtractFuel;
        plane_numPass = numPass;
        plane_timeZone = timeZone;
        plane_addPass = addPass;
        plane_removePass = removePass;
    }

    public double fuel
    {
     get{return plane_fuel;}
    }

    double subtractFuel
    {
     get{return plane_subtractFuel;}
     }
    int numPass
    {
     get{return plane_numPass;}
    }
    int timeZone
    {
     get{return plane_timeZone;}
    }
    int addPass
    {
       get{return plane_addPass;}
    }
    int removePass
    {
       get{return plane_removePass;}
    }
}
