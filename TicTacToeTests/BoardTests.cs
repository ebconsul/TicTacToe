using TicTacToe;
using Xunit;

namespace TicTacToeTests
{
    public class BoardTests
    {

        [Fact]
        public void CheckIfWinOrDraw_When_Line_Win_Player1()
        {
            //arrange
            var board = new Board();
            board.SelectSquare(0, 1);
            board.SelectSquare(1, 1);
            board.SelectSquare(2, 1);

            //act
            var result = board.CheckIfWinOrDraw();

            //assert
            Assert.Equal(1, result);

        }

        [Fact]
        public void CheckIfWinOrDraw_When_Column_Win_Player1()
        {
            //arrange
            var board = new Board();
            board.SelectSquare(0, 1);
            board.SelectSquare(3, 1);
            board.SelectSquare(6, 1);

            //act
            var result = board.CheckIfWinOrDraw();

            //assert
            Assert.Equal(1, result);

        }

        [Fact]
        public void CheckIfWinOrDraw_When_Diagonal_Win_Player1()
        {
            //arrange
            var board = new Board();
            board.SelectSquare(0, 1);
            board.SelectSquare(4, 1);
            board.SelectSquare(8, 1);

            //act
            var result = board.CheckIfWinOrDraw();

            //assert
            Assert.Equal(1, result);

        }

        [Fact]
        public void CheckIfWinOrDraw_When_Draw()
        {
            //arrange
            var board = new Board();
            board.SelectSquare(0, 1);
            board.SelectSquare(1, 1);
            board.SelectSquare(2, 2);
            board.SelectSquare(3, 2);
            board.SelectSquare(4, 2);
            board.SelectSquare(5, 1);
            board.SelectSquare(6, 1);
            board.SelectSquare(7, 1);
            board.SelectSquare(8, 2);

            //act
            var result = board.CheckIfWinOrDraw();

            //assert
            Assert.Equal(-1, result);

        }

        [Fact]
        public void CheckIfWinOrDraw_NotWin_When_Line_Or_Columns_Of_Zeros()
        {
            //arrange
            var board = new Board();

            //act
            var result = board.CheckIfWinOrDraw();

            //assert
            Assert.Equal(0, result);

        }

        [Fact]
        public void CheckIfWinOrDraw_When_Game_Not_Finished()
        {
            //arrange
            var board = new Board();
            board.SelectSquare(0, 1);
            board.SelectSquare(1, 1);
            board.SelectSquare(2, 2);
            board.SelectSquare(3, 2);
            board.SelectSquare(4, 2);
            board.SelectSquare(5, 1);
            board.SelectSquare(6, 1);
            board.SelectSquare(7, 1);

            //act
            var result = board.CheckIfWinOrDraw();

            //assert
            Assert.Equal(0, result);

        }

        [Fact]
        public void SelectSquare_When_FirstSquareSelected_Player1()
        {
            //arrange
            var board = new Board();
            board.SelectSquare(0, 1);

            //act
            var result = board.BoardStatus[0];

            //assert
            Assert.Equal(1, result);

        }
    }
}