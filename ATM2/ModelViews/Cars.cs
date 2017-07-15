using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM2.Models;

namespace ATM2.ModelViews
{
    class Cars : BaseModelView
    {
        public Cars(ref MainModel DatabaseContext) : base(ref DatabaseContext)
        {
        }
        public IEnumerable<object> Select()
        {
            return databaseContext.Cars.Select(x => new { x.Id, x.Model, x.Number }).ToList();
        }
    }
}
