using System;
using System.Collections.Generic;

class TestDijkstra
{
    static void Main()
    {
        Graph g = new Graph();
        g.add_vertex("Atlanta", new Dictionary<string, int>() {{"Baltimore", 7},{"Carson City", 8}});
        g.add_vertex("Baltimore", new Dictionary<string, int>() {{"Atlanta", 7}, {"Pheonix", 2}});
        g.add_vertex("Carson City", new Dictionary<string, int>() {{"Atlanta", 8}, {"Pheonix", 6}, {"Gainesville", 4}});
        g.add_vertex("Denver", new Dictionary<string, int>() {{"Pheonix", 8}});
        g.add_vertex("Eatonton", new Dictionary<string, int>() {{"Houston", 1}});
        g.add_vertex("Pheonix", new Dictionary<string, int>() {{"Baltimore", 2}, {"Carson City", 6}, {"Denver", 8}, {"Gainesville", 9}, {"Houston", 3}});
        g.add_vertex("Gainesville", new Dictionary<string, int>() {{"Carson City", 4}, {"Pheonix", 9}});
        g.add_vertex("Houston", new Dictionary<string, int>() {{"Eatonton", 1}, {"Pheonix", 3}});
        g.shortest_path("Atlanta", "Houston").ForEach( x => Console.WriteLine(x) );
    
    }

}
