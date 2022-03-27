using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveFromSecondList.Classes
{
    public sealed class DatesCreated
    {
        private static readonly Lazy<DatesCreated> Lazy =
            new Lazy<DatesCreated>(() 
                => new DatesCreated());

        public static DatesCreated Instance => Lazy.Value;
        private List<DateTime> _dateTimesList = new List<DateTime>();

        private void CreateList()
        {
            DateTime start = DateTime.Today;
            _dateTimesList = Enumerable.Range(1, 31)
                .Select(x => start.AddDays(x))
                .ToList();
        }

        public bool HasDates => _dateTimesList.Any();
        public DateTime GetNextDate()
        {
            if (!_dateTimesList.Any())
            {
                throw new Exception("No more dates");
            }

            var date = _dateTimesList.FirstOrDefault();
            _dateTimesList.Remove(date);

            return date;

        }

        private DatesCreated()
        {
            CreateList();
        }
    }
}