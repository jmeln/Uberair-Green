using System;
using System.Collections.Generic;

class TestDijkstra
{
    static void Main()
    {
        DijkstraGraph g = new DijkstraGraph();
        g.add_vertex("Atlanta", new Dictionary<string, double>() {{"Baltimore", 7},{"Carson City", 8}});
        g.add_vertex("Baltimore", new Dictionary<string, double>() {{"Atlanta", 7}, {"Pheonix", 2}});
        g.add_vertex("Carson City", new Dictionary<string, double>() {{"Atlanta", 8}, {"Pheonix", 6}, {"Gainesville", 4}});
        g.add_vertex("Denver", new Dictionary<string, double>() {{"Pheonix", 8}});
        g.add_vertex("Eatonton", new Dictionary<string, double>() {{"Houston", 1}});
        g.add_vertex("Pheonix", new Dictionary<string, double>() {{"Baltimore", 2}, {"Carson City", 6}, {"Denver", 8}, {"Gainesville", 9}, {"Houston", 3}});
        g.add_vertex("Gainesville", new Dictionary<string, double>() {{"Carson City", 4}, {"Pheonix", 9}});
        g.add_vertex("Houston", new Dictionary<string, double>() {{"Eatonton", 1}, {"Pheonix", 3}});
        g.shortest_path("Atlanta", "Houston").ForEach( x => Console.WriteLine(x) );
 
        Console.WriteLine(Map_Math.distance(1.0, 15.0, 2.0, 56.0));
   
        City[] cities = new City[5];
        cities[0] = new City("Holtsville", "A", 40.922326, -72.637078, 1, 1);
        cities[1] = new City("Adjuntas", "A", 18.165273,  -66.722583, 1, 1);
        cities[2] = new City("Aguada", "B", 18.393103, -67.180953, 1, 1);
        cities[3] = new City("Maricao", "C", 18.172947, -66.944111, 1, 1);
        cities[4] = new City("Anasco", "D", 18.288685, -67.139696, 1, 1);


        DijkstraGraph city_graph = new DijkstraGraph();

        for (int c = 0; c < cities.Length; c++){
            
            Dictionary<string, double> dict_temp = new Dictionary<string, double>();
            for(int d = 0; d < cities.Length; d++){
                while (d != c){
                    dict_temp.Add(cities[d].CityName, 
                        Map_Math.distance(cities[c].Longitude, cities[c].Latitude, cities[d].Longitude, cities[d].Latitude));
                    break;
                }
            }

            city_graph.add_vertex(cities[c].CityName, dict_temp);
        }

        city_graph.shortest_path("Holtsville", "Anasco").ForEach( x => Console.WriteLine(x) );


    }

}
