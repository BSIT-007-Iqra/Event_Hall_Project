namespace Event_Hall_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessLevel ")]
    public partial class AccessLevel_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccessLevel_()
        {
            Admins = new HashSet<Admin>();
        }

        public int AccessLevel_ID { get; set; }

        [StringLength(50)]
        public string AccessLevel_Name { get; set; }

        [StringLength(150)]
        public string AccessLevel_Detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Admin> Admins { get; set; }
    }
}
