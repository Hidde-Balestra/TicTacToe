using TicTacToe.controller;

namespace TicTacToe
{
    public partial class BoardScreen : Form
    {
        public BoardScreen()
        {
            InitializeComponent();
            board = new Board(this);
        }

        public Board board { get; }

        public void TicTacToeButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            board.SetMarkingPlayer(clickedButton);
        }
    }
}
