using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8ball
{
    public partial class Form1 : Form
    {
        int ballNumber;

        public Form1()
        {
            InitializeComponent();
            Random randgen = new Random();
            ballNumber = randgen.Next(1, 7);
        }

        private void ballButton_Click(object sender, EventArgs e)
        {

            switch (ballNumber)
            {
                case 1:
                    outputLabel.Text = "Sure";
                    break;

                case 2:
                    outputLabel.Text = "Maybe";
                    break;

                case 3:
                    outputLabel.Text = "I'm not sure";
                    break;

                case 4:
                    outputLabel.Text = "Why not";
                    break;

                case 5:
                    outputLabel.Text = "Nope";
                    break;

                case 6:
                    outputLabel.Text = "What do you think";
                    break;



            }

        }
    }
}
