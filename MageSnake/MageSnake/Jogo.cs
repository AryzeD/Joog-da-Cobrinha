using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MageSnake
{
    internal class Jogo
    {
        public Keys direcao { get; set; }

        public Keys comando { get; set; }

        private Timer Frame { get; set; }

        private Label lblPontuacao { get; set; }

        private Panel pnlRuneterra { get; set; }

        private int pontos = 0;

        private Runas Magia;
        private Mago Ryze;
        private Bitmap offScreenBitmap;
        private Graphics bitmapGraph;
        private Graphics screenGraph;

        public Jogo(ref Timer timer, ref Label label, ref Panel panel)
        {
            pnlRuneterra = panel;
            Frame = timer;
            lblPontuacao = label;
            offScreenBitmap = new Bitmap(550,550);
            Ryze = new Mago();
            Magia = new Runas();
            direcao = Keys.Left;
            comando = direcao;
        }

        public void iniciarJogo()
        {
            Ryze.reset();
            Magia.criarRunas();
            direcao = Keys.Left;
            bitmapGraph = Graphics.FromImage(offScreenBitmap);
            screenGraph = pnlRuneterra.CreateGraphics();
            Frame.Enabled = true;
        }

        public void tick()
        {
            if (((comando == Keys.Left) && (comando != Keys.Right)) ||
                ((comando == Keys.Right) && (comando != Keys.Left)) ||
                ((comando == Keys.Up) && (comando != Keys.Down)) ||
                ((comando == Keys.Down) && (comando != Keys.Up)))
            {
                direcao = comando;
            }

            switch (comando)
            {
                case Keys.Left:
                    Ryze.left();
                    break;
                case Keys.Right:
                    Ryze.right();
                    break;
                case Keys.Up:
                    Ryze.up();
                    break;
                case Keys.Down:
                    Ryze.down();
                    break;
            }

            bitmapGraph.Clear(Color.White);

            bitmapGraph.DrawImage(Properties.Resources.runas, (Magia.Location.X * 18), (Magia.Location.Y * 18), 18, 18);
            bool gameOver = false;

            for(int i = 0; i < Ryze.Lenght; i++)
            {
                if (i == 0)
                {
                    bitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#191970")), (Ryze.Location[i].X * 18), (Ryze.Location[i].Y * 18), 18, 18);
                }
                else
                {
                    bitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#0000CD")), (Ryze.Location[i].X * 18), (Ryze.Location[i].Y * 18), 18, 18);
                }

                if ((Ryze.Location[i] == Ryze.Location[0]) && (i > 0))
                {
                    gameOver = true;
                }
            }

            screenGraph.DrawImage(offScreenBitmap, 0, 0);
            checarColisao();
            if (gameOver)
            {
                GameOver();
            }
        }

        public void checarColisao()
        {
            if (Ryze.Location[0] == Magia.Location)
            {
                Ryze.find();
                Magia.criarRunas();
                pontos += 10;
                lblPontuacao.Text = $"{pontos}";
            }
        }

        public void GameOver()
        {
            Frame.Enabled = false;
            bitmapGraph.Dispose();
            screenGraph.Dispose();
            lblPontuacao.Text = $"{pontos}";
            MessageBox.Show("Game Over");
        }
    }
}
