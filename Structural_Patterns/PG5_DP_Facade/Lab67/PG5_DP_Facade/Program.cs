using BookingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookingLibrary.Systems.BusSystem;

namespace PG5_DP_Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            bool isBookingSuccess = false;

            try
            {
                // Set dummy data
                string name = "Jason Kim";
                string passport = "ABCD1234";
                DateTime? fromDate = new DateTime(2018, 1, 1, 0, 0, 0);
                DateTime? toDate = new DateTime(2018, 1, 10, 0, 0, 0);
                PreferredFloor preferredFloor = PreferredFloor.First;

                // Start integrated(Facade) system for booking
                var booker = new Booker();
                isBookingSuccess = booker.BookPackageProduct(name, passport, fromDate, toDate, preferredFloor);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string resultMessage = isBookingSuccess ? "Booking has beed succeeded." : "Booking has been failed.";
            Console.WriteLine(resultMessage);
        }
    }
}
