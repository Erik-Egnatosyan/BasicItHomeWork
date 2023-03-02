using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    internal class Human
    {
        public bool IsValid(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z')))
                {
                    Console.WriteLine(Errors.YourTextHaveNumberOrSymbols);
                    return false;
                }      
            }
            return true;
        }
        public bool IsValid(string name, string surename)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(name);
            sb.Append(surename);
            bool check = default(bool);
            for (int i = 0; i < sb.Length; i++)
            {
                if ((sb[i] >= 'a' && sb[i] <= 'z') || (sb[i] >= 'A' && sb[i] <= 'Z'))
                    check = true;
                else
                {
                    Console.WriteLine(Errors.YourTextHaveNumberOrSymbols);
                    //check = false;
                    break;
                }
            }
            return check;
        }
        public int CountChar(string str, char symb)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symb)
                {
                    count++;
                }
            }
            return count;
        }
        public enum Errors
        { 
            YourTextHaveNumberOrSymbols        
        }
    }
}
