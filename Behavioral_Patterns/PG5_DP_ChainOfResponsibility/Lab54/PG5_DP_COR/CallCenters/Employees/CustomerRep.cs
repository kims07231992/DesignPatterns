using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG5_DP_COR.CallCenters.Issues;

namespace PG5_DP_COR.CallCenters.Employees
{
    public class CustomerRep : Employee
    {
        public CustomerRep(int id, string name, Difficulty difficulty) : base(id, name, difficulty)
        {
            this._possibleDifficulty = Difficulty.Low; // able to handle 'Low'
        }

        protected override string HandleProperly(Ticket ticket)
        {
            return "Handled by customer representative.";
        }
    }
}
