namespace Event_Hall_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceCategory")]
    public partial class ServiceCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceCategory()
        {
            Services = new HashSet<Service>();
        }

        [Key]
        public int ServiceCategory_ID { get; set; }

        [StringLength(50)]
        public string ServiceCategory_Name { get; set; }

        [StringLength(200)]
        public string ServiceCategory_Details { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service> Services { get; set; }
    }
}
