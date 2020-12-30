using System;
using System.ComponentModel.DataAnnotations;

namespace GameOfLife
{
    public class CellDTO{
        [Required]
        public Boolean IsAlive { set; get; }
        [Required]
        public int PositionX { set; get; }
        [Required]
        public int PositionY { set; get; }

    }
}
