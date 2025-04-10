using TicTacToe.controller;

namespace TicTacToe
{
    public partial class BoardScreen : Form
    {
        private readonly Board Board;
        public BoardScreen()
        {
            InitializeComponent();
            board = new Board(this);
        }

        public Board board { get; private set; }

        public void TicTacToeButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            board.SetMarkingPlayer(clickedButton);
        }
    }
}
