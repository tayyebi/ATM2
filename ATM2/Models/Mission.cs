namespace ATM2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mission")]
    public partial class Mission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mission()
        {
            NN_CarMission = new HashSet<NN_CarMission>();
        }

        public int Id { get; set; }

        public DateTime ScheduledStart { get; set; }

        public DateTime RealStart { get; set; }

        public DateTime ScheduledEnd { get; set; }

        public DateTime ReadlEnd { get; set; }

        public int RouteId { get; set; }

        public virtual Route Route { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NN_CarMission> NN_CarMission { get; set; }
    }
}
