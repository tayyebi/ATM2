using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM2.Models;

namespace ATM2.ModelViews
{
    class Zones : BaseModelView
    {
        public Zones(ref MainModel DatabaseContext) : base(ref DatabaseContext)
        {
        }

        public IEnumerable<object> DropDown()
        {
            var query = (from zone in databaseContext.Zones
                         select  zone
             );
            return query.ToList();
        }

    }
}
