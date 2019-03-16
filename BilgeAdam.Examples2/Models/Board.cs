using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Examples2.Models
{
    public class Board
    {
        public Board()
        {
            Cells = new List<Cell>();
        }
        public int ColumnIndex { get; set; }
        public int RowIndex { get; set; }
        public List<Cell> Cells { get; }
        public void CreateCell(int colIndex, int rowIndex)
        {
            if (Cells.Count == 9)
            {
                return; //devamını çalıştırma methodu bitir
            }
            var cell = new Cell
            {
                ColumnIndex = colIndex,
                RowIndex = rowIndex
            };
            Cells.Add(cell);
        }
    }
}
