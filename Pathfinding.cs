using System;
using System.Collections.Generic;

public class Pathfinding
{
    private Grid grid;
    private Heuristic heuristic;

    public Pathfinding(Grid grid, Heuristic heuristic)
    {
        this.grid = grid;
        this.heuristic = heuristic;
    }

    public List<Coordinate> FindPath(Coordinate start, Coordinate end)
    {
        Dictionary<Coordinate, Coordinate> cameFrom = new Dictionary<Coordinate, Coordinate>();
        Dictionary<Coordinate, double> costSoFar = new Dictionary<Coordinate, double>();
        PriorityQueue<Coordinate> frontier = new PriorityQueue<Coordinate>();

        frontier.Enqueue(start, 0);
        cameFrom[start] = start;
        costSoFar[start] = 0;

        while (!frontier.IsEmpty())
        {
            Coordinate current = frontier.Dequeue();

            if (current.Equals(end))
            {
                break;
            }

            foreach (Coordinate next in grid.GetNeighbors(current))
            {
                double newCost = costSoFar[current] + grid.Cost(current, next);

                if (!costSoFar.ContainsKey(next) || newCost < costSoFar[next])
                {
                    costSoFar[next] = newCost;
                    double priority = newCost + heuristic.Calculate(next, end);
                    frontier.Enqueue(next, priority);
                    cameFrom[next] = current;
                }
            }
        }

        if (!cameFrom.ContainsKey(end))
        {
            return new List<Coordinate>();
        }

        List<Coordinate> path = new List<Coordinate>();
        Coordinate currentInPath = end;

        while (!currentInPath.Equals(start))
        {
            path.Add(currentInPath);
            currentInPath = cameFrom[currentInPath];
        }

        path.Add(start);
        path.Reverse();

        return path;
    }
}
