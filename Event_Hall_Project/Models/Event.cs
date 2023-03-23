namespace Event_Hall_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            Packages = new HashSet<Package>();
        }

        [Key]
        public int Event_ID { get; set; }

        [StringLength(50)]
        public string Event_Name { get; set; }

        [StringLength(300)]
        public string Event_Details { get; set; }

        [StringLength(200)]
        public string Event_Picture { get; set; }

        public DateTime? Event_Date { get; set; }

        public int Venue_FID { get; set; }

        public virtual Venue Venue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package> Packages { get; set; }
    }
}
