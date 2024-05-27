namespace Moon_Coffee.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Gecmis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gecmis()
        {
            Satıs = new HashSet<Satıs>();
        }

        public int gecmisID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string soyad { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tarihh { get; set; }

        [StringLength(50)]
        public string toplamTutar { get; set; }

        [StringLength(50)]
        public string odemeTur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satıs> Satıs { get; set; }
    }
}
