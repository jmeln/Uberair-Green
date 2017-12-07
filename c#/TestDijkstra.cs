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
   
    }

}
