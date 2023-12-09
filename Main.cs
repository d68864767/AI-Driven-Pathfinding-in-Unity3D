using System;
using System.Collections.Generic;

public class Main
{
    public static void Main(string[] args)
    {
        // Initialize the grid
        int[,] grid = new int[,]
        {
            {1, 1, 1, 1, 0},
            {0, 0, 0, 1, 0},
            {1, 1, 1, 1, 1},
            {1, 0, 0, 0, 0},
            {1, 1, 1, 1, 1}
        };

        // Initialize the start and end coordinates
        Coordinate start = new Coordinate(0, 0);
        Coordinate end = new Coordinate(4, 4);

        // Initialize the AI character
        AICharacter aiCharacter = new AICharacter(start);

        // Initialize the pathfinding algorithm
        Pathfinding pathfinding = new Pathfinding(grid);

        // Find the shortest path
        List<Coordinate> path = pathfinding.FindPath(aiCharacter, end);

        // Print the path
        if (path.Count == 0)
        {
            Console.WriteLine("No valid path found.");
        }
        else
        {
            Console.WriteLine("The shortest path is:");
            foreach (Coordinate coordinate in path)
            {
                Console.WriteLine("(" + coordinate.X + ", " + coordinate.Y + ")");
            }
        }
    }
}
