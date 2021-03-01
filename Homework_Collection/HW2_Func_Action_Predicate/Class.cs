using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Func_Action_Predicate
{
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
