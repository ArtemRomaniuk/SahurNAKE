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
            gameBoard = new DoubleBufferedPanel();
            gameLabel = new Label();
            highscoreLabel = new Label();
            scoreLabel = new Label();
            highscore = new Label();
            score = new Label();
            playButton = new Button();
            speedBar = new TrackBar();
            speedLabel = new Label();
            speedTextBox = new TextBox();
            BoardSizeLabel = new Label();
            SmallBoardRadioButton = new RadioButton();
            MediumBoardRadioButton = new RadioButton();
            BigBoardRadioButton = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)speedBar).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Interval = 300;
            gameTimer.Tick += gameLoop;
            // 
            // gameBoard
            // 
            gameBoard.BackColor = SystemColors.Control;
            gameBoard.Location = new Point(12, 12);
            gameBoard.Name = "gameBoard";
            gameBoard.Size = new Size(608, 608);
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
            highscore.Size = new Size(25, 31);
            highscore.TabIndex = 2;
            highscore.Text = "0";
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
            playButton.Location = new Point(679, 408);
            playButton.Name = "playButton";
            playButton.Size = new Size(110, 40);
            playButton.TabIndex = 1;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // speedBar
            // 
            speedBar.AutoSize = false;
            speedBar.LargeChange = 1;
            speedBar.Location = new Point(648, 217);
            speedBar.Maximum = 9;
            speedBar.Minimum = 1;
            speedBar.Name = "speedBar";
            speedBar.Size = new Size(163, 28);
            speedBar.TabIndex = 2;
            speedBar.TabStop = false;
            speedBar.TickStyle = TickStyle.None;
            speedBar.Value = 2;
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
            speedTextBox.DataBindings.Add(new Binding("Text", speedBar, "Value", true));
            speedTextBox.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            speedTextBox.Location = new Point(764, 177);
            speedTextBox.MaxLength = 1;
            speedTextBox.Name = "speedTextBox";
            speedTextBox.Size = new Size(22, 34);
            speedTextBox.TabIndex = 5;
            speedTextBox.TabStop = false;
            speedTextBox.TextAlign = HorizontalAlignment.Center;
            speedTextBox.Validating += speedTextBox_Validating;
            // 
            // BoardSizeLabel
            // 
            BoardSizeLabel.AutoSize = true;
            BoardSizeLabel.Font = new Font("Poppins", 10.8F);
            BoardSizeLabel.Location = new Point(648, 251);
            BoardSizeLabel.Name = "BoardSizeLabel";
            BoardSizeLabel.Size = new Size(109, 31);
            BoardSizeLabel.TabIndex = 2;
            BoardSizeLabel.Text = "Board size:";
            // 
            // SmallBoardRadioButton
            // 
            SmallBoardRadioButton.AutoSize = true;
            SmallBoardRadioButton.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SmallBoardRadioButton.Location = new Point(658, 285);
            SmallBoardRadioButton.Name = "SmallBoardRadioButton";
            SmallBoardRadioButton.Size = new Size(85, 35);
            SmallBoardRadioButton.TabIndex = 6;
            SmallBoardRadioButton.Text = "Small";
            SmallBoardRadioButton.UseVisualStyleBackColor = true;
            SmallBoardRadioButton.CheckedChanged += SmallBoardRadioButton_CheckedChanged;
            // 
            // MediumBoardRadioButton
            // 
            MediumBoardRadioButton.AutoSize = true;
            MediumBoardRadioButton.Checked = true;
            MediumBoardRadioButton.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MediumBoardRadioButton.Location = new Point(658, 326);
            MediumBoardRadioButton.Name = "MediumBoardRadioButton";
            MediumBoardRadioButton.Size = new Size(109, 35);
            MediumBoardRadioButton.TabIndex = 6;
            MediumBoardRadioButton.TabStop = true;
            MediumBoardRadioButton.Text = "Medium";
            MediumBoardRadioButton.UseVisualStyleBackColor = true;
            MediumBoardRadioButton.CheckedChanged += MediumBoardRadioButton_CheckedChanged;
            // 
            // BigBoardRadioButton
            // 
            BigBoardRadioButton.AutoSize = true;
            BigBoardRadioButton.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BigBoardRadioButton.Location = new Point(658, 367);
            BigBoardRadioButton.Name = "BigBoardRadioButton";
            BigBoardRadioButton.Size = new Size(62, 35);
            BigBoardRadioButton.TabIndex = 6;
            BigBoardRadioButton.Text = "Big";
            BigBoardRadioButton.UseVisualStyleBackColor = true;
            BigBoardRadioButton.CheckedChanged += BigBoardRadioButton_CheckedChanged;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 634);
            Controls.Add(BigBoardRadioButton);
            Controls.Add(MediumBoardRadioButton);
            Controls.Add(SmallBoardRadioButton);
            Controls.Add(playButton);
            Controls.Add(speedTextBox);
            Controls.Add(speedBar);
            Controls.Add(BoardSizeLabel);
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
        private DoubleBufferedPanel gameBoard;
        private Label gameLabel;
        private Label highscoreLabel;
        private Label scoreLabel;
        private Label highscore;
        private Label score;
        private Button playButton;
        private TrackBar speedBar;
        private Label speedLabel;
        private TextBox speedTextBox;
        private Label BoardSizeLabel;
        private RadioButton SmallBoardRadioButton;
        private RadioButton MediumBoardRadioButton;
        private RadioButton BigBoardRadioButton;
    }
}
