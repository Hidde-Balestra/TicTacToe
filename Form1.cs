using TicTacToe.controller;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private readonly Board Board;
        public Form1()
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
