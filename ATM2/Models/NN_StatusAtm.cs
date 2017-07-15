namespace ATM2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NN_StatusAtm
    {
        public int Id { get; set; }

        public int StatusId { get; set; }

        [Required]
        [StringLength(10)]
        public string AtmId { get; set; }

        public virtual ATM ATM { get; set; }

        public virtual Status Status { get; set; }
    }
}
