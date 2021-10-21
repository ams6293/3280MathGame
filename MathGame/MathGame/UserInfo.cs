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
 
    }
}
