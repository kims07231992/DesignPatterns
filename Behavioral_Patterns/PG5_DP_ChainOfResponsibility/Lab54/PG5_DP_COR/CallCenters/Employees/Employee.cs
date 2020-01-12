using PG5_DP_COR.CallCenters.Issues;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_COR.CallCenters.Employees
{
    public abstract class Employee
    {
        protected abstract string HandleProperly(Ticket ticket);

        protected Employee _nextChain;
        protected Difficulty _possibleDifficulty;

        public Employee(int id, string name, Difficulty difficulty)
        {
            this.Id = id;
            this.Name = name;
            this._possibleDifficulty = difficulty;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }

        public void NextChain(Employee next)
        {
            this._nextChain = next;
        }

        public string HandleTicket(Ticket ticket)
        {
            string s = string.Empty;

            if (ticket.Difficulty == this._possibleDifficulty) // difficulty check
            {
                s = HandleProperly(ticket); // do something
            }
            else // pass to higher position
            {
                try // to prevent not chained status
                {
                    s = this._nextChain.HandleTicket(ticket);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return s;
        }
    }
}
