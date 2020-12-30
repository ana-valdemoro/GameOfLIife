using System;

namespace GameOfLife.Models
{

    public class Cell
    {
        public Boolean IsAlive { set; get; }
        public int PositionX { set; get; }
        public int PositionY { set; get; }

        public Cell(int[] position, Boolean status)
        {
            IsAlive = status;
            PositionX = position[0];
            PositionY = position[1];
        }
        public CellDTO ToDTO() =>
            new CellDTO
            {
                IsAlive = IsAlive,
                PositionX = PositionX,
                PositionY = PositionY
            };
       
        public override string ToString()
        {
            return "{IsAlive:" + IsAlive.ToString() + ",PositionX:" + PositionX.ToString() + ",PositionY:" + PositionY.ToString() + "}";
        }
        public override bool Equals(object other)
        {
            return Equals(other as Cell);
        }

        public bool Equals(Cell otherCell)
        {
            return IsAlive.Equals(otherCell.IsAlive) && PositionX.Equals(otherCell.PositionX) && PositionY.Equals(otherCell.PositionY);
        }
    }

}