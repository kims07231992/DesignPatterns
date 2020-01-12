using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Builder.Vehicles.TwoWheelers
{
    //'================================================================================================================
    //' CLASS NAME  : TwoWheeler
    //'               1. Model class of TwoWheelers.
    //'================================================================================================================
    public class TwoWheeler
    {
        public string Frame { get; set; } = string.Empty;
        public string FrontWheel { get; set; } = string.Empty;
        public string RearWheel { get; set; } = string.Empty;
        public string Saddle { get; set; } = string.Empty;
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", Frame, FrontWheel, RearWheel, Saddle);
        }
    }
}
