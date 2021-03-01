using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Event
{
    public class Event
    {
       
        static void Main(string[] args)
        {
            Events eventInvoke = new Events();
            var numericText = new AlphaNumbericCollector();
            var stringText = new StringCollector();
            eventInvoke.StringEvent += stringText.AddToList;
            eventInvoke.AlphaNumberEvent += numericText.AddToList;
            while (true)
            {
                Console.WriteLine("Enter a string: ");
                string inputStr = Console.ReadLine();
                eventInvoke.UserInput(inputStr);
            }

           
        }
    }
}
