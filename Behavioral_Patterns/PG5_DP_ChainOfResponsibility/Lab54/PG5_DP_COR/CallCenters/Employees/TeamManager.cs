using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG5_DP_COR.CallCenters.Issues;

namespace PG5_DP_COR.CallCenters.Employees
{
    public class TeamManager : Employee
    {
        public TeamManager(int id, string name, Difficulty difficulty) : base(id, name, difficulty)
        {
            this._possibleDifficulty = Difficulty.Medium; // able to handle 'Medium'
        }

        protected override string HandleProperly(Ticket ticket)
        {
            return "Handled by team manager.";
        }
    }
}
