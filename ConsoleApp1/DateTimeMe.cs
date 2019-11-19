using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DateTimeMe : IDateTimeMe
    {
        public DateTime getDateNow()
        {
            return DateTime.Now;
        }
    }
}
