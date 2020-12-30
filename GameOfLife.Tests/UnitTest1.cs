using FluentAssertions;
using GameOfLife.Models;
using NUnit.Framework;

namespace Tests {
    public class Tests {
        [SetUp]
        public void Setup()
        {
        }

       [Test]
        public void Test_Cell() {
            int[] coordinates = new[] { 0, 0 };

            Cell cell = new Cell(coordinates, false);

            Cell expectedCell = new Cell(coordinates, false);
            cell.Should().Be(expectedCell);
        }

        [Test]
        public void TestGenerateBoard()
        {

            int[,] initialConfiguration =  { { 1, 1 }, { 0, 1 } };

            Board initial = new Board(initialConfiguration);

          
            initial.Should().Be(new Board(initialConfiguration));

        }
        [Test]
        public void TestBoardWithOneCellAlive()
        {
            Board board = new Board(new[,] { { 1 } });

            board.NextGeneration();

            Board expectedBoard = new Board(new int[,] { { 0 } });
            board.Should().Be(expectedBoard);
        }
        [Test]
        public void TestTwoCeldsAlive(){
            Board board = new Board(new[,] { { 1,1 } });

            board.NextGeneration();

            Board expectedBoard = new Board(new[,] { { 0,0 } });
            board.Should().Be(expectedBoard);
        }
        [Test]
        public void Test_Three_Cells_Alive()
        {
            Board board = new Board(new[,] { { 1, 1, 1 } });

            board.NextGeneration();

            Board expectedBoard = new Board(new[,] { { 0, 1, 0 } });
            board.Should().Be(expectedBoard);
        }

        [Test]
        public void TestThreeCellsAliveAndOneDead()
        { 
            Board board = new Board(new[,] { { 1, 1},{ 0, 1 } });

            board.NextGeneration();

            Board expectedBoard = new Board(new[,] { { 1, 1},{ 1, 1 } });
            board.Should().Be(expectedBoard);
        }

        [Test]
        public void TestFourCellsAlive()
        {
            Board board = new Board(new[,] { { 1, 1 }, { 1, 1 } });

            board.NextGeneration();

            Board expectedBoard = new Board(new[,] { { 1, 1 }, { 1, 1 } });
            board.Should().Be(expectedBoard);
        }

        [Test]
        public void Test2RowsAnd3ColumnsWithFiveCellsAlive()
        {
            Board board = new Board(new[,] { { 1, 1, 1 }, { 0, 1, 1 } });

            board.NextGeneration();

            Board expectedBoard = new Board(new[,] { { 1, 0, 1 }, { 1, 0, 1 } });
            board.Should().Be(expectedBoard);

        }

         [Test]
         public void Test3RowsAnd3ColumnsCellSWithThreeCellsAlive()
         {
            Board board = new Board(new[,] { { 0, 1, 0}, { 0, 1, 0 }, { 0, 1, 0} });

             board.NextGeneration();

             Board expectedBoard = new Board(new[,] { { 0, 0, 0}, { 1, 1, 1 }, { 0, 0, 0} });
             board.Should().Be(expectedBoard);

         }


    }
}