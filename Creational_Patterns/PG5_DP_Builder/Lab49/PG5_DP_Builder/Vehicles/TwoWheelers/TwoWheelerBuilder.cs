using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Builder.Vehicles.TwoWheelers
{
    //'================================================================================================================
    //' CLASS NAME  : TwoWheelerBuilder
    //'               1. Abstract class of TwoWheeler's builder pattern.
    //'               2. Builder pattern.
    //'================================================================================================================
    public abstract class TwoWheelerBuilder
    {
        protected string _frameType;
        protected double _frontWheelSize;
        protected double _rearWheelSize;
        protected string _saddleType;
        protected Lazy<TwoWheeler> _twoWheeler = new Lazy<TwoWheeler>(); // to init with Build()

        public abstract void MakeFrame();
        public abstract void AssembleFrontWheel(double size);
        public abstract void AssembleRearWheel(double size);
        public abstract void PutSaddle(string type);
        public abstract TwoWheeler Build();
    }
}
