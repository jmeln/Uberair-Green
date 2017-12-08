using System;
using System.IO;
using System.Linq;
using System.Collections;

public class UberAirMain
{
    public static void Main(string[] args)
    {
        ArrayList Passengers = new ArrayList();
        if(args.Length == 0)
        {
            GetUserInput(ref Passengers);
        }
        else if(args.Length > 1)
        {
            Console.WriteLine("TOO MANY COMMAND LINE ARGUMENTS.\nEXITING...");
            System.Environment.Exit(1);
        }
        else
        {
            //CSV input
        }

        // CreateAirportsLists()
        // To be filled in at a later date
        //
        //
        //
        //
    }

    public static void GetUserInput(ref ArrayList Passengers)
    {
        string url1, url2;
        string textFromCityFile = "";
        string textFromCityFile2 = "";

        try
        {
            //Url to be accessed
            url1 = "http://theochem.mercer.edu/csc330/data/zip_codes_states.csv";
            //Pushes contents of the file to textFromAirportFile
            textFromCityFile = (new System.Net.WebClient()).DownloadString(url1);

            url2 = "http://theochem.mercer.edu/csc330/data/cityzipcodes.csv";
            textFromCityFile2 = (new System.Net.WebClient()).DownloadString(url2);
        }
        catch (IOException e)
        {
            Console.WriteLine("WEB URL NOT FOUND.");
        }

        string[] cityLines = textFromCityFile.Split(
                new[] { Environment.NewLine }, StringSplitOptions.None);
        string[] sunsetLines = textFromCityFile2.Split(
                new[] { Environment.NewLine }, StringSplitOptions.None);

        Console.WriteLine("Flight Itinerary Builder Programn\n");

        char y;
        string fName;
        string lName;
        string oCity;
        string oState;
        double oLong = default(double);
        double oLat = default(double);
        int oTimeZone = 0;
        string dCity;
        string dState;
        double dLong = default(double);
        double dLat = default(double);
        int dTimeZone = 0;
        int passCount = 1;

        while(true)
        {
            // Menu Printing
            Console.WriteLine("Do you want to add a passenger to your itinerary list (Y/N)?");
            y = Console.ReadKey().KeyChar;
            if(y == 'n' || y == 'N')
                break;

            Console.Write("\n\nFirst Name: ");
            fName = Console.ReadLine();
            Console.Write("Last Name: ");
            lName = Console.ReadLine();
            Console.Write("Origin City: ");
            oCity = Console.ReadLine();
            Console.Write("Origin State (Two Letter Code): ");
            oState = Console.ReadLine();
            Console.Write("Destination City: ");
            dCity = Console.ReadLine();
            Console.Write("Destination State (Two Letter Code): ");
            dState = Console.ReadLine();

            // To compare with CSV formatted strings
            string tempOCity = "\"" + oCity + "\"";
            string tempOState = "\"" + oState + "\"";
            string tempDCity = "\"" + dCity + "\"";
            string tempDState = "\"" + dState + "\"";


            for(int j = 1; j < sunsetLines.Length - 1; j++)
            {
                if(sunsetLines[j].Length > 5) // Garbage in the file. It works, don't question it
                {
                    string[] currCity2 = sunsetLines[j].Split(',');

                    if(currCity2[1] == tempOCity && currCity2[2] == tempOState)
                    {
                        oTimeZone = Int32.Parse(currCity2[5]);
                    }
                    else if(currCity2[1] == tempDCity && currCity2[2] == tempDState)
                    {
                        dTimeZone = Int32.Parse(currCity2[5]);
                    }
                }
            }

            // Search for the Cities
            for(int i = 1; i < cityLines.Length - 1; i++)
            {
                string[] currCity = cityLines[i].Split(',');
                
                if(currCity[3] == tempOCity && currCity[4] == tempOState)
                {
                    // Average the Lats and Longs
                    double latSum = Convert.ToDouble(currCity[1]);
                    double longSum = Convert.ToDouble(currCity[2]);
                    double latAvg, longAvg;
                    int count = 1;
                    while(currCity[3] == tempOCity && currCity[4] == tempOState)
                    {
                        i++;
                        currCity = cityLines[i].Split(',');

                        latSum += Convert.ToDouble(currCity[1]);
                        longSum += Convert.ToDouble(currCity[2]);
                        count++;
                    }

                    latAvg = latSum / count;
                    longAvg = longSum / count;
                    oLong = longAvg;
                    oLat = latAvg;
                }
                else if(currCity[3] == tempDCity && currCity[4] == tempDState)
                {
                    // Average the Lats and Longs
                    double latSum = Convert.ToDouble(currCity[1]);
                    double longSum = Convert.ToDouble(currCity[2]);
                    double latAvg, longAvg;
                    int count = 1;
                    while(currCity[3] == tempDCity && currCity[4] == tempDState)
                    {
                        i++;
                        currCity = cityLines[i].Split(',');

                        latSum += Convert.ToDouble(currCity[1]);
                        longSum += Convert.ToDouble(currCity[2]);
                        count++;
                    }

                    latAvg = latSum / count;
                    longAvg = longSum / count;
                    dLong = longAvg;
                    dLat = latAvg;
                }

                if(oLong != default(double) && dLong != default(double))
                    break;
            }

            // Check if Cities exist
            if(oLong == default(double) && dLong == default(double))
            {
                Console.WriteLine("ERROR: Invalid Origin/Destination City. Try Again...");
            }
            else
            {
                // Add Passenger to the List
                City origin = new City(oCity, oState, oLat, oLong, oTimeZone, 19);
                City destination = new City(dCity, dState, dLat, dLong, dTimeZone, 19);
                Passenger A = new Passenger(fName, lName, passCount, origin, destination);
                Passengers.Add(A);
                FindClosestAirport(origin);
                FindClosestAirport(destination);
            }
        }

        Console.WriteLine("**\tGENERATING ITINERARY\t**");
    }

