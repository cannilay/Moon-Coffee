namespace Moon_Coffee.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ekstra")]
    public partial class Ekstra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ekstra()
        {
            Satıs = new HashSet<Satıs>();
        }

        public int ekstraID { get; set; }

        public int? sutID { get; set; }

        public int? surupID { get; set; }

        public virtual surup surup { get; set; }

        public virtual sut sut { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satıs> Satıs { get; set; }
    }
}
