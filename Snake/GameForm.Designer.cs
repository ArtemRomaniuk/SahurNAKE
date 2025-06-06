namespace Snake
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            gameTimer = new System.Windows.Forms.Timer(components);
            gameBoard = new Panel();
            gameLabel = new Label();
            highscoreLabel = new Label();
            scoreLabel = new Label();
            highscore = new Label();
            score = new Label();
            playButton = new Button();
            speedBar = new TrackBar();
            speedLabel = new Label();
            speedTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)speedBar).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Interval = 200;
            gameTimer.Tick += gameLoop;
            // 
            // gameBoard
            // 
            gameBoard.BackColor = SystemColors.Control;
            gameBoard.BorderStyle = BorderStyle.FixedSingle;
            gameBoard.Location = new Point(12, 12);
            gameBoard.Name = "gameBoard";
            gameBoard.Size = new Size(610, 610);
            gameBoard.TabIndex = 0;
            gameBoard.Paint += gameBoard_Paint;
            // 
            // gameLabel
            // 
            gameLabel.AutoSize = true;
            gameLabel.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gameLabel.Location = new Point(639, 12);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new Size(192, 53);
            gameLabel.TabIndex = 1;
            gameLabel.Text = "SahurNAKE";
            // 
            // highscoreLabel
            // 
            highscoreLabel.AutoSize = true;
            highscoreLabel.Font = new Font("Poppins", 10.8F);
            highscoreLabel.Location = new Point(648, 88);
            highscoreLabel.Name = "highscoreLabel";
            highscoreLabel.Size = new Size(110, 31);
            highscoreLabel.TabIndex = 2;
            highscoreLabel.Text = "HighScore:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Poppins", 10.8F);
            scoreLabel.Location = new Point(648, 136);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(70, 31);
            scoreLabel.TabIndex = 2;
            scoreLabel.Text = "Score:";
            // 
            // highscore
            // 
            highscore.AutoSize = true;
            highscore.Font = new Font("Poppins", 10.8F);
            highscore.Location = new Point(764, 88);
            highscore.Name = "highscore";
            highscore.Size = new Size(47, 31);
            highscore.TabIndex = 2;
            highscore.Text = "999";
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Poppins", 10.8F);
            score.Location = new Point(764, 136);
            score.Name = "score";
            score.Size = new Size(25, 31);
            score.TabIndex = 2;
            score.Text = "0";
            // 
            // playButton
            // 
            playButton.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playButton.Location = new Point(679, 263);
            playButton.Name = "playButton";
            playButton.Size = new Size(110, 40);
            playButton.TabIndex = 3;
            playButton.TabStop = false;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // speedBar
            // 
            speedBar.AutoSize = false;
            speedBar.LargeChange = 1;
            speedBar.Location = new Point(648, 217);
            speedBar.Minimum = 1;
            speedBar.Name = "speedBar";
            speedBar.Size = new Size(163, 28);
            speedBar.TabIndex = 6;
            speedBar.TabStop = false;
            speedBar.TickStyle = TickStyle.None;
            speedBar.Value = 1;
            speedBar.ValueChanged += speedBar_ValueChanged;
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Font = new Font("Poppins", 10.8F);
            speedLabel.Location = new Point(648, 183);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(75, 31);
            speedLabel.TabIndex = 2;
            speedLabel.Text = "Speed:";
            // 
            // speedTextBox
            // 
            speedTextBox.Location = new Point(764, 183);
            speedTextBox.Name = "speedTextBox";
            speedTextBox.Size = new Size(35, 27);
            speedTextBox.TabIndex = 5;
            speedTextBox.TabStop = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 634);
            Controls.Add(playButton);
            Controls.Add(speedTextBox);
            Controls.Add(speedBar);
            Controls.Add(speedLabel);
            Controls.Add(scoreLabel);
            Controls.Add(score);
            Controls.Add(highscore);
            Controls.Add(highscoreLabel);
            Controls.Add(gameLabel);
            Controls.Add(gameBoard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "GameForm";
            Text = "SahurNAKE";
            KeyDown += GameForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)speedBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private Panel gameBoard;
        private Label gameLabel;
        private Label highscoreLabel;
        private Label scoreLabel;
        private Label highscore;
        private Label score;
        private Button playButton;
        private TrackBar speedBar;
        private Label speedLabel;
        private TextBox speedTextBox;
    }
}
