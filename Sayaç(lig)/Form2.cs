using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayaç_lig_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false)
            {
                button4.Enabled = true;
            }
            int a = rnd.Next(0, 5);
            int b = rnd.Next(0, 5);
            int c = rnd.Next(0, 5);
            int d = rnd.Next(0, 5);

            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label7.Text = c.ToString();
            label6.Text = d.ToString();
            

            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if(Convert.ToInt32(label5.Text) > Convert.ToInt32(label4.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if(Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan  +1;
                fbpuan = fbpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label7.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) == Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false)
            {
                button4.Enabled = true;
            }
            int b = rnd.Next(0, 5);
            int n = rnd.Next(0, 5);
            int m = rnd.Next(0, 5);
            int ö = rnd.Next(0, 5);

            label11.Text = b.ToString();
            label12.Text = n.ToString();
            label13.Text = m.ToString();
            label14.Text = ö.ToString();

            if(Convert.ToInt32(label14.Text)> Convert.ToInt32(label12.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if(Convert.ToInt32(label12.Text) > Convert.ToInt32(label14.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if(Convert.ToInt32(label14.Text) == Convert.ToInt32(label12.Text))
            {
                gspuan = gspuan + 1;
                bjkpuan = bjkpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label11.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label13.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label13.Text) == Convert.ToInt32(label11.Text))
            {
                fbpuan = fbpuan + 1;
                tspuan = tspuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false)
            {
                button4.Enabled = true;
            }
            int a = rnd.Next(0, 5);
            int b = rnd.Next(0, 5);
            int c = rnd.Next(0, 5);
            int d = rnd.Next(0, 5);

            label25.Text = a.ToString();
            label26.Text = b.ToString();
            label28.Text = c.ToString();
            label29.Text = d.ToString();

            if(Convert.ToInt32(label29.Text) > Convert.ToInt32(label26.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if(Convert.ToInt32(label26.Text) > Convert.ToInt32(label29.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if(Convert.ToInt32(label29.Text) == Convert.ToInt32(label26.Text))
            {
                fbpuan = fbpuan + 1;
                bjkpuan = bjkpuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if(Convert.ToInt32(label28.Text) > Convert.ToInt32(label25.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if(Convert.ToInt32(label25.Text) > Convert.ToInt32(label28.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if(Convert.ToInt32(label28.Text) == Convert.ToInt32(label25.Text))
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(gspuan) > Convert.ToInt32(fbpuan & bjkpuan & tspuan ))
            {
                label35.Text = label20.Text;
                axWindowsMediaPlayer1.URL = "C:\\Users\\oyunk\\OneDrive\\Masaüstü\\1.mp3";
            }
            if (Convert.ToInt32(fbpuan) > Convert.ToInt32(gspuan & bjkpuan & tspuan))
            {
                label35.Text = label19.Text;
                axWindowsMediaPlayer1.URL = "C:\\Users\\oyunk\\OneDrive\\Masaüstü\\1.mp3";
            }
            if (Convert.ToInt32(bjkpuan) > Convert.ToInt32(fbpuan & gspuan & tspuan))
            {
                label35.Text = label18.Text;
                axWindowsMediaPlayer1.URL = "C:\\Users\\oyunk\\OneDrive\\Masaüstü\\1.mp3";
            }
            if (Convert.ToInt32(tspuan) > Convert.ToInt32(fbpuan & bjkpuan & gspuan))
            {
                label35.Text = label17.Text;
                axWindowsMediaPlayer1.URL = "C:\\Users\\oyunk\\OneDrive\\Masaüstü\\1.mp3";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
        }
    }
}
