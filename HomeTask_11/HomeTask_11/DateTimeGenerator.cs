using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11
{
    internal class DateTimeGenerator : IDateTimeGenerator
    {
        public string GetCurrentDateTime()
        {
            return DateTime.Now.ToString();
        }

        public string GetRandomDateTіme()
        {
            Random random = new Random();
            DateTime randomDateTime = DateTime.Now.AddDays(random.Next(-30, 30));
            return randomDateTime.ToString();
        }
      
    }
}
