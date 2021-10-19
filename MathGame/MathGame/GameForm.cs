using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class GameForm : Form
    {
        private int ticks;
        public GameForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// what happens on timer tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            ticks++;
            timerlbl.Text = ticks.ToString();
        }
        /// <summary>
        /// what happens on start button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startbtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
