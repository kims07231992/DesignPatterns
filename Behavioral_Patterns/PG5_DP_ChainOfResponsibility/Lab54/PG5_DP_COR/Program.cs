using PG5_DP_COR.CallCenters.Employees;
using PG5_DP_COR.CallCenters.Issues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_COR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            TestHandlingIssue();
        }

        private static void TestHandlingIssue()
        {
            // set tickets
            List<Ticket> ticketList = new List<Ticket>()
            {
                new Ticket { Difficulty = Difficulty.Low },
                new Ticket { Difficulty = Difficulty.Medium },
                new Ticket { Difficulty = Difficulty.High },
                new Ticket { Difficulty = Difficulty.VeryHigh },
            };

            // set Employees
            var customerRep = new CustomerRep(0, "Customer Rep", Difficulty.Low);
            var teamManager = new TeamManager(0, "Team Manager", Difficulty.Medium);
            var generalManager = new GeneralManager(0, "General Manager", Difficulty.High);
            var vicePresident = new VicePresident(0, "Vice President", Difficulty.VeryHigh);

            // set chained relation
            customerRep.NextChain(teamManager);
            teamManager.NextChain(generalManager);
            generalManager.NextChain(vicePresident);

            foreach (Ticket ticket in ticketList)
            {
                string s = customerRep.HandleTicket(ticket);
                Console.WriteLine(s);
            }
        }
    }
}
