namespace Event_Hall_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookingDetail
    {
        [Key]
        public int BookingDetail_ID { get; set; }

        [StringLength(50)]
        public string BookingDetail_Name { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public int? Booking_FID { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
