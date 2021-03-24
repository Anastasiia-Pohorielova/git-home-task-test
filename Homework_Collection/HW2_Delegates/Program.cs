using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HW2_Delegates
{
    public class Delegate
    {
        public delegate void DataSave(string text);
        static void Main(string[] args)
        {
            DataSave Datasave;
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
