using GameOfLife.Models;

namespace GameOfLife.DataTransferObjects
{
    public static class BoardMapper
    {
        public static Board DTOtoBoard(BoardDTO boardDTO)
        {
            
            Board board = new Board();
            foreach (CellDTO cellDTO in boardDTO.Table) board.AddCell(DTOtoCell(cellDTO));
            return board;

        }
        public static Cell DTOtoCell(CellDTO cellDTO)
        {
            int[] coordinates = new int[] { cellDTO.PositionX, cellDTO.PositionY };
            return new Cell(coordinates, cellDTO.IsAlive);
        }

    }
}
