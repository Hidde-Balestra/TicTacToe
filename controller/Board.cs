namespace TicTacToe.controller
{
    public class Board
    {
        private TicTacToe.BoardScreen playBoard;
        private List<int> playerMarkings = new List<int>();
        private List<int> computerMarkings = new List<int>();
        // Define winning combinations (1-9 positions in 3x3 grid)
        private readonly int[,] winningCombinations = new int[,]
        {
            {1, 2, 3}, {4, 5, 6}, {7, 8, 9}, // Rows
            {1, 4, 7}, {2, 5, 8}, {3, 6, 9}, // Columns
            {1, 5, 9}, {3, 5, 7}            // Diagonals
        };

        public Board(TicTacToe.BoardScreen form)
        {
            playBoard = form;
        }

        public bool SetMarkingPlayer(Button button)
        {
            playBoard.Show();
            button.Text = "X";
            button.Enabled = false;
            int position = (int)button.Name[^1] - '0';
            playerMarkings.Add(position);

            // Check if player won
            if (CheckWin(playerMarkings))
            {
                ShowWinScreen("Player wins!");
                return true;
            }

            // Check if it's a draw
            if (IsDraw())
            {
                ShowWinScreen("It's a draw!");
                return true;
            }

            SetMarkingComputer();
            return false;
        }

        public bool SetMarkingComputer()
        {
            int bestMove = FindBestMove();

            Button? randomButton = playBoard.Controls["TicTacToeButton" + bestMove] as Button;

            if (randomButton == null) return false;

            computerMarkings.Add(bestMove);
            randomButton.Text = "O";
            randomButton.Enabled = false;

            // Check if computer won
            if (CheckWin(computerMarkings))
            {
                ShowWinScreen("Computer wins!");
                return true;
            }

            // Check if it's a draw
            if (IsDraw())
            {
                ShowWinScreen("It's a draw!");
                return true;
            }

            return false;
        }

        private bool CheckWin(List<int> markings)
        {
            // Check each winning combination
            for (int i = 0; i < winningCombinations.GetLength(0); i++)
            {
                bool hasWon = true;
                for (int j = 0; j < 3; j++)
                {
                    if (!markings.Contains(winningCombinations[i, j]))
                    {
                        hasWon = false;
                        break;
                    }
                }
                if (hasWon) return true;
            }
            return false;
        }

        private bool IsDraw()
        {
            // If total markings is 9 and no one has won, it's a draw
            return (playerMarkings.Count + computerMarkings.Count) == 9;
        }

        private void ShowWinScreen(string result)
        {
            playBoard.Hide();

            using (WinScreen winScreen = new WinScreen(result))
            {
                winScreen.ShowDialog();
            }

            ResetGame();
            playBoard.Show();
        }

        public void ResetGame()
        {
            playerMarkings.Clear();
            computerMarkings.Clear();
            foreach (Control control in playBoard.Controls)
            {
                if (control is Button button && button.Name.StartsWith("TicTacToeButton"))
                {
                    button.Text = "";
                    button.Enabled = true;
                }
            }
        }

        private int FindBestMove()
        {
            for (int i = 1; i <= 9; i++)
            {
                if (!playerMarkings.Contains(i) && !computerMarkings.Contains(i))
                {
                    List<int> tempMarkings = new List<int>(computerMarkings) { i };
                    if (CheckWin(tempMarkings))
                        return i;
                }
            }

            //center
            if (!playerMarkings.Contains(5) && !computerMarkings.Contains(5))
                return 5;

            //corner
            int[] corners = { 1, 3, 7, 9 };
            foreach (int corner in corners)
            {
                if (!playerMarkings.Contains(corner) && !computerMarkings.Contains(corner))
                    return corner;
            }

            //Take any spot
            for (int i = 1; i <= 9; i++)
            {
                if (!playerMarkings.Contains(i) && !computerMarkings.Contains(i))
                    return i;
            }

            return -1;
        }
    }
}