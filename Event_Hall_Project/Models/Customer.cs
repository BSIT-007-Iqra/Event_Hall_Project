namespace Event_Hall_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        public int Customer_ID { get; set; }

        [StringLength(50)]
        public string Customer_Name { get; set; }

        [StringLength(50)]
        public string Customer_Email { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(20)]
        public string Customer_Contact { get; set; }
    }
}
