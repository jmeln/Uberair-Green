using System;
using System.IO;
<<<<<<< HEAD
using System.Collections;
=======
>>>>>>> add3385e4f371130e51ba44ac89cc9fbeb9a88a1

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

        // To be filled in at a later date
        //
        //
        //
        //
    }

    public static void GetUserInput(ref ArrayList Passengers)
    {
        string url;
        string textFromCityFile = "";

        try
        {
            //Url to be accessed
            url = "http://theochem.mercer.edu/csc330/data/zip_codes_states.csv";
            //Pushes contents of the file to textFromAirportFile
            textFromCityFile = (new System.Net.WebClient()).DownloadString(url);
        }
        catch (IOException e)
        {
            Console.WriteLine("WEB URL NOT FOUND.");
        }

        string[] cityLines = textFromCityFile.Split(
                new[] { Environment.NewLine }, StringSplitOptions.None);

        Console.WriteLine("Flight Itinerary Builder Programn\n");

        char y;
        string fName;
        string lName;
        string oCity;
        string oState;
        double oLong;
        double oLat;
        string dCity;
        string dState;
        double dLong;
        double dLat;

        while(true)
        {
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

            for(int i = 0; i < cityLines.Length; i++)
            {
                string[] currCity = cityLines[i].Split(',');
                if(currCity[3] == oCity)
                {
                    oLong = Convert.ToDouble(currCity[1]);
                    oLat = Convert.ToDouble(currCity[2]);
                }
                else if(currCity[3] == dCity)
                {
                    dLong = Convert.ToDouble(currCity[1]);
                    dLat = Convert.ToDouble(currCity[2]);
                }

                if(oLong != default(double) && dLong != default(double))
                    break;
            }

            Console.WriteLine(oLong + " " + oLat);
            Console.WriteLine(dLong + " " + dLat);

        }

        Console.WriteLine("**\tGENERATING ITINERARY\t**");
    }

    public static void CreateUsableAorportFile()
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
        System.IO.StreamWriter file = new System.IO.StreamWriter("UsableAirports.txt");
        
        Console.WriteLine(airportLines[1]);
        Console.WriteLine(runwayLines[1]);
        
        for(int i = 0; i < airportLines.Length - 1; i++)
        {
            string currLine = airportLines[i];
            string currAirCode = currLine.Split(',')[1];
            string currRunLine;
            string surface;
            string length;

            for(int j = 0; j < runwayLines.Length - 1; j++)
            {
                Console.Write(i);
                Console.Write("\t");
                Console.WriteLine(j);
                
                currRunLine = runwayLines[j];
                string currRunCode = currRunLine.Split(',')[2];
                
                if(currRunCode.Equals(currAirCode))
                {
                    length = currRunLine.Split(',')[3];
                    int val = 0;
                    Int32.TryParse(length, out val );
                    surface = currRunLine.Split(',')[5];
                    if((surface.Contains("\"TURF\"") || surface.Contains("\"CONC\"") || surface.Contains("\"ASPH\""))
                        && val >= minRunwayLength)
                    {
                        file.WriteLine(currLine);
                        Console.WriteLine(currLine);
                    }

                    break;
                }

            }
        }
    }
}
























