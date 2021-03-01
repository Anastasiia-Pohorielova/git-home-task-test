using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Func_Action_Predicate
{
    class Program
    {
        public delegate void Action(string text);
        static void Main(string[] args)
        {
            Action Datasave;
            var numericText = new AlphaNumbericCollector();
            var stringText = new StringCollector();

            while (true)
            {
                Console.WriteLine("Enter a string: ");
                string inputStr = Console.ReadLine();

                if (IsNum(inputStr) == true)
                {
                    Datasave = numericText.AddToList;
                }
                else
                {
                    Datasave = stringText.AddToList;

                }
                Datasave(inputStr);
            }

            bool IsNum(string inputStr)
            {
                foreach (char c in inputStr)
                {
                    if (c >= '0' && c <= '9')
                    {
                        return true;
                    }
                }
                return false;

            }
        }

    }

}

