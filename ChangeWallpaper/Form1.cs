using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeWallpaper
{
    public partial class Form1 : Form
    {
        int timetoend = 8;
        Timer t;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            label4.Text = timetoend.ToString();
            t = new Timer();
            t.Enabled = true;
            t.Interval = 1000;
            t.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            timetoend--;
            label4.Text = timetoend.ToString();
            if (timetoend < 0) this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Enabled = false;
            label4.Text = "";
            label3.Text = "";
        }
    }
}
