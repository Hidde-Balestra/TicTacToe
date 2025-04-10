namespace TicTacToe
{
    public partial class WinScreen : Form
    {
        public WinScreen(string result)
        {
            InitializeComponent();
            ResultLabel.Text = result;
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
