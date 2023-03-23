namespace Event_Hall_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FAQ
    {
        [Key]
        public int FAQs_ID { get; set; }

        [StringLength(500)]
        public string FAQs_Questions { get; set; }

        [StringLength(500)]
        public string FAQs_Answer { get; set; }
    }
}
