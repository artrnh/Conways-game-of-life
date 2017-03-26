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

        private void blinker_Click(object sender, EventArgs e)
        {
            game.Clear();
            Invalidate();
            drawTimer.Stop();
            play.Text = "Play";
            generation = 0;
            label1.Text = "Generation: " + generation;

            game.setCellAlive(24, 23);
            game.setCellAlive(24, 24);
            game.setCellAlive(24, 25);
        }

        private void Glider_Click(object sender, EventArgs e)
        {
            game.Clear();
            Invalidate();
            drawTimer.Stop();
            play.Text = "Play";
            generation = 0;
            label1.Text = "Generation: " + generation;

            game.setCellAlive(1, 2);
            game.setCellAlive(2, 3);
            game.setCellAlive(3, 1);
            game.setCellAlive(3, 2);
            game.setCellAlive(3, 3);
        }

        private void dieHard_Click(object sender, EventArgs e)
        {
            game.Clear();
            Invalidate();
            drawTimer.Stop();
            play.Text = "Play";
            generation = 0;
            label1.Text = "Generation: " + generation;

            game.setCellAlive(23, 28);
            game.setCellAlive(24, 22);
            game.setCellAlive(24, 23);
            game.setCellAlive(25, 23);
            game.setCellAlive(25, 27);
            game.setCellAlive(25, 28);
            game.setCellAlive(25, 29);
        }

        private void Pulsar_Click(object sender, EventArgs e)
        {
            game.Clear();
            Invalidate();
            drawTimer.Stop();
            play.Text = "Play";
            generation = 0;
            label1.Text = "Generation: " + generation;

            game.setCellAlive(19, 21);
            game.setCellAlive(19, 22);
            game.setCellAlive(19, 23);
            game.setCellAlive(19, 27);
            game.setCellAlive(19, 28);
            game.setCellAlive(19, 29);
            game.setCellAlive(24, 21);
            game.setCellAlive(24, 22);
            game.setCellAlive(24, 23);
            game.setCellAlive(24, 27);
            game.setCellAlive(24, 28);
            game.setCellAlive(24, 29);
            game.setCellAlive(26, 21);
            game.setCellAlive(26, 22);
            game.setCellAlive(26, 23);
            game.setCellAlive(26, 27);
            game.setCellAlive(26, 28);
            game.setCellAlive(26, 29);
            game.setCellAlive(31, 21);
            game.setCellAlive(31, 22);
            game.setCellAlive(31, 23);
            game.setCellAlive(31, 27);
            game.setCellAlive(31, 28);
            game.setCellAlive(31, 29);

            game.setCellAlive(21, 19);
            game.setCellAlive(22, 19);
            game.setCellAlive(23, 19);
            game.setCellAlive(27, 19);
            game.setCellAlive(28, 19);
            game.setCellAlive(29, 19);
            game.setCellAlive(21, 24);
            game.setCellAlive(22, 24);
            game.setCellAlive(23, 24);
            game.setCellAlive(27, 24);
            game.setCellAlive(28, 24);
            game.setCellAlive(29, 24);
            game.setCellAlive(21, 26);
            game.setCellAlive(22, 26);
            game.setCellAlive(23, 26);
            game.setCellAlive(27, 26);
            game.setCellAlive(28, 26);
            game.setCellAlive(29, 26);
            game.setCellAlive(21, 31);
            game.setCellAlive(22, 31);
            game.setCellAlive(23, 31);
            game.setCellAlive(27, 31);
            game.setCellAlive(28, 31);
            game.setCellAlive(29, 31);
        }

        private void Shuriken_Click(object sender, EventArgs e)
        {
            game.Clear();
            Invalidate();
            drawTimer.Stop();
            play.Text = "Play";
            generation = 0;
            label1.Text = "Generation: " + generation;

            game.setCellAlive(20, 26);
            game.setCellAlive(20, 27);
            game.setCellAlive(21, 23);
            game.setCellAlive(22, 22);
            game.setCellAlive(22, 24);
            game.setCellAlive(22, 27);
            game.setCellAlive(22, 28);
            game.setCellAlive(23, 20);
            game.setCellAlive(23, 22);
            game.setCellAlive(23, 24);
            game.setCellAlive(23, 25);
            game.setCellAlive(23, 26);
            game.setCellAlive(23, 29);
            game.setCellAlive(24, 20);
            game.setCellAlive(24, 23);
            game.setCellAlive(24, 24);
            game.setCellAlive(24, 25);
            game.setCellAlive(24, 26);
            game.setCellAlive(24, 27);
            game.setCellAlive(24, 28);
            game.setCellAlive(25, 23);
            game.setCellAlive(25, 24);
            game.setCellAlive(25, 26);
            game.setCellAlive(25, 27);
            game.setCellAlive(26, 22);
            game.setCellAlive(26, 23);
            game.setCellAlive(26, 24);
            game.setCellAlive(26, 25);
            game.setCellAlive(26, 26);
            game.setCellAlive(26, 27);
            game.setCellAlive(26, 30);
            game.setCellAlive(27, 21);
            game.setCellAlive(27, 24);
            game.setCellAlive(27, 25);
            game.setCellAlive(27, 26);
            game.setCellAlive(27, 28);
            game.setCellAlive(27, 30);
            game.setCellAlive(28, 22);
            game.setCellAlive(28, 23);
            game.setCellAlive(28, 26);
            game.setCellAlive(28, 28);
            game.setCellAlive(29, 27);
            game.setCellAlive(30, 23);
            game.setCellAlive(30, 24);
        }

        private void Toad_Click(object sender, EventArgs e)
        {
            game.Clear();
            Invalidate();
            drawTimer.Stop();
            play.Text = "Play";
            generation = 0;
            label1.Text = "Generation: " + generation;

            game.setCellAlive(24, 23);
            game.setCellAlive(24, 24);
            game.setCellAlive(24, 25);
            game.setCellAlive(23, 24);
            game.setCellAlive(23, 25);
            game.setCellAlive(23, 26);
        }
    }
}
