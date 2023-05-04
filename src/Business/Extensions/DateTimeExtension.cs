using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Extensions
{
    public static class DateTimeExtension
    {
        public static int CalculateAge(this DateTime date)
        {
            var today = DateTime.Now;

            int age = today.Year - date.Year;
            
            if (date.Date > today.AddYears(age)) return --age;

            return age;

        }
    }
}