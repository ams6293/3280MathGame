﻿using System;
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
    public partial class mainForm : Form
    {
        UserInfo user = new UserInfo();
        string gameMode;
        public mainForm()
        {
            InitializeComponent();
        }
        private bool getRadioChecked()
        {
            bool isValidRadio = false;
            if(additionRadio.Checked == true)
            {
                gameMode = user.getGameMode(1);
                isValidRadio = true;
            }
            else if(subtractionRadio.Checked == true)
            {
                gameMode = user.getGameMode(2);
                isValidRadio = true;
            }
            else if (subtractionRadio.Checked == true)
            {
                gameMode = user.getGameMode(2);
                isValidRadio = true;
            }
            else if (subtractionRadio.Checked == true)
            {
                gameMode = user.getGameMode(2);
                isValidRadio = true;
            }
            return isValidRadio;
        }
        private void beginGamebtn_Click(object sender, EventArgs e)
        {
           
            if (user.validateAge(agetxtbox.Text) == true)
            {
                if(user.validateName(nametxtbox.Text) == true)
                {
                    if(getRadioChecked() == true)
                    {
                        GameForm gameform = new GameForm();
                        gameform.ShowDialog();
                    }
                    else
                    {
                        errorlbl.Text = "Please select a game mode.";
                    }
                }
                else
                {
                    errorlbl.Text = "Please Enter a Valid a name";
                }
              
            }
            else
            {
                errorlbl.Text = "Please Enter a Valid age (between 3-10)";
            }
        }
    }
}