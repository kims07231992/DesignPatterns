using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG5_DP_COR.CallCenters.Issues;

namespace PG5_DP_COR.CallCenters.Employees
{
    public class VicePresident : Employee
    {
        public VicePresident(int id, string name, Difficulty difficulty) : base(id, name, difficulty)
        {
            this._possibleDifficulty = Difficulty.VeryHigh; // able to handle 'VeryHigh'
        }

        protected override string HandleProperly(Ticket ticket)
        {
            return "Handled by vice president.";
        }
    }
}
