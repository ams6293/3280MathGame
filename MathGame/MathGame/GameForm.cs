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
        gameLogic game = gameLogic.Instance();
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
            game.setValidProblem();
            signlbl.Text = game.getSign();
            numOnelbl.Text = game.getNumber1().ToString();
            numTwolbl.Text = game.getNumber2().ToString();
            timer.Start();
        }
    }
}
