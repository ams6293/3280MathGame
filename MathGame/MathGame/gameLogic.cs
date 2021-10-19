using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    class gameLogic
    {
        UserInfo user = new UserInfo();
        int number1;
        int number2;
        static Random random = new Random();
        public int getNumber1()
        {
            
            return number1;
        }

        public int getNumber2()
        {
            
            return number2;
        }
        public void getValidSubtraction()
        {
            number1 = random.Next(0, 10);
            number2 = random.Next(0, 10);
            while((number1 - number2) < 0)
            {
                number1 = random.Next(0, 10);
                number2 = random.Next(0, 10);
            }
        }

        public void getValidAddition()
        {
            number1 = random.Next(0, 10);
            number2 = random.Next(0, 10);
        }

        public void getValidMultiplication()
        {
            number1 = random.Next(0, 10);
            number2 = random.Next(0, 10);
        }

        public void getValidDivision()
        {
            number1 = random.Next(0, 10);
            number2 = random.Next(0, 10);
            while ((number1 % number2) != 0)
            {
                number1 = random.Next(0, 10);
                number2 = random.Next(0, 10);
            }
        }
    }
}
