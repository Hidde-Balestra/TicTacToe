namespace TicTacToe
{
    partial class WinScreen
    {
        private System.ComponentModel.IContainer components = null;
        private Label ResultLabel;
        private Button PlayAgainButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ResultLabel = new Label();
            this.PlayAgainButton = new Button();
            this.SuspendLayout();

            // ResultLabel
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(50, 30);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(35, 13);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "Result";

            // PlayAgainButton
            this.PlayAgainButton.Location = new System.Drawing.Point(50, 60);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(75, 23);
            this.PlayAgainButton.TabIndex = 1;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);

            // WinScreen
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.ResultLabel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinScreen";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}