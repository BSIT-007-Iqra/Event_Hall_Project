namespace Event_Hall_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EventOrganizer
    {
        [Key]
        public int EventOrganizer_ID { get; set; }

        [StringLength(50)]
        public string EventOrganizer_Name { get; set; }

        [StringLength(50)]
        public string EventOrganizer_Email { get; set; }

        [StringLength(20)]
        public string EventOrganizer_Password { get; set; }

        [StringLength(20)]
        public string EventOrganizer_Contact { get; set; }
    }
}
