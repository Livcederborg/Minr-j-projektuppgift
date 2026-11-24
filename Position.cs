using System.Data;

class Position
{
    private int row;
    private int col;

    private int height;
    private int width;

    public Position (int startRow, int startCol, int height, int width)
    {
        row = startRow;
        col = startCol;
        this.width = width;
        this.height = height;
    }

    public int Row()
    {

        return row;
    }

    public int Col ()
    {
        return col; // Fråga lärarn!
    }

    public void Print()
    {
        
    }
    public void Move (ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow:
                row--;
                break;

            case ConsoleKey.DownArrow:
                row++;
                break;

            case ConsoleKey.LeftArrow:
                col--;
                break;

            case ConsoleKey.RightArrow:
                col++;
                break;
        }

        row = Math.Clamp(row, 0, height - 1);
        col = Math.Clamp(col, 0, width - 1);
    }
}