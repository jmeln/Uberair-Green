import heapq
import sys

class DijkstraGraph:
    def __init__(self):
        self.vertices = {}

    def add_vertex(self, name, edges):
        self.vertices[name] = edges

    def shortest_path(self, start, finish):
        distances = {}
        previous = {}
        nodes = []
        
        for vertex in self.vertices:
            if vertex == start:
                distances[vertex] = 0
                heapq.heappush(nodes, [0, vertex])
            else:
                distances[vertex] = sys.maxsize
                heapq.heappush(nodes, [sys.maxsize, vertex])
            previous[vertex] = None
    
        while nodes:
            smallest = heapq.heappop(nodes)[1]
            if smallest == finish:
                path = []
                while previous[smallest]: 
                    path.append(smallest)
                    smallest = previous[smallest]
                return path
            if distances[smallest] == sys.maxsize:
                break

            for neighbor in self.vertices[smallest]:
                alt = distances[smallest] + self.vertices[smallest][neighbor]
                if alt < distances[neighbor]:
                    distances[neighbor] = alt
                    previous[neighbor] = smallest
                    for n in nodes:
                        if n[1] == neighbor:
                            n[0] = alt
                            break
                    heapq.heapify(nodes)

        return distances

    def __str__(self):
        return str(self.vertices)

if __name__ == '__main__':
    flight_graph = DijkstraGraph()
    flight_graph.add_vertex("Atlanta", {"Baltimore": 7,"Carson City": 8})
    flight_graph.add_vertex("Baltimore", {"Atlanta": 7, "Pheonix": 2})
    flight_graph.add_vertex("Carson City", {"Atlanta": 8, "Pheonix": 6, "Gainesville": 4})
    flight_graph.add_vertex("Denver", {"Pheonix": 8})
    flight_graph.add_vertex("Eatonton", {"Houston": 1})
    flight_graph.add_vertex("Pheonix", {"Baltimore": 2, "Carson City": 6, "Denver": 8, "Gainesville": 9, "Houston": 3})
    flight_graph.add_vertex("Gainesville", {"Carson City": 4, "Pheonix": 9})
    flight_graph.add_vertex("Houston", {"Eatonton": 1, "Pheonix": 3})

    print(flight_graph.shortest_path("Atlanta", "Houston"))

