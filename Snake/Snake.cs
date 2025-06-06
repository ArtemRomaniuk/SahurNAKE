using Snake.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake : IDisposable
    {
        private int boxSize = 20;
        private Panel gameBoard;
        private Panel snake;
        private PictureBox head;

        public Snake(Panel gameBoard, Image headImage)
        {
            this.gameBoard = gameBoard;
            snake = new Panel();
            snake.Location = new Point(4 + boxSize * 10, 4 + boxSize * 10);
            snake.Size = new Size(boxSize, boxSize);

            head = new PictureBox();
            head.Image = headImage;
            head.Size = new Size(boxSize, boxSize);
            head.Location = new Point(0, 0);
            head.SizeMode = PictureBoxSizeMode.StretchImage;
            snake.Controls.Add(head);

            gameBoard.Controls.Add(snake);
        }

        public void Dispose()
        {
            snake.Dispose();
        }

        public bool IsCloseToCollision(Direction direction)
        {
            if (direction == Direction.Left && snake.Location.X <= 4) return true;
            else if (direction == Direction.Up && snake.Location.Y <= 4) return true;
            else if (direction == Direction.Right && snake.Location.X + snake.Width >= gameBoard.ClientSize.Width - 4) return true;
            else if (direction == Direction.Down && snake.Location.Y + snake.Height >= gameBoard.ClientSize.Height - 4) return true;
            else return false;
        }

        public void Move(Direction direction)
        {
            if (direction == Direction.Up) snake.Location = new Point(snake.Location.X, snake.Location.Y - boxSize);
            else if (direction == Direction.Down) snake.Location = new Point(snake.Location.X, snake.Location.Y + boxSize);
            else if (direction == Direction.Left) snake.Location = new Point(snake.Location.X - boxSize, snake.Location.Y);
            else if (direction == Direction.Right) snake.Location = new Point(snake.Location.X + boxSize, snake.Location.Y);
        }
    }
}
