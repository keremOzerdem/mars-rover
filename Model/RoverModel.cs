public class RoverModel
{
    private int roverX;
    private int roverY;
    private string roverDirection;
    public RoverModel(int roverX, int roverY, string roverDirection)
    {
        this.RoverX = roverX;
        this.RoverY = roverY;
        this.RoverDirection = roverDirection;
    }

    public int RoverX
    {
        get { return roverX; }
        set { roverX = value; }
    }
    public int RoverY
    {
        get { return roverY; }
        set { roverY = value; }
    }
    public string RoverDirection
    {
        get { return roverDirection; }
        set { roverDirection = value; }
    }
}