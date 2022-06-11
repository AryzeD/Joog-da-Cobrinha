using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MageSnake
{
    public partial class Form1 : Form
    {
        Jogo jogo;
        public Form1()
        {
            InitializeComponent();
            jogo = new Jogo(ref Frame, ref lblPontuacao, ref pnlRuneterra);
        }

        private void strpMnuRestart_Click(object sender, EventArgs e)
        {
            jogo.iniciarJogo();
        }

        private void strpMenuGiveUp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frame_Tick(object sender, EventArgs e)
        {
            jogo.tick();
        }

        private void clicado(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                jogo.comando = e.KeyCode;
            }
        }
    }
}
