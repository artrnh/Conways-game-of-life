using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conway_s_game_of_life
{
    public partial class Form1 : Form
    {
        Game game;
        int generation;

        public Form1()
        {
            InitializeComponent();
            game = new Game();
            generation = 0;
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            game.NextGeneration();
            generation++;
            label1.Text = "Generation: " + generation;
            Invalidate();
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (drawTimer.Enabled)
            {
                drawTimer.Stop();
                play.Text = "Play";
            }
            else
            {
                drawTimer.Start();
                play.Text = "Pause";
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            game.ClickCell(e.X, e.Y);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            game.Clear();
            Invalidate();
            drawTimer.Stop();
            play.Text = "Play";
            generation = 0;
            label1.Text = "Generation: " + generation;
        }
    }
}
