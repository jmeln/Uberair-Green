using System;
using System.Collections.Generic;

//namespace Dijkstras
//{
    public class DijkstraGraph
    {
        Dictionary<string, Dictionary<string, double>> vertices = new Dictionary<string, Dictionary<string, double>>();

        public void add_vertex(string name, Dictionary<string, double> edges)
        {
            vertices[name] = edges;
        }

        public List<string> shortest_path(string start, string finish){
            var previous = new Dictionary<string, string>();
            var distances = new Dictionary<string, double>();
            var nodes = new List<string>();

            List<string> path = null;

            foreach (var vertex in vertices)
            {
                if (vertex.Key == start)
                {
                    distances[vertex.Key] = 0.0;
                }
                else
                {
                    distances[vertex.Key] = double.MaxValue;// int.MaxValue;
                }

                nodes.Add(vertex.Key);
            }

            while (nodes.Count != 0)
            {
                //nodes.Sort((x,y) => distances[x] - distances[y]);
                nodes.Sort((x, y) => distances[x] < distances[y] ? 1 : (distances[x] > distances[y] ? -1 : 0));
                var smallest = nodes[0];
                nodes.Remove(smallest);

                if (smallest == finish)
                {
                    path = new List<string>();
                    while (previous.ContainsKey(smallest))
                    {
                        path.Add(smallest + "\t" + distances[smallest]);
                        //path.Add(distances[0] + string.Empty);
                        smallest = previous[smallest];
                    }
                    break;
                }

                if (distances[smallest] == double.MaxValue) //int.MaxValue)
                {
                    break;
                }

                foreach (var neighbor in vertices[smallest])
                {
                    var alt = distances[smallest] + neighbor.Value;
                    if(alt < distances[neighbor.Key])
                    {
                        distances[neighbor.Key] = alt;
                        previous[neighbor.Key] = smallest;
                    }
                }

            }
            return path;
        }
    }

//}
