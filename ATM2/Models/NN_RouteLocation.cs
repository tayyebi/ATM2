namespace ATM2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NN_RouteLocation
    {
        public int Id { get; set; }

        public int RouteId { get; set; }

        public int LocationId { get; set; }

        public short Index { get; set; }

        public virtual Location Location { get; set; }

        public virtual Route Route { get; set; }
    }
}
