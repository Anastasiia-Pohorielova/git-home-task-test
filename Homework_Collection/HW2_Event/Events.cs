using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Event
{
    public class Events
    {
        public delegate void DataSave(string text);
        public event DataSave AlphaNumberEvent;
        public event DataSave StringEvent;

        public void UserInput(string text)
        {
            if (IsNum(text) == true)
            {
                AlphaNumberEvent?.Invoke(text);
            }
            else
            {
                StringEvent?.Invoke(text);
            }
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
    public class AlphaNumbericCollector
    {
        public List<string> inputN = new List<string>();
        public void AddToList(string text)
        {
            inputN.Add(text);
        }
    }
    public class StringCollector
    {
        public List<string> inputS = new List<string>();
        public void AddToList(string text)
        {
            inputS.Add(text);

        }
    }
}
