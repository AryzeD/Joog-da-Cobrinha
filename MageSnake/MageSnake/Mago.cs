using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace MageSnake
{
    internal class Mago
    {
        public int Lenght { get; private set; }

        public Point[] Location { get; private set; }

        public Mago()
        {
            Location = new Point[30 * 30];
            reset();
        }

        public void reset()
        {
            Lenght = 5;

            for (int i = 0; i < Lenght; i++)
            {
                Location[i].X = 12;
                Location[i].Y = 12;
            }
        }

        public void run()
        {
            for (int i = Lenght - 1; i > 0; i--)
            {
                Location[i] = Location[i - 1];
            }
        }

        public void up()
        {
            run();
            Location[0].Y--;
            if (Location[0].Y < 0)
            {
                Location[0].Y += 30;
            }
        }

        public void down()
        {
            run();
            Location[0].Y++;
            if (Location[0].Y > 29)
            {
                Location[0].Y -= 30;
            }
        }

        public void right()
        {
            run();
            Location[0].X++;
            if (Location[0].X > 29)
            {
                Location[0].X -= 30;
            }
        }

        public void left()
        {
            run();
            Location[0].X--;
            if (Location[0].X < 0)
            {
                Location[0].X += 30;
            }
        }

        public void find()
        {
            Lenght++;
        }
    }
}
