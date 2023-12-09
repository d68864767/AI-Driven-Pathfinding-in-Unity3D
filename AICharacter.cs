using System;

public class AICharacter
{
    private Coordinate currentCoordinate;

    public AICharacter(Coordinate startCoordinate)
    {
        this.currentCoordinate = startCoordinate;
    }

    public Coordinate GetCurrentCoordinate()
    {
        return this.currentCoordinate;
    }

    public void MoveTo(Coordinate newCoordinate)
    {
        this.currentCoordinate = newCoordinate;
    }
}
