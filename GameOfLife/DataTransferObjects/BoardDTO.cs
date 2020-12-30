using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameOfLife.DataTransferObjects
{
    public class BoardDTO{
        [Required]
        public List<CellDTO> Table { set; get; }
    }
}
