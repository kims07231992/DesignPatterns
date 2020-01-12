using BookingLibrary.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookingLibrary.Systems.BusSystem;

namespace BookingLibrary
{
    public class Booker
    {
        private Lazy<AirlineSystem> _airlineSystem = new Lazy<AirlineSystem>();
        private Lazy<BusSystem> _busSystem = new Lazy<BusSystem>();
        private Lazy<HotelSystem> _hotelSystem = new Lazy<HotelSystem>();

        public bool BookPackageProduct(string name, string passport, DateTime? fromDate, DateTime? toDate, PreferredFloor preferredFloor)
        {
            bool result = false;

            try
            {
                bool isAirlineBookingSuccess = _airlineSystem.Value.BookFlight(name, passport);

                bool isBusBookingSuccess = _busSystem.Value.BookBus(name, preferredFloor);

                bool isHotelBookingSuccess = _hotelSystem.Value.BookHotel(name, fromDate, toDate);

                if (isAirlineBookingSuccess && isBusBookingSuccess && isHotelBookingSuccess)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                // Logging
                throw;
            }

            return result;
        }
    }
}
