using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            string surnames = "Davis,Clyne,Fonte,Hooiveld,Shaw,Daviss,Schneiderlin,Cork,Lallana,Rodriguez,Lambert";
            var query = surnames.Split(',').Select((n, index) => n.Insert(0, (index + 1) + "."));
            Console.WriteLine("Task 1: " + String.Join(",", query));

            // Task 2
            string players = "Jason Puncheon,26/06/1986; Jos Hooiveld,22/04/1983; Kelvin Davis,29/09/1976; Luke Shaw,12/07/1995; Gaston Ramirez,02/12/1990; Adam Lallana,10/05/1988";
            string[] names = players.Split(';');

            var playersName = names.Select(n => n.Remove(n.IndexOf(',')));

            var playersAge = names.Select(n => n.Substring(n.IndexOf(',') + 1)).Select(n => Age(n));

            var playersData = playersName.Zip(playersAge, (player, age) => new { player, age }).OrderBy(a => a.age);

            Console.WriteLine("Task 2");
            foreach (var s in playersData)
            {
                Console.WriteLine(s);
            }

            //Task 3
            string task = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";
            string[] songDuration = task.Split(',');

            var totalDuration = songDuration.Select(s => ToTime(s)).ToArray().Aggregate((x, y) => x + y);

            Console.WriteLine($"Task 3: {totalDuration}");
           
            

            Console.ReadKey();
        }
        public static string Age(string birth)
        {
            DateTime today = DateTime.Today;
            DateTime _birth = DateTime.Parse(birth);
            int age = today.Year - _birth.Year;
            return Convert.ToString(age);
        }

        public static TimeSpan ToTime(string time)
        {
                TimeSpan ts = TimeSpan.Parse("00:"+time);
                return ts;
        }

    }
  

}
