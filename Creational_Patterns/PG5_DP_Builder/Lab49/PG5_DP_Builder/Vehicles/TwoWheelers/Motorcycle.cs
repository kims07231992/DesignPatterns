using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Builder.Vehicles.TwoWheelers
{
    //'================================================================================================================
    //' CLASS NAME  : Motorcycle
    //'               1. Concrete class of TwoWheelerBuilder
    //'               2. Builder pattern.
    //'               3. Skipped specific realization for unique options.
    //'================================================================================================================
    public class Motorcycle : TwoWheelerBuilder
    {
        public Motorcycle()
        {
            
        }

        public override TwoWheeler Build()
        {
            this._twoWheeler.Value.Frame = "Motorcycle Frame " + this._frameType;
            this._twoWheeler.Value.FrontWheel = "Motorcycle FrontWheel #" + this._frontWheelSize;
            this._twoWheeler.Value.RearWheel = "Motorcycle RearWheel #" + this._rearWheelSize;
            this._twoWheeler.Value.Saddle = "Motorcycle Saddle " + this._saddleType;

            return this._twoWheeler.Value;
        }

        public override void MakeFrame()
        {
            this._frameType = "Aluminum";
            // do somthing more with Motorcycle
        }

        public override void AssembleFrontWheel(double size)
        {
            this._frontWheelSize = size;
            // do somthing more with Motorcycle
        }

        public override void AssembleRearWheel(double size)
        {
            this._rearWheelSize = size;
            // do somthing more with Motorcycle
        }

        public override void PutSaddle(string type)
        {
            this._saddleType = type;
            // do somthing more with Motorcycle
        }
    }
}
