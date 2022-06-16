using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Windows;
using System.Media;

namespace MemoryMio
{
    public partial class Form1 : Form
    {
        string name = System.IO.Directory.GetCurrentDirectory() + "/../../../lil/";
        string back = System.IO.Directory.GetCurrentDirectory() + "/../../../lil/dorso1.jpg";
        SoundPlayer WinSound = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + "/../../../lil/WinningSound.wav");
        string[] appoggio = new string[50];
        int[] level = {1,4,6};
        bool click1 = false;
        PictureBox[] Pic = new PictureBox[50];
        Random Numero = new Random();
        int Valore, i, I, j, k=1, primoCliccato=-1, secondoCliccato=-1, Punteggio = 0, Mosse = 0,difficulty;
        bool Click1 = false, Click2 = false;

        private void RadioHard_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelMosse.Location = new System.Drawing.Point(10, 10);
            button1.Visible = false;
            labelMosse.Visible = true;
            RadioEasy.Visible = false;
            RadioHard.Visible = false;
            LabelDifficulty.Visible = false;
            if (difficulty == 1)
            {
                Width = 600;
                Height = 500;
            }
            else if (difficulty == 2)
            {
                Width = 775;
                Height = 700;
            }
            for (I = 0; I < level[difficulty] * level[difficulty]; I++)
                appoggio[I] = "";

            for (I = 0; I < level[difficulty] * level[difficulty] / 2; I++)
            {
                Valore = Numero.Next(0, level[difficulty] * level[difficulty]);
                while (appoggio[Valore] != "")
                    Valore = Numero.Next(0, level[difficulty] * level[difficulty]);
                appoggio[Valore] = name + Convert.ToString(I) + ".jpg";
                Valore = Numero.Next(0, level[difficulty] * level[difficulty]);
                while (appoggio[Valore] != "")
                    Valore = Numero.Next(0, level[difficulty] * level[difficulty]);
                appoggio[Valore] = name + Convert.ToString(I) + ".jpg";

            }

            for (i = 0; i < level[difficulty] * level[difficulty]; ++i)
            {
                Pic[i] = new PictureBox();
                Pic[i].Load(appoggio[i]);
                Pic[i].Enabled = true;
                Pic[i].Height = 100;
                Pic[i].Width = 100;
                Pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Pic[i].Location = new System.Drawing.Point(
                    10 + k * 105, 10 + j * 105);
                k++;
                this.Controls.Add(Pic[i]);
                if (i == level[difficulty]-1 || i == 2* level[difficulty] - 1 || i == 3* level[difficulty] - 1
                    || i==4* level[difficulty] - 1 || i==5* level[difficulty] - 1 || i== 6*level[difficulty] - 1)
                {
                    j++;
                    k = 1;
                }

                Pic[i].Click += new EventHandler(this.ClickSuImmagine);
                Pic[i].Tag = i;
            }

            timer1.Interval = 2000;
            timer1.Tick += (timer1_Tick);
            timer1.Start();
        }

        private void TimerSecondario_Tick(object sender, EventArgs e)
        {
            TimerSecondario.Stop();
            if (Click1)
            {
                if (appoggio[primoCliccato] == appoggio[secondoCliccato])
                {
                    Pic[primoCliccato].Enabled = false;
                    Pic[secondoCliccato].Enabled = false;
                    Punteggio++;
                }
                else
                {
                    Pic[primoCliccato].Load(back);
                    Pic[secondoCliccato].Load(back);
                    Pic[primoCliccato].Enabled = true;
                    Pic[secondoCliccato].Enabled = true;
                }
                AzzeraClick(sender, e);
                Mosse++;
                labelMosse.Text = "Mosse: " + Convert.ToString(Mosse);
                if (Punteggio == level[difficulty]*level[difficulty]/2)
                {
                    WinSound.Play();
                    
                }
                
            }
            Click1 = false;
           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        public void AzzeraClick(object sender, EventArgs e)
        {
            primoCliccato = -1;
            secondoCliccato = -1;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            for (i = 0; i < level[difficulty]*level[difficulty]; i++)
            {
                Pic[i].Load(back);
            }
            timer1.Stop();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void ClickSuImmagine(object sender, EventArgs e)
        {
            PictureBox PicCliccata = (PictureBox)sender;
            PicCliccata.Load(appoggio[(int)PicCliccata.Tag]);
            
            if (primoCliccato < 0)
            {
                primoCliccato = (int)PicCliccata.Tag;
                PicCliccata.Enabled = false;
            }
            if ((primoCliccato>=0)&&(secondoCliccato<0)&&(Click1==true))
            {
                secondoCliccato = (int)PicCliccata.Tag;
                TimerSecondario.Interval=500;
                TimerSecondario.Tick += (TimerSecondario_Tick);
                TimerSecondario.Start();
            }
            else
            {
                Click1 = true;
            }
        }
    }
}
