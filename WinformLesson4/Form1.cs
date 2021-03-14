using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformLesson4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Scroll += Form1_Scroll;



            //NUMERIC UP DOWN

            numericUpDown1.Increment = 0.25M;

            numericUpDown1.DecimalPlaces = 3;


            //tool tip
            
            toolTip1.SetToolTip(pictureBox1, "Winform Picture Box");

        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {

            label1.Text=this.VerticalScroll.Value.ToString();
        }
        int scroll = 0;
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            if (scroll >= hScrollBar1.Value)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 9, pictureBox1.Location.Y);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 9, pictureBox1.Location.Y);
            }

            scroll = hScrollBar1.Value;
        }

        int scroll2 = 0;

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (scroll2 >= vScrollBar1.Value)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y-8);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y+8);
            }

            scroll2 = vScrollBar1.Value;
        }

            Timer timer = new Timer();
        private void button1_Click(object sender, EventArgs e)
        {
            timer.Interval = 500;
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = progressBar1.Value.ToString();
            progressBar1.PerformStep();
            if (progressBar1.Value >= progressBar1.Maximum)
            {
            timer.Stop();
                MessageBox.Show("Finish");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = guna2TrackBar1.Value.ToString();
        }
    }
}