    public static double Distance(double oLat, double oLong, double dLat, double dLong)
    {
        double d = 0;
        double a1 = DegreesToRadians(oLat);
        double a2 = DegreesToRadians(dLat);
        double b1 = DegreesToRadians(oLong);
        double b2 = DegreesToRadians(dLong);

        d = ((1 - Math.Cos(2*((a2-a1)/2)))/2) + Math.Cos(a1)*Math.Cos(a2)*((1 - Math.Cos(2*((b2-b1)/2)))/2);
        d = ((2*6373)*(Math.Asin(Math.Sqrt(d))));
        return d;
    }

    public static double DegreesToRadians(double num)
    {
        return ((num*180)/Math.PI);
    }

    public static void FindClosestAirport(City mycity)
    {
        string url;
        string textFromAirportFile = "";
        string textFromRunwayFile = "";

        try
        {
            //Url to be accessed
            url = "http://theochem.mercer.edu/csc330/data/airports.csv";
            //Pushes contents of the file to textFromAirportFile
            textFromAirportFile = (new System.Net.WebClient()).DownloadString(url);
            //Console.WriteLine(textFromFile);
        }
        catch (IOException e)
        {
            Console.WriteLine("WEB URL NOT FOUND.");
        }

        //Split large string to array of lines
        string[] airportLines = textFromAirportFile.Split(
            new[] { Environment.NewLine },
            StringSplitOptions.None);

        try
        {
            //Url to be accessed
            url = "http://theochem.mercer.edu/csc330/data/runways.csv";
            // //Pushes contents of the file to textFromRunwayFile
            textFromRunwayFile = (new System.Net.WebClient()).DownloadString(url);
        }
        catch(IOException e)
        {
            Console.WriteLine("WEB URL NOT FOUND.");
        }

        string[] runwayLines = textFromRunwayFile.Split(
            new[] { Environment.NewLine },
            StringSplitOptions.None);

        const int minRunwayLength = 3000;
        int closeIndex = 0;
        double closeDistance = 1000000;

        for(int i = 1; i < airportLines.Length - 1; i++)
        {
            string[] currAirport = airportLines[i].Split(',');
            double Lat = Convert.ToDouble(currAirport[4]);
            double Long = Convert.ToDouble(currAirport[5]);
            string currAirCode = currAirport[1];

            double oDistance = Distance(mycity.Latitude, mycity.Longitude, Lat, Long);

            for(int j = 1; j < runwayLines.Length - 1; j++)
            {
                string currRunLine = runwayLines[j];
                string currRunCode = currRunLine.Split(',')[2];
                
                if(currRunCode.Equals(currAirCode))
                {
                    string supremeOverlord = currRunLine.Split(',')[3];
                    Console.WriteLine(supremeOverlord);
                    //supremeOverlord = supremeOverlord.Substring(1, supremeOverlord.Length - 1);
                    //supremeOverlord = supremeOverlord.Substring(0, supremeOverlord.Length - 2);

                    if(supremeOverlord.Length > 5)
                    {
                        int length = Int32.Parse(supremeOverlord);
                        string surface = currRunLine.Split(',')[5];

                        if((surface.Contains("\"TURF\"") || surface.Contains("\"CONC\"") 
                                || surface.Contains("\"ASPH\"")) && length >= minRunwayLength)
                        {
                            if(oDistance < closeDistance)
                            {
                                closeDistance = oDistance;
                                closeIndex = i;
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine("HERE");
        Console.WriteLine("Closest Airport to " + mycity.CityName + " is " + airportLines[closeIndex].Split(',')[3]);
    }
}
























