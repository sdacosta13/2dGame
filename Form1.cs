using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2dGame
{
    public partial class Form1 : Form
    {
        bool movingLeft = false, movingRight = false, movingUp = false, movingDown = false;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(DoThisAllTheTime);
            t.Start();
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
        public void DoThisAllTheTime()
        {
            while (true)
            {
                int x = 0;
                int y = 0;
                if (movingLeft)
                {
                    x -= 1;
                }
                if(movingRight)
                {
                    x += 1;
                }
                if (movingUp)
                {
                    y -= 1;
                }
                if(movingDown)
                {
                    y += 1;
                }
            }
        }
    }
}
