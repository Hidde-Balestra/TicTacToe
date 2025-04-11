namespace TicTacToe
{
    partial class BoardScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TicTacToeButton1 = new Button();
            TicTacToeButton2 = new Button();
            TicTacToeButton3 = new Button();
            TicTacToeButton4 = new Button();
            TicTacToeButton5 = new Button();
            TicTacToeButton6 = new Button();
            TicTacToeButton7 = new Button();
            TicTacToeButton8 = new Button();
            TicTacToeButton9 = new Button();
            SuspendLayout();
            // 
            // TicTacToeButton1
            // 
            TicTacToeButton1.Location = new Point(58, 105);
            TicTacToeButton1.Name = "TicTacToeButton1";
            TicTacToeButton1.Size = new Size(60, 65);
            TicTacToeButton1.TabIndex = 0;
            TicTacToeButton1.UseVisualStyleBackColor = true;
            TicTacToeButton1.Click += TicTacToeButtonClick;
            // 
            // TicTacToeButton2
            // 
            TicTacToeButton2.Location = new Point(124, 105);
            TicTacToeButton2.Name = "TicTacToeButton2";
            TicTacToeButton2.Size = new Size(60, 65);
            TicTacToeButton2.TabIndex = 1;
            TicTacToeButton2.UseVisualStyleBackColor = true;
            TicTacToeButton2.Click += TicTacToeButtonClick;
            // 
            // TicTacToeButton3
            // 
            TicTacToeButton3.Location = new Point(190, 105);
            TicTacToeButton3.Name = "TicTacToeButton3";
            TicTacToeButton3.Size = new Size(60, 65);
            TicTacToeButton3.TabIndex = 2;
            TicTacToeButton3.UseVisualStyleBackColor = true;
            TicTacToeButton3.Click += TicTacToeButtonClick;
            // 
            // TicTacToeButton4
            // 
            TicTacToeButton4.Location = new Point(58, 176);
            TicTacToeButton4.Name = "TicTacToeButton4";
            TicTacToeButton4.Size = new Size(60, 65);
            TicTacToeButton4.TabIndex = 3;
            TicTacToeButton4.UseVisualStyleBackColor = true;
            TicTacToeButton4.Click += TicTacToeButtonClick;
            // 
            // TicTacToeButton5
            // 
            TicTacToeButton5.Location = new Point(124, 176);
            TicTacToeButton5.Name = "TicTacToeButton5";
            TicTacToeButton5.Size = new Size(60, 65);
            TicTacToeButton5.TabIndex = 4;
            TicTacToeButton5.UseVisualStyleBackColor = true;
            TicTacToeButton5.Click += TicTacToeButtonClick;
            // 
            // TicTacToeButton6
            // 
            TicTacToeButton6.Location = new Point(190, 176);
            TicTacToeButton6.Name = "TicTacToeButton6";
            TicTacToeButton6.Size = new Size(60, 65);
            TicTacToeButton6.TabIndex = 5;
            TicTacToeButton6.UseVisualStyleBackColor = true;
            TicTacToeButton6.Click += TicTacToeButtonClick;
            // 
            // TicTacToeButton7
            // 
            TicTacToeButton7.Location = new Point(58, 247);
            TicTacToeButton7.Name = "TicTacToeButton7";
            TicTacToeButton7.Size = new Size(60, 65);
            TicTacToeButton7.TabIndex = 6;
            TicTacToeButton7.UseVisualStyleBackColor = true;
            TicTacToeButton7.Click += TicTacToeButtonClick;
            // 
            // TicTacToeButton8
            // 
            TicTacToeButton8.Location = new Point(124, 247);
            TicTacToeButton8.Name = "TicTacToeButton8";
            TicTacToeButton8.Size = new Size(60, 65);
            TicTacToeButton8.TabIndex = 7;
            TicTacToeButton8.UseVisualStyleBackColor = true;
            TicTacToeButton8.Click += TicTacToeButtonClick;
            // 
            // TicTacToeButton9
            // 
            TicTacToeButton9.Location = new Point(190, 247);
            TicTacToeButton9.Name = "TicTacToeButton9";
            TicTacToeButton9.Size = new Size(60, 65);
            TicTacToeButton9.TabIndex = 8;
            TicTacToeButton9.UseVisualStyleBackColor = true;
            TicTacToeButton9.Click += TicTacToeButtonClick;
            // 
            // BoardScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 370);
            Controls.Add(TicTacToeButton9);
            Controls.Add(TicTacToeButton8);
            Controls.Add(TicTacToeButton7);
            Controls.Add(TicTacToeButton6);
            Controls.Add(TicTacToeButton5);
            Controls.Add(TicTacToeButton4);
            Controls.Add(TicTacToeButton3);
            Controls.Add(TicTacToeButton2);
            Controls.Add(TicTacToeButton1);
            Name = "BoardScreen";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
        }

        #endregion
        private Button TicTacToeButton2;
        private Button TicTacToeButton3;
        private Button TicTacToeButton4;
        private Button TicTacToeButton5;
        private Button TicTacToeButton6;
        private Button TicTacToeButton7;
        private Button TicTacToeButton8;
        private Button TicTacToeButton9;
        private Button TicTacToeButton1;
    }
}
