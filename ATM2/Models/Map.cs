namespace ATM2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Map")]
    public partial class Map
    {
        public int Id { get; set; }

        public int FromLocationId { get; set; }

        public int ToLocationId { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; }

        public decimal Lenght { get; set; }

        public decimal AverageSpeed { get; set; }

        public virtual Location Location { get; set; }

        public virtual Location Location1 { get; set; }
    }
}
