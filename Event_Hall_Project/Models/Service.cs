namespace Event_Hall_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Service")]
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            Packages = new HashSet<Package>();
        }

        [Key]
        public int Service_ID { get; set; }

        [StringLength(50)]
        public string Service_Name { get; set; }

        [StringLength(300)]
        public string Service_Details { get; set; }

        [StringLength(200)]
        public string Service_Picture { get; set; }

        public int? ServiceCategory_FID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package> Packages { get; set; }

        public virtual ServiceCategory ServiceCategory { get; set; }
    }
}
