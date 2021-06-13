using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        String slowo;
        int ile_pudel = 0;
        public Form1()
        {
            InitializeComponent();
            losuj_slowo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string litera = textBox1.Text;
            bool czy_trafiony = false;
            int gdzie_trafiony = 0;
            if (ile_pudel < 5)
            {
                for (int i = 1; i < 6; i++)
                {
                    if (Convert.ToString(slowo[i]) == litera)
                    {
                        czy_trafiony = true;
                        gdzie_trafiony = i;
                    }
                    if (gdzie_trafiony == 1) { label2.Text = litera; }
                    if (gdzie_trafiony == 2) { label3.Text = litera; }
                    if (gdzie_trafiony == 3) { label4.Text = litera; }
                    if (gdzie_trafiony == 4) { label5.Text = litera; }
                    if (gdzie_trafiony == 5) { label6.Text = litera; }
                }

                if (czy_trafiony == false)
                {
                    ile_pudel++;
                    if (ile_pudel == 1) { pictureBox2.Image = Hangman.Properties.Resources.B; }
                    if (ile_pudel == 2) { pictureBox2.Image = Hangman.Properties.Resources.C; }
                    if (ile_pudel == 3) { pictureBox2.Image = Hangman.Properties.Resources.D; }
                    if (ile_pudel == 4) { pictureBox2.Image = Hangman.Properties.Resources.E; }
                    if (ile_pudel == 5) { pictureBox2.Image = Hangman.Properties.Resources.F; }
                    if (ile_pudel == 6) { pictureBox2.Image = Hangman.Properties.Resources.G; }
                    if (ile_pudel == 7) { pictureBox2.Image = Hangman.Properties.Resources.H; }
                    if (ile_pudel == 8) { pictureBox2.Image = Hangman.Properties.Resources.I; }
                    if (ile_pudel == 9) { pictureBox2.Image = Hangman.Properties.Resources.J; }
                    if (ile_pudel == 10) { pictureBox2.Image = Hangman.Properties.Resources.K; Restart.Visible = true; }

                }
                wygrana();
                
            }
            else
            {
                pictureBox2.Image = Hangman.Properties.Resources.LOSSER;
                Restart.Visible = true;
            }
            
        }

        private void losuj_slowo()
        {
            
            string[] slowa = { "krokusy", "liliput", "marchew", "selerek", "krakers", "klakier", "akwarel","Karinka" };
            int ile_slow = slowa.Length;
            Random gen = new Random();
            int indeks_slowa = gen.Next(0, ile_slow - 1);
            slowo = slowa[indeks_slowa];
            label1.Text = Convert.ToString(slowo[0]);
            label7.Text = Convert.ToString(slowo[6]);


                }
        private void wygrana()
        {
            if(label2.Text!="_")
            {
                if (label3.Text != "_")
                {
                    if (label4.Text != "_")
                    {
                        if (label5.Text != "_")
                        {
                            if (label6.Text != "_")
                            {
                                pictureBox2.Image = Hangman.Properties.Resources.WINNER;
                                Restart.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            losuj_slowo();
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
            label5.Text = "_";
            label6.Text = "_";
            ile_pudel = 0;
            Restart.Visible = false;


            pictureBox2.Image = Hangman.Properties.Resources._0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
