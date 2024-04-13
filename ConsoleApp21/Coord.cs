namespace ConsoleApp21;

internal struct Coord
{
    public char xCoord;
    public int yCoord;
    public Coord(char x, int y)
    {
        xCoord = x;
        yCoord = y;
    }
}

enum Figure
{
    K, //king
    Q, //queen
    B, //bishop
    R, //rook
    N   //knight(dzi)
}
