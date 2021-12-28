
namespace Tetris4
{
    public class GameGrid
    {
        // 2 dimensional array, first dim is row, second is column
        private readonly int[,] grid;

        // properties for the number of rows and columns
        public int Rows { get; }
        public int Columns { get; }

        // intedex to provide access to array
        // to use indexing directly on a game grid object
        public int this[int r, int c]
        {
            get => grid[r, c];
            set => grid[r, c] = value;
        }

        // Constructor to use num of rows and columns as perimeters
        public GameGrid(int rows, int columns)
        {
            Rows = rows;
            columns = columns;
            grid = new int[rows, columns];
        }

        //method to check if a given row or column is inside the grid or not

        public bool IsInside(int r, int c)
        {
            return r >= 0 && r < Rows && c >= 0 && c < Columns;
        }

        //method to check if a given cell is empty or not

        public bool IsEmpty(int r, int c)
        {
            return IsInside(r, c) && grid[r, c] == 0;
        }

        //method to check if entire row is full

        public bool IsRowFull(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                if (grid[r,c] == 0)
                {
                    return false;
                }
            }

            return true;
        }

        //method to check if entire row is empty
        public bool IsRowEmpty(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                if (grid[r,c] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
