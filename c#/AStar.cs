using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// node class 
public class Node
{

    public static int SIZE = 32;
    public Node Parent;
    public Vector2 Position;
    public Vector2 Center
    {
        get
        {
            return new Vector2(Position.X + NODE_SIZE / 2, Position.Y + NODE_SIZE/2);
        }
    }
    public double Distance;
    public double Cost;

    public bool Checked;
    public Node(Vector2 curr, bool checked)
    {
        Prev = null;
        Position = curr;
        Distance = -1;
        Weight = 1;
        Checked = checked;
    }

}

public class AStar
{
// returns list of edges from start to end
//

    public AStar(){}

    //public List<Edge> aStar, Graph<T> graph, GraphNode<T> node, 


}
