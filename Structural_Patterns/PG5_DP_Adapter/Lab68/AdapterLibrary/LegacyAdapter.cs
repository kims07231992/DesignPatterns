using LegacyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLibrary
{
    public class LegacyAdapter : ILegacyGettable
    {
        private static readonly Lazy<List<char>> _legacyCaseCategories 
            = new Lazy<List<char>>() { Value = { 'A', 'B', 'C' } };

        private Lazy<Legacy> _legacy = new Lazy<Legacy>();

        public LegacyAdapter()
        {

        }

        public int GetCode(string code)
        {
            int result;

            try
            {
                if (string.IsNullOrEmpty(code))
                {
                    throw new ArgumentNullException();
                }

                for (int i = 1; i < code.Length; i++)
                {
                    if (!('0' <= code[i] && code[i] <= '9'))
                    {
                        throw new ArgumentException();
                    }
                }

                char category = code[0]; // First char
                string numberPart = code.Substring(1); // Start with 2nd char
                int legacyCode = int.Parse(numberPart);

                result = _legacyCaseCategories.Value.Contains(category)
                    ? this._legacy.Value.GetLegacyCode(category, legacyCode) // Legacy case
                    : legacyCode; // Current system case
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
