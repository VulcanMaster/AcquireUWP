using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcquireNameday
{
    class NamedayModel
    {
        public int Month { get; }
        public int Day { get; }
        public IEnumerable<string> Names { get; }

        public NamedayModel(int month, int day, IEnumerable<string> names)
        {
            Month = month;
            Day = day;
            Names = names;
        }

        public string NameAsString => string.Join(", ", Names); // C#6 alert

        //public string NamesAsString {
        //    get { return string.Join(", ", Names); }
        //}
    }
}
