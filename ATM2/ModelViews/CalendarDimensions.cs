using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM2.Models;

namespace ATM2.ModelViews
{
    class CalendarDimensions : BaseModelView
    {
        public CalendarDimensions(ref MainModel DatabaseContext) : base(ref DatabaseContext)
        {

        }


        public IEnumerable<object> Years()
        {
            var query = (from calendar in databaseContext.CalendarDimensions
                         group calendar by calendar.Year into C
                         select new { Year = C.Key }
                         );
            return query
                 .OrderBy(m => m.Year)
                .ToList();
        }

        public IEnumerable<object> Monthes(int Year)
        {
            var query = (from calendar in databaseContext.CalendarDimensions
                         where calendar.Year == Year
                         group calendar by calendar.Month into C
                         select new { Month = C.Key }
                         );
            return query
                .OrderBy(m => m.Month)
                .ToList();
        }
    }
}
