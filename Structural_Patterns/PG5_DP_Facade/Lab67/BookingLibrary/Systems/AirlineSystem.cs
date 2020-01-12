using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.Systems
{
    public class AirlineSystem
    {
        public bool BookFlight(string name, string passport)
        {
            bool result = false;

            try
            {
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(passport))
                {
                    throw new ArgumentNullException();
                }

                // Do something for booking
                result = true;
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
