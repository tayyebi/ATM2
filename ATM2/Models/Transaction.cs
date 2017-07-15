namespace ATM2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction")]
    public partial class Transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaction()
        {
            Packages = new HashSet<Package>();
        }

        public int Id { get; set; }

        public bool Successful { get; set; }

        [Required]
        [StringLength(1)]
        public string Way { get; set; }

        public int DateKey { get; set; }

        public int? CarId { get; set; }

        [StringLength(10)]
        public string AtmId { get; set; }

        public virtual ATM ATM { get; set; }

        public virtual CalendarDimension CalendarDimension { get; set; }

        public virtual Car Car { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package> Packages { get; set; }
    }
}
