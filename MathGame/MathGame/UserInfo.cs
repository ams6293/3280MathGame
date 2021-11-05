using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    class UserInfo
    {
        static UserInfo instance;
        string name;
        int age;
        bool ageIsValid;
        bool nameIsValid;
        int correctAnswers;
        int wrongAnswers;
        int time;

        public static UserInfo Instance()
        {
            if (instance == null)
            {
                instance = new UserInfo();
            }
            return instance;
        }
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
                age = Int32.Parse(num);
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
            name = n;

            if (n == "")
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
        /// get user name
        /// </summary>
        /// <returns>return the name</returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// get user age
        /// </summary>
        /// <returns>return the age</returns>
        public int getAge()
        {
            return age;
        }
        /// <summary>
        /// incriments the correct answers
        /// </summary>
        public void setCorrectAnswers()
        {
            correctAnswers++;
        }
        /// <summary>
        /// gets the number of correct answers
        /// </summary>
        /// <returns></returns>
        public int getCorrectAnswer()
        {
            return correctAnswers;
        }

        /// <summary>
        /// resets the number of wrong or correct anwswers
        /// </summary>
        public void resetAnswers()
        {
            wrongAnswers = 0;
            correctAnswers = 0;
        }
        public void setWrongAnswers()
        {
            wrongAnswers++;
        }
        public int getWrongAnswer()
        {
            return wrongAnswers;
        }
        /// <summary>
        /// sets the time based on ticks in the game window
        /// </summary>
        /// <param name="t"></param>
        public void setTime(int t)
        {
            time = t;
        }
        /// <summary>
        /// returns the time based on the ticks from the game window
        /// </summary>
        /// <returns></returns>
        public int getTime()
        {
            return time;
        }

    }
}
