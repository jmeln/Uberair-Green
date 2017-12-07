using System;
using System.Collections.Generic;

public class Map_Math
{
 
    public static double distance(double long_1, double lat_1, double long_2, double lat_2)
    {
        return Math.Sqrt( Math.Pow( long_2 - lat_2, 2.0) + Math.Pow(lat_2 - lat_1, 2.0) );      
    }    

}
