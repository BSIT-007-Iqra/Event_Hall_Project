namespace Event_Hall_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Package")]
    public partial class Package
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Package()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        public int Package_ID { get; set; }

        [StringLength(50)]
        public string Package_Name { get; set; }

        [StringLength(200)]
        public string Package_Details { get; set; }

        public decimal? Price { get; set; }

        public int? Service_FID { get; set; }

        public int? Event_FID { get; set; }

        public int? Venue_FID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual Event Event { get; set; }

        public virtual Service Service { get; set; }

        public virtual Venue Venue { get; set; }
    }
}
