namespace Event_Hall_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Venue")]
    public partial class Venue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venue()
        {
            Events = new HashSet<Event>();
            Packages = new HashSet<Package>();
        }

        [Key]
        public int Venue_ID { get; set; }

        [StringLength(50)]
        public string Venue_Name { get; set; }

        [StringLength(200)]
        public string Venue_Details { get; set; }

        [StringLength(200)]
        public string Venue_Picture { get; set; }

        [StringLength(50)]
        public string Venue_Email { get; set; }

        [StringLength(50)]
        public string Venue_Contact { get; set; }

        [StringLength(100)]
        public string Venue_Location { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package> Packages { get; set; }
    }
}
