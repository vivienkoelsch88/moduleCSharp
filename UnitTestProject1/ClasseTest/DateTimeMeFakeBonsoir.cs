using ConsoleApp1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.ClasseTest
{
    class DateTimeMeFakeBonsoir : IDateTimeMe
    {
        public DateTime getDateNow()
        {
            //return une date en weekend
            return new DateTime(2019, 11, 18, 20, 0, 0);
        }
    }
}
