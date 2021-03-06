using System;
using System.Collections.Generic;
using System.IO;

class TestDijkstra
{
    static void Main()
    {
        int[] popular_destinations = new int[11];
        for(int d = 0; d < popular_destinations.Length; d++)
            popular_destinations[d] = 0;


        City[] cities = new City[11];
        cities[0] = new City("Daytona", "FL", 29.2108, 81.0228, 1, 1);
        cities[1] = new City("Memphis", "TN", 35.1495, 90.0490, 1, 1);
        cities[2] = new City("Atlanta", "GA", 33.7490, 84.3880, 1, 1);
        cities[3] = new City("Columbia", "SC", 34.0007, 81.0348, 1, 1);
        cities[4] = new City("Johnson City", "TN", 36.3134, 82.3535, 1, 1);
        cities[5] = new City("Tampa", "FL", 27.9506, 82.4572, 1, 1);
        cities[6] = new City("Oxford", "MS", 34.3665, 89.5192, 1, 1);
        cities[7] = new City("Arkadelphia", "AR", 34.1209, 93.0538, 1, 1);
        cities[8] = new City("Durham", "NC", 35.9940, 78.8986, 1, 1);
        cities[9] = new City("Kileen", "TX", 31.1171, 97.7278, 1, 1);
        cities[10] = new City("Miami", "FL", 25.7617, 80.1918, 1, 1);


        using(var reader = new StreamReader(@"input.txt"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                for(int c = 0; c < cities.Length; c++)
                    if(cities[c].CityName == values[4]){
                        popular_destinations[c]++;
                    }
            }
        }




        DijkstraGraph city_graph = new DijkstraGraph();

        for (int c = 0; c < cities.Length; c++){

            Dictionary<string, double> dict_temp = new Dictionary<string, double>();
            for(int d = 0; d < cities.Length; d++){
                if (d != c){
                    Console.WriteLine(cities[d].CityName);
                    double distance = Map_Math.distance(cities[c].Longitude, cities[c].Latitude, cities[d].Longitude, cities[d].Latitude);
                    dict_temp.Add(cities[d].CityName, 200*popular_destinations[c]-30*distance);
                }
            }

            Console.WriteLine("\t");
            city_graph.add_vertex(cities[c].CityName, dict_temp);
        }

        city_graph.shortest_path("Atlanta", "Daytona").ForEach( x => Console.WriteLine(x) );


    }

}
