namespace Moon_Coffee.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("surup")]
    public partial class surup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public surup()
        {
            Ekstra = new HashSet<Ekstra>();
        }

        public int surupID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string fiyat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ekstra> Ekstra { get; set; }
    }
}
