using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG5_DP_COR.CallCenters.Issues;

namespace PG5_DP_COR.CallCenters.Employees
{
    public class GeneralManager : Employee
    {
        public GeneralManager(int id, string name, Difficulty difficulty) : base(id, name, difficulty)
        {
            this._possibleDifficulty = Difficulty.High; // able to handle 'High'
        }

        protected override string HandleProperly(Ticket ticket)
        {
            return "Handled by general manager.";
        }
    }
}
