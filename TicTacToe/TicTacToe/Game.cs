namespace TicTacToe;

public class Game
{
    private readonly char[,] _board;
        private char _currentPlayer;

        public Game()
        {
            _board = new char[3, 3];
            _currentPlayer = 'X';
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (var row = 0; row < 3; row++)
            {
                for (var col = 0; col < 3; col++)
                {
                    _board[row, col] = '-';
                }
            }
        }

        public void PrintBoard()
        {
            for (var row = 0; row < 3; row++)
            {
                Console.WriteLine($"{_board[row, 0]} | {_board[row, 1]} | {_board[row, 2]}");
                if (row < 2)
                {
                    Console.WriteLine("---------");
                }
            }
        }

        public bool Move(int row, int col)
        {
            if (row < 0 || row >= 3 || col < 0 || col >= 3 || _board[row, col] != '-')
            {
                return false;
            }

            _board[row, col] = _currentPlayer;
            NextPlayer();
            return true;
        }

        public bool CheckForWin()
        {
            return CheckRows() || CheckColumns() || CheckDiagonals();
        }

        private bool CheckRows()
        {
            for (var row = 0; row < 3; row++)
            {
                if (_board[row, 0] != '-' && _board[row, 0] == _board[row, 1] && _board[row, 1] == _board[row, 2])
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckColumns()
        {
            for (var col = 0; col < 3; col++)
            {
                if (_board[0, col] != '-' && _board[0, col] == _board[1, col] && _board[1, col] == _board[2, col])
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckDiagonals()
        {
            return (_board[0, 0] != '-' && _board[0, 0] == _board[1, 1] && _board[1, 1] == _board[2, 2]) ||
                   (_board[0, 2] != '-' && _board[0, 2] == _board[1, 1] && _board[1, 1] == _board[2, 0]);
        }

        public bool IsBoardFull()
        {
            for (var row = 0; row < 3; row++)
            {
                for (var col = 0; col < 3; col++)
                {
                    if (_board[row, col] == '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void NextPlayer()
        {
            _currentPlayer = (_currentPlayer == 'X') ? 'O' : 'X';
        }
}