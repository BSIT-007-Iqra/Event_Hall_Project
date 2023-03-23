namespace Event_Hall_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slider")]
    public partial class Slider
    {
        [Key]
        public int Slider_ID { get; set; }

        [StringLength(200)]
        public string Slider_Picture { get; set; }

        [StringLength(500)]
        public string Slider_Detail1 { get; set; }

        [StringLength(500)]
        public string Slider_Detail2 { get; set; }

        [StringLength(10)]
        public string Reference { get; set; }
    }
}
