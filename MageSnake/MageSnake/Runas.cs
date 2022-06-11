using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageSnake
{
    internal class Runas
    {
        public Point Location { get; private set; }

        public void criarRunas()
        {
            Random aleatorio = new Random();
            Location = new Point(aleatorio.Next(0, 30), aleatorio.Next(0, 30));
        }

    }
}
