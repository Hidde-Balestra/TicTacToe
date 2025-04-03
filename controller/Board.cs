using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe.controller
{
    public class Board
    {
        private Form1 playBoard;
        private List<int> playerMarkings = new();
        private List<int> computerMarkings = new();

        public Board(Form1 form)
        {
            playBoard = form;
        }

        public void SetMarkingPlayer(Button button)
        {
            playBoard.Show();
            SetMarkingComputer();
            button.Text = "X";
            playerMarkings.Add((int)button.Name[^1] - '0');
        }

        public void SetMarkingComputer()
        {
            Random random = new Random();
            int randomInt = random.Next(1, 10);

            while (playerMarkings.Contains(randomInt) || computerMarkings.Contains(randomInt)) {
                randomInt = random.Next(1, 10);
            }

            Button? randomButton = playBoard.Controls["TicTacToeButton" + randomInt] as Button;

            if (randomButton == null) return;

            computerMarkings.Add(randomInt);
            MessageBox.Show($"Willekeurig getal: {randomInt} {string.Join(",", playerMarkings)}");

            randomButton.Text = "O";
        }
    }
}