using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.Systems
{
    public class HotelSystem
    {
        public bool BookHotel(string name, DateTime? fromDate, DateTime? toDate)
        {
            bool result = false;

            try
            {

                if (string.IsNullOrEmpty(name) || !fromDate.HasValue || !toDate.HasValue)
                {
                    throw new ArgumentNullException();
                }

                double daysToStay = (toDate.Value - fromDate.Value).TotalDays;
                if (daysToStay < 0)
                {
                    throw new ArgumentException();
                }

                // Do something for booking
                result = true; // Success case
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
