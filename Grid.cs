using System;

public class Grid
{
    private int[,] grid;

    public Grid(int[,] grid)
    {
        this.grid = grid;
    }

    public int GetWidth()
    {
        return grid.GetLength(0);
    }

    public int GetHeight()
    {
        return grid.GetLength(1);
    }

    public bool IsPassable(Coordinate coordinate)
    {
        // Check if the coordinate is within the grid
        if (coordinate.X < 0 || coordinate.X >= GetWidth() || coordinate.Y < 0 || coordinate.Y >= GetHeight())
        {
            return false;
        }

        // Check if the cell at the coordinate is passable
        return grid[coordinate.X, coordinate.Y] == 1;
    }

    public int[,] GetGrid()
    {
        return grid;
    }
}
