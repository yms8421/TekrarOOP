using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Examples2.Models
{
    public class Game
    {
        public Game()
        {
            Boards = new List<Board>();
        }
        public List<Board> Boards { get; }
        public void CreateBoard(int colIndex, int rowIndex)
        {
            if (Boards.Count == 9)
            {
                return; //devamını çalıştırma methodu bitir
            }
            var b = new Board
            {
                ColumnIndex = colIndex,
                RowIndex = rowIndex
            };
            Boards.Add(b);
        }
    }
}
