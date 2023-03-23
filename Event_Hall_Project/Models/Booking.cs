namespace Event_Hall_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        [Key]
        public int Booking_ID { get; set; }

        [StringLength(100)]
        public string Booking_Details { get; set; }

        [StringLength(50)]
        public string Customer_Name { get; set; }

        [StringLength(20)]
        public string Customer_Contact { get; set; }

        [StringLength(20)]
        public string Customer_Email { get; set; }

        [StringLength(250)]
        public string Message { get; set; }

        public int? Package_FID { get; set; }

        public DateTime? Date { get; set; }

        public int? No_of_People { get; set; }

        public virtual Package Package { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
