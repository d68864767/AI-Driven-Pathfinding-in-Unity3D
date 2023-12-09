using System;

public class Coordinate
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !this.GetType().Equals(obj.GetType()))
        {
            return false;
        }
        else
        {
            Coordinate c = (Coordinate) obj;
            return (this.X == c.X) && (this.Y == c.Y);
        }
    }

    public override int GetHashCode()
    {
        return Tuple.Create(X, Y).GetHashCode();
    }
}
