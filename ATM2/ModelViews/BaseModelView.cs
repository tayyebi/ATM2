using ATM2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM2.ModelViews
{
    class BaseModelView
    {
        // protected DbContext databaseContext;
        protected MainModel databaseContext;
        public BaseModelView(ref
            // DbContext DatabaseContext
            MainModel DatabaseContext
            )
        {
            databaseContext = DatabaseContext;
        }
    }
}
