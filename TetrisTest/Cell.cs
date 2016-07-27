namespace TetrisTest
{
    public class Cell
    {
        public int ColumnIndex { get; internal set; }
        public int RowIndex { get; internal set; }

        public Cell(int row, int column)
        {
            ColumnIndex = column;
            RowIndex = row;
        }
    }
}