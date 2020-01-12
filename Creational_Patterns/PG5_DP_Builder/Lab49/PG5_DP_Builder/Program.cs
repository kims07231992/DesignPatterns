using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PG5_DP_Builder.Vehicles.TwoWheelers;

namespace PG5_DP_Builder
{
    public class Program
    {
        private delegate TwoWheeler BuilderDelegate();
        public static void Main(string[] args)
        {
            Run();
        }
        public static void Run()
        {
            List<BuilderDelegate> builderDel = new List<BuilderDelegate>() { BuildElectricBike, BuildMotorcycle, BuildBike };
            TwoWheeler twoWheeler;

            foreach (BuilderDelegate bd in builderDel)
            {
                twoWheeler = bd();
                Console.WriteLine(twoWheeler.ToString());
            }
        } 
        private static TwoWheeler BuildElectricBike() // test ElectricBike, selected whole options.
        {
            TwoWheelerBuilder builder = new ElectricBike();
            TwoWheeler twoWheeler;
            builder.MakeFrame();
            builder.AssembleFrontWheel(25.0);
            builder.AssembleRearWheel(25.0);
            builder.PutSaddle("Triangle");
            twoWheeler = builder.Build();

            return builder.Build();
        }
        private static TwoWheeler BuildMotorcycle() // test Motorcycle, selected several options.
        {
            TwoWheelerBuilder builder = new Motorcycle();
            TwoWheeler twoWheeler;
            builder.MakeFrame();
            builder.PutSaddle("Square");
            twoWheeler = builder.Build();

            return builder.Build();
        }
        private static TwoWheeler BuildBike() // test Bike, selected only frame option.
        {
            TwoWheelerBuilder builder = new Bike();
            TwoWheeler twoWheeler;
            builder.MakeFrame();
            twoWheeler = builder.Build();

            return builder.Build();
        }
    }
}
