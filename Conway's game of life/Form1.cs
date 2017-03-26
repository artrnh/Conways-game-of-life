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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.NextGeneration();
            generation++;
            label1.Text = "Generation: " + generation;
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button1.Text = "Play";
            }
            else
            {
                timer1.Start();
                button1.Text = "Pause";
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
        }
    }
}
