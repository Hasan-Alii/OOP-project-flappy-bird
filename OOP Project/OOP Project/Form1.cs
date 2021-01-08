using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Form1 : Form
    {
        int BirdSpeed = 8;
        int gravity = 0;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            gameMenu.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void gameTimerEvent(object sender, EventArgs e)
        {
            
            flappyBird.Top = flappyBird.Top + gravity;
            pipeTop.Left -= BirdSpeed;
            pipeButtom.Left -= BirdSpeed;
            scoreText.Text = "Score: " + score ;

            if (pipeTop.Left < -95)
            {
                pipeTop.Left = 850;
                score++;
            }
            if (pipeButtom.Left < -90)
            {
                pipeButtom.Left = 780;
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(pipeButtom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds)    ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds)     ||
                flappyBird.Top < -10 )
            {
                endgame();
            }
            if (score>6)
            {
                BirdSpeed = 14;
            }
            if (score > 25)
            {
                BirdSpeed = 20;
            }
            if (score > 40)
            {
                BirdSpeed = 25;
            }
        }

        private void DownKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = -11;
            }
        }

        private void UpKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 11;
            }
        }
        
        private void lbl_restart_Click(object sender, EventArgs e)
        {
            gameMenu.Hide();
            gameTimer.Start();
            flappyBird.Location = new Point(91, 273);
            pipeTop.Location = new Point(589, -16);
            pipeButtom.Location = new Point(448, 405);
            score = 0;
            BirdSpeed = 8;
            gravity = 0;
        }


        private void lbl_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void endgame()
        {
            gameTimer.Stop();
            gameMenu.Show();
            textBox1.Text = Convert.ToString("High score: " + score);

        }


    }
}
