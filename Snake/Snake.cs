using Snake.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Snake
{
    internal class Snake
    {
        private readonly Panel gameBoard;
        private readonly Bitmap head;
        public Point HeadLocation { get; private set; } = new Point(4 + GameForm.CellSize * (GameForm.CellWidth/3), 4 + GameForm.CellSize * (GameForm.CellHeight/2));
        private List<Point> body = new List<Point>();
        public Point OldTailLocation { get; private set; } = Point.Empty;

        public Snake(Panel gameBoard, Image headImage)
        {
            this.gameBoard = gameBoard;
            head = new Bitmap(headImage, new Size(GameForm.CellSize, GameForm.CellSize));
        }

        public void Draw(Graphics g, int x = -1, int y = -1)
        {
            if (x == -1)
            {
                x = HeadLocation.X;
                y = HeadLocation.Y;
            }
            g.DrawImage(head, x, y);
            foreach (Point cell in body)
            {
                g.FillRectangle(Brushes.ForestGreen, cell.X + 3, cell.Y + 3, GameForm.CellSize - 6, GameForm.CellSize - 6);
                g.DrawRectangle(new Pen(Color.Black, 2), cell.X + 3, cell.Y + 3, GameForm.CellSize - 6, GameForm.CellSize - 6);
            }
        }

        public bool IsCloseToCollision(Direction direction)
        {
            if (direction == Direction.Left && HeadLocation.X <= 4) return true;
            else if (direction == Direction.Up && HeadLocation.Y <= 4) return true;
            else if (direction == Direction.Right && HeadLocation.X + GameForm.CellSize >= gameBoard.ClientSize.Width - 4) return true;
            else if (direction == Direction.Down && HeadLocation.Y + GameForm.CellSize >= gameBoard.ClientSize.Height - 4) return true;
            else return false;
        }

        public bool IsCloseToTailCollision(Direction direction)
        {
            foreach (Point cell in body)
            {
                if (direction == Direction.Left && HeadLocation.X - cell.X == GameForm.CellSize && HeadLocation.Y == cell.Y) return true;
                else if (direction == Direction.Up && HeadLocation.Y - cell.Y == GameForm.CellSize && HeadLocation.X == cell.X) return true;
                else if (direction == Direction.Right && cell.X - HeadLocation.X == GameForm.CellSize && HeadLocation.Y == cell.Y) return true;
                else if (direction == Direction.Down && cell.Y - HeadLocation.Y == GameForm.CellSize && HeadLocation.X == cell.X) return true;
                else continue;
            }
            return false;
        }

        public void Move(Direction direction)
        {
            Point tempOldLocation;
            if (direction == Direction.Up)
            {
                OldTailLocation = HeadLocation;
                HeadLocation = new Point(HeadLocation.X, HeadLocation.Y - GameForm.CellSize);
                for (int i = 0; i < body.Count; i++)
                {
                    tempOldLocation = body[i];
                    body[i] = OldTailLocation;
                    OldTailLocation = tempOldLocation;
                }    
            }
            else if (direction == Direction.Down) 
            {
                OldTailLocation = HeadLocation;
                HeadLocation = new Point(HeadLocation.X, HeadLocation.Y + GameForm.CellSize);
                for (int i = 0; i < body.Count; i++)
                {
                    tempOldLocation = body[i];
                    body[i] = OldTailLocation;
                    OldTailLocation = tempOldLocation;
                }  
            }
            else if (direction == Direction.Left)
            {
                OldTailLocation = HeadLocation;
                HeadLocation = new Point(HeadLocation.X - GameForm.CellSize, HeadLocation.Y);
                for (int i = 0; i < body.Count; i++)
                {
                    tempOldLocation = body[i];
                    body[i] = OldTailLocation;
                    OldTailLocation = tempOldLocation;
                }
            }
            else if (direction == Direction.Right)
            {
                OldTailLocation = HeadLocation;
                HeadLocation = new Point(HeadLocation.X + GameForm.CellSize, HeadLocation.Y);
                for (int i = 0; i < body.Count; i++)
                {
                    tempOldLocation = body[i];
                    body[i] = OldTailLocation;
                    OldTailLocation = tempOldLocation;
                }
            }
        }

        public void Grow()
        {
            body.Add(OldTailLocation);
            GameForm.freeCells.Remove(OldTailLocation);
        }
    }
}
