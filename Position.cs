using System.Data;

class Position
{
    

    private int height;
    private int width;

    public int Row{get; set;}
    public int Col {get; set;}

    public Position (int startRow, int startCol, int height, int width)
    {
        Row = startRow;
        Col = startCol;
        this.width = width;
        this.height = height;
    }

 

    public void Print()
    {
        
    }
    public void Move (ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow:
                Row--;
                break;

            case ConsoleKey.DownArrow:
                Row++;
                break;

            case ConsoleKey.LeftArrow:
                Col--;
                break;

            case ConsoleKey.RightArrow:
                Col++;
                break;
        }

        Row = Math.Clamp(Row, 0, height - 1);
        Col = Math.Clamp(Col, 0, width - 1);
    }
}