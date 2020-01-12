using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Builder.Vehicles.TwoWheelers
{
    //'================================================================================================================
    //' CLASS NAME  : ElectricBike
    //'               1. Concrete class of TwoWheelerBuilder
    //'               2. Builder pattern.
    //'               3. Skipped specific realization for unique options.
    //'================================================================================================================
    public class ElectricBike : TwoWheelerBuilder
    {
        public ElectricBike()
        {

        }

        public override TwoWheeler Build()
        {
            this._twoWheeler.Value.Frame = "ElectricBike Frame " + this._frameType;
            this._twoWheeler.Value.FrontWheel = "ElectricBike FrontWheel #" + this._frontWheelSize;
            this._twoWheeler.Value.RearWheel = "ElectricBike RearWheel #" + this._rearWheelSize;
            this._twoWheeler.Value.Saddle = "ElectricBike Saddle " + this._saddleType;

            return this._twoWheeler.Value;
        }

        public override void MakeFrame()
        {
            this._frameType = "Aluminum";
            // do somthing more with ElectricBike
        }

        public override void AssembleFrontWheel(double size)
        {
            this._frontWheelSize = size;
            // do somthing more with ElectricBike
        }

        public override void AssembleRearWheel(double size)
        {
            this._rearWheelSize = size;
            // do somthing more with ElectricBike
        }

        public override void PutSaddle(string type)
        {
            this._saddleType = type;
            // do somthing more with ElectricBike
        }
    }
}
