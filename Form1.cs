using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            bool playAgain = true;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                
                int livesLeft = 9;

                string secretWords = "Schule,Laptop,Tische,lachen,nachts,qualle,radler,fabeln,echsen,daheim,fackel,üblich";
                string[] words = secretWords.Split(',');

                this.BackgroundImage = Properties.Resources.Hangman2;

                Random myObject = new Random();
                int ranNum = myObject.Next(0, 12);

                char[] characters = words[ranNum].ToCharArray();

                label1.Text = Convert.ToString(characters[0]);
                label2.Text = Convert.ToString(characters[1]);
                label3.Text = Convert.ToString(characters[2]);
                label4.Text = Convert.ToString(characters[3]);
                label5.Text = Convert.ToString(characters[4]);
                label6.Text = Convert.ToString(characters[5]);

                if (textBox1.Text == Convert.ToString(characters[0]))
                {
                    label1.Visible = true;
                }

                else if (textBox1.Text == Convert.ToString(characters[1]))
                {
                    label2.Visible = true;
                }

                else if(textBox1.Text == Convert.ToString(characters[2]))
                {
                    label3.Visible = true;

                }

                else if(textBox1.Text == Convert.ToString(characters[3]))
                {
                    label4.Visible = true;

                }

                else if(textBox1.Text == Convert.ToString(characters[4]))
                {
                    label5.Visible = true;

                }

                else if(textBox1.Text == Convert.ToString(characters[5]))
                {
                    label6.Visible = true;

                }

                // wenn eingabe falsch

                if(textBox1.Text != Convert.ToString(characters[0]))
                {
                    BackgroundImage = Properties.Resources.Hangman2;
                    label1.Visible = false;
                    livesLeft = -1;
                    label7.Text = Convert.ToString(livesLeft);
                   
                }

                else if(textBox1.Text != Convert.ToString(characters[1]))
                {
                    BackgroundImage = Properties.Resources.Hangman2;
                    label2.Visible = false;
                    livesLeft = -1;
                    label8.Text = Convert.ToString(livesLeft);
                }

                else if(textBox1.Text != Convert.ToString(characters[2]))
                {
                    BackgroundImage = Properties.Resources.Hangman2;
                    label3.Visible = false;
                    livesLeft = -1;
                    label8.Text = Convert.ToString(livesLeft);
                }

                else if(textBox1.Text != Convert.ToString(characters[3]))
                {
                    BackgroundImage = Properties.Resources.Hangman2;
                    label4.Visible = false;
                    livesLeft = -1;
                    label8.Text = Convert.ToString(livesLeft);
                }

                else if(textBox1.Text != Convert.ToString(characters[4]))
                {
                    BackgroundImage = Properties.Resources.Hangman2;
                    label5.Visible = false;
                    livesLeft = -1;
                    label7.Text = Convert.ToString(livesLeft);
                }

                else if(textBox1.Text != Convert.ToString(characters[5]))
                {
                    BackgroundImage = Properties.Resources.Hangman2;
                    label6.Visible = false;
                    livesLeft = -1;
                    label8.Text = Convert.ToString(livesLeft);
                }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}
s