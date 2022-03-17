using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenCodeSample.Extensions
{
    public class DateHelper
    {
        /// <summary>
        /// Format date as days left
        /// </summary>
        /// <param name="expiryDate">Expiration date</param>
        /// <returns>days remaining</returns>
        public static string CalculateExpirationTime(DateTime expiryDate)
        {
            var currentDate = DateTime.Now;
            var dateDifference = (expiryDate - currentDate);
            return dateDifference.Days >= 1 ? $"{ dateDifference.Days } day(s)" : "Expired";
        }
    }
}
