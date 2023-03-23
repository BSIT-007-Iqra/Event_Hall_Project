namespace Event_Hall_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        public int Admin_ID { get; set; }

        [StringLength(50)]
        public string Admin_Name { get; set; }

        [StringLength(50)]
        public string Admin_Email { get; set; }

        [StringLength(15)]
        public string Admin_Password { get; set; }

        [StringLength(20)]
        public string Admin_Contact { get; set; }

        [StringLength(250)]
        public string Admin_Picture { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        public int? AccessLevel_FID { get; set; }

        public virtual AccessLevel_ AccessLevel_ { get; set; }
    }
}
