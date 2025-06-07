using System.ComponentModel;

namespace Snake
{
    public partial class GameForm : Form
    {
        // default gameBoard 30x30
        public readonly int defaultInterval;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static int CellSize { get; private set; } = 30;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static int CellWidth { get; private set; } = 600 / CellSize;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static int CellHeight { get; private set; } = 600 / CellSize;
        private Snake snake = null;
        private Food food = null;
        public static List<Point> freeCells;
        private Keys pressedKey = Keys.D;
        private Keys currentKey = Keys.D;

        public GameForm()
        {
            InitializeComponent();
            RefreshBoardCells(30);
            defaultInterval = gameTimer.Interval;
        }

        private void gameLoop(object sender, EventArgs e)
        {
            currentKey = pressedKey;
            switch (currentKey)
            {
                case Keys.D:
                    if (snake.IsCloseToCollision(Direction.Right) || snake.IsCloseToTailCollision(Direction.Right)) EndGame();
                    else
                    {
                        snake.Move(Direction.Right);
                        freeCells.Remove(snake.HeadLocation);
                        freeCells.Add(snake.OldTailLocation);
                    }
                    break;

                case Keys.A:
                    if (snake.IsCloseToCollision(Direction.Left) || snake.IsCloseToTailCollision(Direction.Left)) EndGame();
                    else
                    {
                        snake.Move(Direction.Left);
                        freeCells.Remove(snake.HeadLocation);
                        freeCells.Add(snake.OldTailLocation);
                    }
                    break;

                case Keys.W:
                    if (snake.IsCloseToCollision(Direction.Up) || snake.IsCloseToTailCollision(Direction.Up)) EndGame();
                    else
                    {
                        snake.Move(Direction.Up);
                        freeCells.Remove(snake.HeadLocation);
                        freeCells.Add(snake.OldTailLocation);
                    }
                    break;

                case Keys.S:
                    if (snake.IsCloseToCollision(Direction.Down) || snake.IsCloseToTailCollision(Direction.Down)) EndGame();
                    else
                    {
                        snake.Move(Direction.Down);
                        freeCells.Remove(snake.HeadLocation);
                        freeCells.Add(snake.OldTailLocation);
                    }
                    break;
            }
            gameBoard.Invalidate();
        }

        private void gameBoard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using Pen pen = new Pen(Color.Black, 4);
            e.Graphics.DrawRectangle(pen, 2, 2, gameBoard.ClientSize.Width - 5, gameBoard.ClientSize.Height - 5);

            e.Graphics.DrawRectangle(Pens.Black, 10, 10, 0, 0);
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0) e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(10, 0, 0, 0)), 4 + CellSize * i, 4 + CellSize * j, CellSize, CellSize);
                    if (i % 2 == 1 && j % 2 == 1) e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(10, 0, 0, 0)), 4 + CellSize * i, 4 + CellSize * j, CellSize, CellSize);
                }
            }

            snake?.Draw(e.Graphics);
            if ((food != null && snake != null) && (snake.HeadLocation == food.Location || food.isFirstCreating))
            {
                if (food.isFirstCreating) food.isFirstCreating = false;
                else
                {
                    snake.Grow();
                    score.Text = Convert.ToString(int.Parse(score.Text) + 1);
                }
                food.CreateNewLocation();
                freeCells.Remove(food.Location);
            }
            food?.ShowFood(e.Graphics);
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == Keys.W && currentKey != Keys.S) ||
                (e.KeyData == Keys.S && currentKey != Keys.W) ||
                (e.KeyData == Keys.A && currentKey != Keys.D) ||
                (e.KeyData == Keys.D && currentKey != Keys.A))
                pressedKey = e.KeyData;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            EnableSettingsControls(false);

            gameTimer.Enabled = false;
            snake = new Snake(gameBoard, Properties.Resources.sahur);
            score.Text = "0";
            speedBar_ValueChanged(null, null);
            food = new Food();
            gameTimer.Enabled = true;
        }

        private void speedBar_ValueChanged(object sender, EventArgs e)
        {
            if (snake != null) gameTimer.Interval = defaultInterval / speedBar.Value;
        }

        private void EndGame()
        {
            gameTimer.Stop();
            snake = null;
            food = null;
            EnableSettingsControls(true);

            if (int.Parse(score.Text) > int.Parse(highscore.Text)) highscore.Text = score.Text;
            MessageBox.Show(
                "Game Over",
                "Game",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button1
                );
        }

        private void EnableSettingsControls(bool isEnabled)
        {
            speedBar.Enabled = isEnabled;
            speedTextBox.Enabled = isEnabled;
            SmallBoardRadioButton.Enabled = isEnabled;
            MediumBoardRadioButton.Enabled = isEnabled;
            BigBoardRadioButton.Enabled = isEnabled;
            playButton.Enabled = isEnabled;
        }

        private void speedTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(speedTextBox.Text, out int result) || (int.TryParse(speedTextBox.Text, out result) && (result < 1 || result > 9)))
                speedTextBox.Text = "2";
        }

        private void SmallBoardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshBoardCells(20);
        }

        private void MediumBoardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshBoardCells(30);
        }

        private void BigBoardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshBoardCells(40);
        }

        private void RefreshBoardCells(int cellSize)
        {
            CellSize = cellSize;
            CellWidth = 600 / CellSize;
            CellHeight = 600 / CellSize;
            freeCells = new List<Point>();
            for (int i = 0; i < CellWidth; i++)
                for (int j = 0; j < CellHeight; j++)
                    freeCells.Add(new Point(4 + CellSize * i, 4 + CellSize * j));
            gameBoard.Invalidate();
        }
    }
}
