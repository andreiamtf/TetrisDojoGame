using System.Collections.Generic;

namespace TetrisTest
{
    public class Playfield
    {
        public List<List<Cell>> Field { get; set; }
        public int Rows { get; internal set; }
        public int Columns { get; internal set; }

        public void Initialise()
        {
            Rows = 22;
            Columns = 10;
            Field = new List<List<Cell>>(Rows) { };

            for (int i = 0; i < Columns; i++)
            {
                var row = new List<Cell>();
                for (int j = 0; j < Rows; j++)
                {
                    row.Add(new Cell(i, j));
                }
                Field.Add(row);
            }
        }
    }
}