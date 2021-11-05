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
    public partial class ScoreForm : Form
    {
        gameLogic game = gameLogic.Instance();
        UserInfo user = UserInfo.Instance();
        public ScoreForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This shows the score board and changes the background based on how well they did
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScoreForm_Load(object sender, EventArgs e)
        {
            if (user.getCorrectAnswer() > 7)
            {
                this.BackColor = Color.LightGreen;
                messagelbl.Text = "GREAT JOB!";
                happyPicture.Visible = true;
            }
            else if (user.getCorrectAnswer() > 4 && user.getCorrectAnswer() < 8)
            {
                this.BackColor = Color.LightYellow;
                messagelbl.Text = "You almost did it!";
                sadpicture.Visible = true;
            }
            else
            {
                this.BackColor = Color.Red;
                messagelbl.Text = "Keep practicing!";
                cryingpicture.Visible = true;
            }
            
            namelbl.Text = user.getName();
            agelbl.Text = user.getAge().ToString();
            correctAnswerslbl.Text = user.getCorrectAnswer().ToString();
            incorrectAnswerslbl.Text = user.getWrongAnswer().ToString();
            timelbl.Text = user.getTime().ToString();
        }
    }
}
