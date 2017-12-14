To run the proof of concept:

    - make -f makefile
    - mono UberAirMain.exe

*****NOTE: This is only a proof of concept to show that the classes we wrote do work together. The plane picks up and drops off and calculates whether or not
           a profit was made.

Dijkstra's Algorithm Pathfinder Compilation Instructions

    - mcs TestDijkstra.cs City.cs Map_Math.cs DijkstraGraph.cs
    - mono TestDijkstra.exe
