using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Food
    {
        public Point Location { get; private set; } = Point.Empty;
        private readonly Random random = new Random();
        public bool isFirstCreating = true;

        public void CreateNewLocation()
        {
            Location = GameForm.freeCells[random.Next(GameForm.freeCells.Count)];
        }

        public void ShowFood(Graphics g)
        {
            if (Location == Point.Empty) this.CreateNewLocation();
            g.FillEllipse(Brushes.Red, new Rectangle(Location.X, Location.Y, GameForm.CellSize, GameForm.CellSize));
        }
    }
}
