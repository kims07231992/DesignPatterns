using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_COR.CallCenters.Issues
{
    public enum Difficulty { Low, Medium, High, VeryHigh }

    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Issue { get; set; }
        public Difficulty Difficulty { get; set; }
    }
}
