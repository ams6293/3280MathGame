using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class GameForm : Form
    {
        gameLogic game = gameLogic.Instance();
        UserInfo user = UserInfo.Instance();
        SoundPlayer happySound = new SoundPlayer("happysparkle.wav");
        SoundPlayer sadSound = new SoundPlayer("sadpiano.wav");
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
            answertxtbox.Enabled = true;
            submitAnswerbtn.Enabled = true;
            game.setValidProblem();
            signlbl.Text = game.getSign();
            numOnelbl.Text = game.getNumber1().ToString();
            numTwolbl.Text = game.getNumber2().ToString();
            timer.Start();
            startbtn.Enabled = false;
        }
        /// <summary>
        /// This checks for correct answers, starts or stops the timer, shows labels and gets a new problem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitAnswerbtn_Click(object sender, EventArgs e)
        {

            if(game.isCorrectAnswer(answertxtbox.Text) == true)
            {
                incorrectlbl.Visible = false;
                Correctlbl.Visible = true;
                happySound.Play();
            }
            else
            {
                Correctlbl.Visible = false; 
                incorrectlbl.Visible = true;
                sadSound.Play();
            }
            
            game.setQuestionCount();
            if (game.getQuestionCount() == 10)
            {
                user.setTime(ticks);
                timer.Stop();
                ScoreForm scoreform = new ScoreForm();
                scoreform.ShowDialog();
                this.Hide();
            }
            else
            {
                game.setValidProblem();
                numOnelbl.Text = game.getNumber1().ToString();
                numTwolbl.Text = game.getNumber2().ToString();
                answertxtbox.Text = "";
            }
            
        }
    }
}
