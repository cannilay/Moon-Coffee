namespace Moon_Coffee.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Masa")]
    public partial class Masa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Masa()
        {
            Satıs = new HashSet<Satıs>();
        }

        public int masaID { get; set; }

        [StringLength(50)]
        public string masaNo { get; set; }

        public bool? masaDurum { get; set; }

        public int? kullaniciID { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satıs> Satıs { get; set; }
    }
}
