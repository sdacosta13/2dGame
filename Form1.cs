using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace _2dGame
{
    public partial class Form1 : Form
    {
        bool movingLeft = false, movingRight = false, movingUp = false, movingDown = false;
        bool exitCondition = true;
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            exitCondition = false;
        }


        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                movingUp = true;
            }
            else if(e.KeyCode == Keys.S)
            {
                movingDown = true;
            }
            else if(e.KeyCode == Keys.A)
            {
                movingLeft = true;
            }
            else if(e.KeyCode == Keys.D)
            {
                movingRight = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                movingUp = false;
            }
            else if (e.KeyCode == Keys.S)
            {
                movingDown = false;
            }
            else if (e.KeyCode == Keys.A)
            {
                movingLeft = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                movingRight = false;
            }
        }

        private void MainGameTimer(object sender, EventArgs e)
        {
            updatePos();
        }
        public void updatePos()
        {

            int x = 0;
            int y = 0;
            if (movingLeft)
            {
                x -= 10;
            }
            if(movingRight)
            {
                x += 10;
            }
            if (movingUp)
            {
                y -= 10;
            }
            if(movingDown)
            {
                y += 10;
            }
            Debug.WriteLine("Y0");
            player.Left += x;
            if(player.Location.X < 0 || player.Location.X > 1920)
            {
                player.Left -= x;
            }
            player.Top += y;
            if (player.Location.Y < 0 || player.Location.Y > 1080)
            {
                player.Top -= y;
            }

        }
    }
}
