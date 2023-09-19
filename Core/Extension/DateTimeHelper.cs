using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extension
{
    public static class DateTimeHelper
    {
        public static bool EquilBirthDay(this DateTime masterDate, DateTime slaveDate)
        {
            return masterDate.Month == slaveDate.Month && masterDate.Day == slaveDate.Day;
        }
    }
}
