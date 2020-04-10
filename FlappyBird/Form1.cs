using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Reflection;
using System.Runtime.InteropServices;
using FlappyBird.Properties;
using System.Threading;
using System.Media;

namespace FlappyBird
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        int spatiuconducte = 210;
        int latimeconducte = 65;
        int pozinitialax=260;
        int pozinitialay=279;
        int inaltimebird=25;
        int scor = 0;
        bool okd1 = true;
        bool okd2 = true;
        int scormax;
        int v = 1;
        double p = 0;
        Rectangle[] dreptunghisus;
        Rectangle[] dreptunghijos;
        Rectangle dreptunghibird;
        Random random = new Random();
        int r;

        private void butonstart_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("scormax1.txt"))
            {
                StreamReader sr = File.OpenText("scormax1.txt");
                scormax = sr.Read();
                reader.Close();
            }
                bird.Location = new Point(pozinitialax, pozinitialay);
                dreptunghisus = new Rectangle[7];
                dreptunghijos = new Rectangle[7];
                scormax = scormax - '0';
                textendgame.Text = Convert.ToString(scormax);
        }
        private void butonstart_Click(object sender, EventArgs e)
        {
            startgame();
        }

        private void scorbird_Click(object sender, EventArgs e)
        {

        }

        private void bird_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invalidate();
        }

        private void timer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            bird.Location = new Point(bird.Location.X, bird.Location.Y + inaltimebird);
           
        }

        private void timer3_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (scor1())
            {
                SoundPlayer sp1 = new SoundPlayer(FlappyBird.Properties.Resources.point);
                sp1.Play();
                scor++;
                scorbird.Text = Convert.ToString(scor);
                p = p + 0.05;
                if(p==1)
                {
                    v = v + 1;
                    p = 0;
                }
            }
            if (mort())
                endgame();
        }
        private void form1_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.Green);
            if (butonstart.Visible)
            {
                r = random.Next(40, this.Height - 290);
                dreptunghisus[1] = new Rectangle(this.Width, 0, latimeconducte, r);
                dreptunghijos[1] = new Rectangle(this.Width, r + spatiuconducte, latimeconducte, this.Height - r - spatiuconducte);
                dreptunghisus[3] = new Rectangle(this.Width-10, r, latimeconducte + 20, 15);
                dreptunghijos[3] = new Rectangle(this.Width-10, r + spatiuconducte, latimeconducte + 20, 15);


                r = random.Next(40, this.Height - 290);
                dreptunghisus[2] = new Rectangle(this.Width +300+latimeconducte/2, 0, latimeconducte, r);
                dreptunghijos[2] = new Rectangle(this.Width +300 + latimeconducte / 2, r + spatiuconducte, latimeconducte, this.Height - r - spatiuconducte);
                dreptunghisus[4] = new Rectangle(this.Width +290 + latimeconducte / 2, r, latimeconducte + 20, 15);
                dreptunghijos[4] = new Rectangle(this.Width +290 + latimeconducte / 2, r + spatiuconducte, latimeconducte + 20, 15);
                
                
            }
                for(int i=1;i<=2;i++)
                    {
                        dreptunghijos[i].X = dreptunghijos[i].X - v;
                        dreptunghisus[i].X = dreptunghisus[i].X - v;

                        dreptunghijos[i+2].X = dreptunghijos[i+2].X - v;
                        dreptunghisus[i+2].X = dreptunghisus[i+2].X - v;

                        dreptunghijos[i + 4].X = dreptunghijos[i + 4].X - v;
                        dreptunghisus[i + 4].X = dreptunghisus[i + 4].X - v;
                    }
                 if(dreptunghijos[1].X+10<-latimeconducte)
                    {
                r = random.Next(40, this.Height - 290);
                dreptunghisus[1] = new Rectangle(this.Width, 0, latimeconducte, r);
                dreptunghijos[1] = new Rectangle(this.Width, r + spatiuconducte, latimeconducte, this.Height - r - spatiuconducte);
                dreptunghisus[3] = new Rectangle(this.Width -10, r, latimeconducte + 20, 15);
                dreptunghijos[3] = new Rectangle(this.Width -10, r + spatiuconducte, latimeconducte + 20, 15);
                okd1 = true;
            }
                if(dreptunghijos[2].X+10<-latimeconducte)                
                    {
                okd2 = true;

                r = random.Next(40, this.Height - 290);
                dreptunghisus[2] = new Rectangle(this.Width , 0, latimeconducte, r);
                dreptunghijos[2] = new Rectangle(this.Width , r + spatiuconducte, latimeconducte, this.Height - r - spatiuconducte);
                dreptunghisus[4] = new Rectangle(this.Width-10 , r, latimeconducte + 20, 15);
                dreptunghijos[4] = new Rectangle(this.Width-10 , r + spatiuconducte, latimeconducte + 20, 15);
            }
             
            e.Graphics.FillRectangles(brush, dreptunghisus);
            e.Graphics.FillRectangles(brush, dreptunghijos);
            
        }
        public void startgame ()
        {
            bird.Location = new Point(pozinitialax, pozinitialay);
            butonstart.Enabled = false;
            butonstart.Visible = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            bird.Visible = true;
            scor = 0;
            scorbird.Text = Convert.ToString(scor);
            scorbird.Text = "0";
            textendgame.Visible = false;
        }
        public void endgame()
        {
            if (scor > scormax)
            {
                SoundPlayer sp2 = new SoundPlayer(FlappyBird.Properties.Resources.lightapplause);
                sp2.Play();
                using (StreamWriter writer = new StreamWriter("scormax1.txt"))
                {
                    scormax = scor;
                    writer.Write(scor);
                    textendgame.Text = "Felicitari!!!\nAi facut un scor maxim " + scor + " puncte";
                    writer.Close();
                }
            }
            else
            {
                textendgame.Text = "Mai exerseaza.Ai facut " + scor + " puncte\nScor maxim " + scormax + " puncte";
                SoundPlayer sp = new SoundPlayer(FlappyBird.Properties.Resources.footballcrowd2);
                sp.Play();
            }
                butonstart.Visible = true;
                butonstart.Enabled = true;
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                bird.Visible = false;
                scor = 0;
                okd1 = true;
                okd2 = true;
                textendgame.Visible = true;
                
        }
        private void form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                inaltimebird = -30;
                bird.BackgroundImage = listaimagini.Images[1];
            }
        }

        private void form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                inaltimebird = 25;
                bird.BackgroundImage = listaimagini.Images[0];
            }
        }
        private bool intersectie ()
        {
            bool ok = false;
            for (int i = 1; i <= 4; i++)
            {
                if (Rectangle.Intersect(dreptunghibird, dreptunghijos[i]) != Rectangle.Empty)
                    ok = true;
                else
                    if (Rectangle.Intersect(dreptunghibird, dreptunghisus[i]) != Rectangle.Empty)
                    ok = true;
            }
            if (dreptunghibird.Y + 55 > this.Height)
                ok = true;
            if (dreptunghibird.Y +55 < 0)
                ok = true; 
           return ok;
        }
        private bool mort ()
        {
            bool ok = false;
            dreptunghibird = bird.Bounds;
            if (intersectie())
                ok = true;
            return ok;
        }
        private bool scor1()
        {
            if (dreptunghijos[1].X < pozinitialax - dreptunghibird.Height && okd1)
            {
                okd1 = false;
                 return true;
            }
            else
           if (dreptunghijos[1].X < pozinitialax - dreptunghibird.Height + 1 && okd1)
            {
                okd1 = false;
                return true;
            }
            if (dreptunghijos[2].X < pozinitialax - dreptunghibird.Height && okd2)
            {
                okd2 = false;
                return true;
            }
            else
           if (dreptunghijos[2].X < pozinitialax - dreptunghibird.Height + 1 && okd2)
            {
                okd2 = false;
                return true;
            }
            return false;
        }
    }
}
