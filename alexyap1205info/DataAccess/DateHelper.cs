using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DateHelper
    {
        internal enum Months
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        public static string GetDateDisplay(int year, int month)
        {
            string result = null;

            if (year == 0 && month == 0)
            {
                result = String.Empty;
            }
            else
            {
                if (month > 0 && month < 13)
                {
                    result = ((Months)month).ToString();
                }

                if (year != 0)
                {
                    if (!String.IsNullOrEmpty(result))
                    {
                        result += "/";
                    }

                    result += Convert.ToString(year);
                }
            }

            return result;
        }
    }
}
