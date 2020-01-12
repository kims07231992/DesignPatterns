using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyLibrary
{
    public class Legacy
    {
        public int GetLegacyCode(char category, int code)
        {
            switch (category)
            {
                case 'A':
                    return (code < 100) ? code : code + 100;
                case 'B':
                    return (code < 500) ? code : code + 500;
                case 'C':
                    return (code < 1000) ? code : code + 300;
                default:
                    return 999;
            }
        }
    }
}
