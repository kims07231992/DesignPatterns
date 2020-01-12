using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingLibrary.Systems
{
    public class BusSystem
    {
        public enum PreferredFloor { First, Second };

        public bool BookBus(string name, PreferredFloor preferredFloor)
        {
            bool result = false;

            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException();
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
