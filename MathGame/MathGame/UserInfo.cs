using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    class UserInfo
    {
        string name;
        int age;
        bool ageIsValid;
        bool nameIsValid;
        string gameMode;

        /// <summary>
        /// validate age
        /// </summary>
        /// <param name="num">user inputed age</param>
        /// <returns></returns>
        public bool validateAge(string num)
        {
            try
            {
                age = Int32.Parse(num);
            }
            catch (FormatException)
            {
                return ageIsValid = false;
            }

            if (age < 3 || age > 10)
            {
                return ageIsValid = false;
            }
            else
            {
                return ageIsValid = true;
            }
            
        }
        /// <summary>
        /// validate name
        /// </summary>
        /// <param name="n">user inputted name</param>
        /// <returns></returns>
        public bool validateName(string n)
        {
            
            if(n == "")
            {
                return nameIsValid = false;
            }
            else
            {
                name = n;
                return nameIsValid = true;
            }
            
        }
        /// <summary>
        /// get the game mode
        /// </summary>
        /// <param name="g">based on the radio button selected</param>
        /// <returns>return the game mode in a string</returns>
        public string getGameMode(int g)
        {
            
            switch (g)
            {
                case 1:
                    gameMode = "addition";
                    break;
                case 2:
                    gameMode = "subtraction";
                    break;
                case 3:
                    gameMode = "multiplication";
                    break;
                case 4:
                    gameMode = "division";
                    break;
            }
            return gameMode;
        }
    }
}
