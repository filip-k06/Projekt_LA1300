using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_game
{
    public partial class Form1 : Form
    {

            
        public Form1()
        {
            InitializeComponent();

            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void button2_Click(object sender, EventArgs e)
        {

            bool playAgain = true;
            while (true)
            {
                int livesLeft = 9;

                char[] input;
                string secretWords = "Schule,Laptop,Tische,lachen,nachts,qualle,radler,fabeln,echsen,daheim,fackel,üblich";
                string[] words = secretWords.Split(',');

                this.BackgroundImage = Properties.Resources.Hangman_0_7;
                button2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;

                textBox3.Visible = true;

                Random myObject = new Random();
                int ranNum = myObject.Next(0, 13);


                char[] characters = words[ranNum].ToCharArray();

                if (input[1] && input[2] && input[3] && input[4] && input[5] && input[6] = characters[1] || characters[2] || characters[3] || characters[4] || characters[5] || characters[6]) ;
                {
                    livesLeft--;
                }

               
                if (button1_Click)
                {
                    playAgain = true;
                }

                if (button3_Click)
                {
                    playAgain = false;
                    break;
                }
            
            }
        }

        private void label1_Click(object sender, EventArgs e)
        { 
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

       
    }

}
