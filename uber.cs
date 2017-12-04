using System;

public class uber
{
    public static void Main(){
        Plane phuc = new Plane(2.0,3,2);
        Console.WriteLine(phuc.fuel);
        phuc.incFuel(1);
        Console.WriteLine(phuc.fuel);
        phuc.decFuel(2);
        Console.WriteLine(phuc.fuel);
         Console.WriteLine(phuc.timezone);
        phuc.incTimezone(1);
        Console.WriteLine(phuc.timezone);
        phuc.decTimezone(2);
        Console.WriteLine(phuc.timezone);
 

    }
}
