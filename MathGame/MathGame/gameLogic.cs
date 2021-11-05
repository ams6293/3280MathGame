using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class gameLogic
    {
        static gameLogic instance;
        UserInfo user = UserInfo.Instance();
        int number1;
        string sign;
        int type;
        int number2;
        int answer;
        bool isCorrect;
        int questionCount = 0;
        static Random random = new Random();
        /// <summary>
        /// creates a game innstance
        /// </summary>
        /// <returns></returns>
        public static gameLogic Instance()
        {
            if(instance == null)
            {
                instance = new gameLogic();
            }
            return instance;
        }
        /// <summary>
        /// this returns the first number from the equation
        /// </summary>
        /// <returns></returns>
        public int getNumber1()
        {
            
            return number1;
        }
        /// <summary>
        /// this returns the sign based on the game the user picked
        /// </summary>
        /// <returns></returns>
        public string getSign()
        {
            if(type == 1)
            {
                sign = "+";
            }
            else if(type == 2)
            {
                sign = "-";
            }
            else if(type == 3)
            {
                sign = "*";
            }
            else  if(type ==  4)
            {
                sign = "/";
            }
            return sign;
        }
        /// <summary>
        /// this gets the question count to keep track of how many questions the user has answered
        /// </summary>
        /// <returns></returns>
        public int getQuestionCount()
        {
            return questionCount;
        }
        /// <summary>
        /// this resets the question count for a new game
        /// </summary>
        public void resetQuestionCount()
        {
            questionCount = 0;
        }
        /// <summary>
        /// this increments the question count
        /// </summary>
        public void setQuestionCount()
        {
            questionCount++;
        }

        /// <summary>
        /// this returns the second number in the equation
        /// </summary>
        /// <returns></returns>
        public int getNumber2()
        {
            
            return number2;
        }
        /// <summary>
        /// this gets a valid problem based on what game the user picked
        /// </summary>
        public void setValidProblem()
        {
            if(type == 1)
            {
                setValidAddition();
                setAdditionAnswer();
            }
            else if(type == 2)
            {
                setValidSubtraction();
                setSubractionAnswer();
            }
            else if(type == 3)
            {
                setValidMultiplication();
                setMultiplicationAnswer();
            }
            else if(type == 4)
            {
                setValidDivision();
                setDivisonAnswer();
            }
            else
            {

            }

        }
        /// <summary>
        /// this sets the type of game based on what the user selected
        /// </summary>
        /// <param name="n"></param>
        public void setType(int n)
        {
            type = n;
        }
        /// <summary>
        /// this creates a valid subtraction problem
        /// </summary>
        public void setValidSubtraction()
        {
            number1 = random.Next(0, 10);
            number2 = random.Next(0, 10);
            while((number1 - number2) < 0)
            {
                number1 = random.Next(0, 10);
                number2 = random.Next(0, 10);
            }
        }
        /// <summary>
        /// these get the answer to the problem based on it's type
        /// </summary>
        public void setSubractionAnswer()
        {
            answer = number1 - number2;
        }
    
        public void setAdditionAnswer()
        {
            answer = number1 + number2;
        }
        public void setMultiplicationAnswer()
        {
            answer = number1 * number2;
        }
        public void setDivisonAnswer()
        {
            answer = number1 / number2;
        }
        /// <summary>
        /// this determines if the user entered the correct answer
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool isCorrectAnswer(string a)
        {
            int input;
            try
            {
                input = Int32.Parse(a);
                if (input == answer)
                {
                    user.setCorrectAnswers();
                    isCorrect = true;
                }
                else
                {
                    user.setWrongAnswers();
                    isCorrect = false;
                }
            }
            catch (FormatException)
            {
                user.setWrongAnswers();
                isCorrect = false;
            }
            return isCorrect;
          
        }
        /// <summary>
        /// these set valid numbers to problems based on type
        /// </summary>
        public void setValidAddition()
        {
            number1 = random.Next(0, 10);
            number2 = random.Next(0, 10);
        }

        public void setValidMultiplication()
        {
            number1 = random.Next(0, 10);
            number2 = random.Next(0, 10);
        }

        public void setValidDivision()
        {
            number1 = random.Next(0, 10);
            number2 = random.Next(1, 10);
           
            while ((number1 % number2) != 0)
            {
                number1 = random.Next(0, 10);
                number2 = random.Next(1, 10);
            }
        }
    }
}
