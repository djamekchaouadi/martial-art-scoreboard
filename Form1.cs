using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Timers;
using System.Net.Sockets;
using System.Threading;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;


namespace vovinam4
{
    public partial class Form1 : Form
    {
        Form2 f = new Form2();
        Form3 j = new Form3();
        System.Timers.Timer Timer;
        int h, m, s;
        private int i;
        private object G;

        public object KeyPressEventArgs { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer = new System.Timers.Timer();
            Timer.Interval = 1000;
            Timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
                

                s += 1;
                if (s == 60)
                 {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }



                label2.Text = string.Format("{1}:{2}", h.ToString().ToString().PadLeft(2, '0'), m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'));
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short i;
            if (!Int16.TryParse(this.Score1.Text, out i)) i = 0;
            i++;
            this.Score1.Text = i.ToString();
            
        }

        private void RefreshSummary()
        {
            throw new NotImplementedException();
        }

        private void Score1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            short i;
            if (!Int16.TryParse(this.Score1.Text, out i)) i = 0;
            if (i > -15) i--;
            this.Score1.Text = i.ToString();
            
        }

        private void Minus2_Click(object sender, EventArgs e)
        {
            short i;
            if (!Int16.TryParse(this.Score2.Text, out i)) i = 0;
            if (i > -15) i--;
            this.Score2.Text = i.ToString();
            
        }

        private void Plus2_Click(object sender, EventArgs e)
        {
            short i;
            if (!Int16.TryParse(this.Score2.Text, out i)) i = 0;
            i++;
            this.Score2.Text = i.ToString();
        }


        private void minus22_Click(object sender, EventArgs e)
        {
            short i;
            if (!Int16.TryParse(this.Score2.Text, out i)) i = 1;            
            if (i > -15) i--;
            i--;
            this.Score2.Text = i.ToString();
        }

        private void plus22_Click(object sender, EventArgs e)
        {
            short i;
            if (!Int16.TryParse(this.Score2.Text, out i)) i = 1;
            i++;
            i++;
            this.Score2.Text = i.ToString();
        }

        private void plus22b_Click(object sender, EventArgs e)
        {
            short i;
            if (!Int16.TryParse(this.Score1.Text, out i)) i = 0;
            i++;
            i++;
            this.Score1.Text = i.ToString();
        }

        private void minus22b_Click(object sender, EventArgs e)
        {
            short i;
            if (!Int16.TryParse(this.Score1.Text, out i)) i = 0;
            if (i > -15) i--;
            i--;
            this.Score1.Text = i.ToString();
        }
        private void Score2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Timer.Start();
            label2.Text = "00:00";
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            Timer.Stop();
        }

        private void ResetT_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            
            m = 0;
            s = 0;
            h = 0;
            label2.Text = "00:00";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void win_Click(object sender, EventArgs e)
        {
            Score2.BackColor = Color.YellowGreen;
        }

        private void win1_Click(object sender, EventArgs e)
        {
            Score1.BackColor = Color.YellowGreen;            
        }

        private void restclr_Click(object sender, EventArgs e)
        {
            Score2.BackColor = Color.Red;
        }

        private void rstcolor_Click(object sender, EventArgs e)
        {
            Score1.BackColor = Color.Blue;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (j == null)
            {
                j = new Form3();
                j.Show();
            }
            else
            {
                j.Show();
                j.Focus();

            }


        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if(f==null)
            {
                f = new Form2();
                f.Show();
            }
            else
            {
                f.Show();
                f.Focus();

            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.NumPad1 && e.KeyData == Keys.NumPad1)
            {
                Plus2.PerformClick();
            }


            if (e.KeyData == Keys.NumPad2 && e.KeyData == Keys.NumPad2)
            {
                plus22.PerformClick();
            }

            if (e.KeyData == Keys.NumPad3 && e.KeyData == Keys.NumPad3)
            {
                Minus2.PerformClick();
            }

            if (e.KeyData == Keys.NumPad0 && e.KeyData == Keys.NumPad0)
            {
                minus22.PerformClick();
            }

            if (e.KeyData == Keys.NumPad4 && e.KeyData == Keys.NumPad4)
            {
                win.PerformClick();
            }

            if (e.KeyData == Keys.NumPad5 && e.KeyData == Keys.NumPad5)
            {
                restclr.PerformClick();
            }

            if (e.KeyData == Keys.W && e.KeyData == Keys.W)
            {
                Plus1.PerformClick();
            }

            if (e.KeyData == Keys.X && e.KeyData == Keys.X)
            {
                Minus1.PerformClick();
            }

            if (e.KeyData == Keys.C && e.KeyData == Keys.C)
            {
                plus22b.PerformClick();
            }

            if (e.KeyData == Keys.V && e.KeyData == Keys.V)
            {
                minus22b.PerformClick();
            }

            if (e.KeyData == Keys.B && e.KeyData == Keys.B)
            {
                win1.PerformClick();
            }

            if (e.KeyData == Keys.N && e.KeyData == Keys.N)
            {
                rstcolor.PerformClick();
            }

            if (e.KeyData == Keys.A && e.KeyData == Keys.A)
            {
                Start.PerformClick();
            }

            if (e.KeyData == Keys.Z && e.KeyData == Keys.Z)
            {
                Pause.PerformClick();
            }

            if (e.KeyData == Keys.E && e.KeyData == Keys.E)
            {
                ResetT.PerformClick();
            }

            if (e.KeyData == Keys.R && e.KeyData == Keys.R)
            {
                ResetPoints.PerformClick();
            }

            if (e.KeyData == Keys.P && e.KeyData == Keys.P)
            {
                ResetPoints.PerformClick();
                ResetT.PerformClick();
                restclr.PerformClick();
                rstcolor.PerformClick();
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ResetP_Click(object sender, EventArgs e)
        {
            short i;
            if (!Int16.TryParse(this.Score1.Text, out i)) i = 10;
            if (!Int16.TryParse(this.Score2.Text, out i)) i = 10;
            if (i > -10)
            this.Score1.Text = i.ToString();
            this.Score2.Text = i.ToString();
            Score1.Text = "0";
            Score2.Text = "0";           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
    }

