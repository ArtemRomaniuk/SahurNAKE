namespace Snake
{
    public partial class GameForm : Form
    {
        private Snake snake = null;
        private Keys pressedKey;

        public GameForm()
        {
            InitializeComponent();
        }

        private void gameLoop(object sender, EventArgs e)
        {
            switch (pressedKey)
            {
                case Keys.D:
                    if (snake.IsCloseToCollision(Direction.Right)) EndGame();
                    else snake.Move(Direction.Right);
                    break;

                case Keys.A:
                    if (snake.IsCloseToCollision(Direction.Left)) EndGame();
                    else snake.Move(Direction.Left);
                    break;

                case Keys.W:
                    if (snake.IsCloseToCollision(Direction.Up)) EndGame();
                    else snake.Move(Direction.Up);
                    break;

                case Keys.S:
                    if (snake.IsCloseToCollision(Direction.Down)) EndGame();
                    else snake.Move(Direction.Down);
                    break;

                default:
                    if (snake.IsCloseToCollision(Direction.Right)) EndGame();
                    else snake.Move(Direction.Right);
                    break;
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.W || e.KeyData == Keys.A || e.KeyData == Keys.S || e.KeyData == Keys.D) pressedKey = e.KeyData;
        }

        private void gameBoard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 4), 2, 2, gameBoard.ClientSize.Width - 4, gameBoard.ClientSize.Height - 4);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (snake == null)
            {
                snake = new Snake(gameBoard, Properties.Resources.sahur);
                gameTimer.Enabled = true;
            } else
            {
                gameTimer.Enabled = false;
                snake.Dispose();
                snake = null;
                snake = new Snake(gameBoard, Properties.Resources.sahur);
                gameTimer.Enabled = true;
            }
        }

        private void speedBar_ValueChanged(object sender, EventArgs e)
        {
            if (snake != null)
            {
                gameTimer.Interval = 200 / speedBar.Value;
            }
        }
       
        private void EndGame()
        {
            gameTimer.Stop();
            MessageBox.Show(
                "Game Over",
                "Game",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button1
                );
        }
    }
}
