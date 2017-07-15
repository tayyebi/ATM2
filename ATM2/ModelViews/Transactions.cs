using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM2.Models;

namespace ATM2.ModelViews
{
    class Transactions : BaseModelView
    {
        public Transactions(ref MainModel DatabaseContext) : base(ref DatabaseContext)
        {
        }
        public IEnumerable<object> LastActivity()
        {
            return databaseContext.ATMs.Select(x => new
            {
                x.LocationId,
                x.Code
            })
            .ToList();
        }
    }
}
