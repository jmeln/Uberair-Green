using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class UberAirMain
{
    public static void Main(string[] args)
    {
        ArrayList Passengers = new ArrayList();
        if(args.Length == 0)
        {
//            GetUserInput(ref Passengers);
            runSimulation();
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
    ////// THIS IS A TEST SECTION //////
    public static void runSimulation()
    {
        City macon = new City("Macon" ,"GA", 83.65, 32.69, 1, 1700);
        City atlanta = new City("Atlanta" ,"GA", 84.43, 33.64, 1, 1700);
        City birmingham = new City("Birmingham" ,"AL", 86.75, 33.56, 1, 1700);

        Passenger matt = new Passenger("Matt", "Schnider", 1, macon, atlanta);
        Passenger cayla = new Passenger("Cayla", "Schnider", 1, macon, atlanta);
        Passenger andy = new Passenger("Andy", "Pounds", 1, birmingham, macon);
        Passenger jarrett = new Passenger("Jarret", "Melnick", 1, atlanta, birmingham);
        Passenger jake = new Passenger("Jake", "Foster", 1, macon, atlanta);
        Passenger emily = new Passenger("Emily", "Herron", 1, macon, atlanta);
        Passenger brett = new Passenger("Brett", "Wilson", 1, atlanta, birmingham);
        Passenger phuc = new Passenger("Phuc", "Lee", 1, birmingham, macon);

        Plane learJet = new Plane(300, 1, 1);

        learJet.addPass(matt);
        learJet.addPass(cayla);
        learJet.addPass(jake);
        learJet.addPass(emily);
        List<Passenger> temp = learJet.Pass();
        double totalMoney = 0;
        double totalDistance = 0;
        double totalCost = 0;
//        while(temp.Count > 0)
        {  
            Console.WriteLine("Passengers on board");
            for(int i = 0 ; i < temp.Count; i++)
            {
                 
                Console.WriteLine(temp[i].FirstName + " " +temp[i].LastName);
        
            }
            Console.WriteLine();
            Console.WriteLine("Flying from "+ macon.CityName + " to " + atlanta.CityName+"...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Landing in " + atlanta.CityName+"...");
            System.Threading.Thread.Sleep(1500);
            totalDistance += matt.DistanceTraveled;
            for(int i = 0 ; i < temp.Count; i++)
            {
                 
                Console.WriteLine(temp[i].FirstName + " " +temp[i].LastName + " "+ macon.CityName + " "  + atlanta.CityName + " " + temp[i].DistanceTraveled + " miles "+ " $" + temp[i].Price);
                System.Threading.Thread.Sleep(500);
                totalMoney += temp[i].Price;
        
            }

            learJet.removePass(matt);
            learJet.removePass(cayla);
            learJet.removePass(jake);
            learJet.removePass(emily);
            Console.WriteLine();

            learJet.addPass(jarrett);
            learJet.addPass(brett);
            temp = learJet.Pass();

            Console.WriteLine("Passengers on board");
            for(int i = 0 ; i < temp.Count; i++)
            {
                 
                Console.WriteLine(temp[i].FirstName + " " +temp[i].LastName);
        
            }
            Console.WriteLine();
            Console.WriteLine("Flying from "+ atlanta.CityName + " to " + birmingham.CityName+"...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Landing in " + birmingham.CityName+"...");
            System.Threading.Thread.Sleep(1500);
            totalDistance += jarrett.DistanceTraveled;
            for(int i = 0 ; i < temp.Count; i++)
            {
                 
                Console.WriteLine(temp[i].FirstName + " " +temp[i].LastName + " "+ macon.CityName + " "  + atlanta.CityName + " " + temp[i].DistanceTraveled + " miles "+ " $" + temp[i].Price);
                System.Threading.Thread.Sleep(500);
                totalMoney += temp[i].Price;

            }

            learJet.removePass(jarrett);
            learJet.removePass(brett);
            Console.WriteLine();


            learJet.addPass(phuc);
            learJet.addPass(andy);
            temp = learJet.Pass();
            Console.WriteLine("Passengers on board");
            for(int i = 0 ; i < temp.Count; i++)
            {
                 
                Console.WriteLine(temp[i].FirstName + " " +temp[i].LastName);
        
            }
            Console.WriteLine();
            Console.WriteLine("Flying from "+ birmingham.CityName + " to " + macon.CityName+"...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Landing in " + macon.CityName+"...");
            System.Threading.Thread.Sleep(1500);
            totalDistance += phuc.DistanceTraveled;
            for(int i = 0 ; i < temp.Count; i++)
            {
                 
                Console.WriteLine(temp[i].FirstName + " " +temp[i].LastName + " "+ macon.CityName + " "  + atlanta.CityName + " " + temp[i].DistanceTraveled + " miles "+ " $" + temp[i].Price);
                System.Threading.Thread.Sleep(500);
                totalMoney += temp[i].Price;

            }

            learJet.removePass(phuc);
            learJet.removePass(andy);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Total money collected: $" + totalMoney);
            Console.WriteLine("Total distance flown: " + totalDistance);
            totalCost = totalDistance * 2.75;
            Console.WriteLine("Operationg expenses: " + totalCost);
            if(totalMoney - totalCost > 0)
            {
                Console.WriteLine("Profit: $" + (totalMoney - totalCost));
            }
            else
                Console.WriteLine("Loss: $" + (totalMoney - totalCost));



        }
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
        double oLong = default(double);
        double oLat = default(double);
        string dCity;
        string dState;
        double dLong = default(double);
        double dLat = default(double);
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
                City origin = new City(oCity, oState, oLat, oLong, 0, 0);
                City destination = new City(dCity, dState, dLat, dLong, 0, 0);
                Passenger A = new Passenger(fName, lName, passCount, origin, destination);
                Passengers.Add(A);
            }
        }

        Console.WriteLine("**\tGENERATING ITINERARY\t**");
    }

    public static void CreateAirportsLists()
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
























