namespace ATM2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NN_CarMission
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int MissionId { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public short WasOK { get; set; }

        public short BetterThanBefore { get; set; }

        public virtual Car Car { get; set; }

        public virtual Mission Mission { get; set; }
    }
}
