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
        UserInfo user = new UserInfo();
        int number1;
        string sign;
        int type;
        int number2;
        int answer;
        bool isCorrect;
        int questionCount = 0;
        static Random random = new Random();

        public static gameLogic Instance()
        {
            if(instance == null)
            {
                instance = new gameLogic();
            }
            return instance;
        }

        public int getNumber1()
        {
            
            return number1;
        }
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
        public int getQuestionCount()
        {
            return questionCount;
        }
        public void setQuestionCount()
        {
            questionCount++;
        }
        public int getNumber2()
        {
            
            return number2;
        }
        public void setValidProblem()
        {
            if(type == 1)
            {
                setValidAddition();
            }
            else if(type == 2)
            {
                setValidSubtraction();
            }
            else if(type == 3)
            {
                setValidMultiplication();
            }
            else if(type == 4)
            {
                setValidDivision();
            }
            else
            {

            }

        }
        public void setType(int n)
        {
            type = n;
        }
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
        public bool isCorrectAnswer(string a)
        {
            int input;
            try
            {
                input = Int32.Parse(a);
            }
            catch (FormatException)
            {
                return isCorrect = false;
            }
            if(input == answer)
            {
                return isCorrect = true;
            }
            else
            {
                return isCorrect = false;
            }
        }
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
