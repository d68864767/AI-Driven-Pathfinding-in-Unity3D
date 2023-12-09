using System;

public class Heuristic
{
    public double Calculate(Coordinate start, Coordinate end)
    {
        // Calculate the Manhattan distance
        int dx = Math.Abs(start.X - end.X);
        int dy = Math.Abs(start.Y - end.Y);

        return dx + dy;
    }
}
