namespace Moon_Coffee.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Icerik")]
    public partial class Icerik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Icerik()
        {
            Satıs = new HashSet<Satıs>();
        }

        public int icerikID { get; set; }

        public int? kategoriID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string adet { get; set; }

        [StringLength(50)]
        public string fiyat { get; set; }

        public virtual Kategori Kategori { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satıs> Satıs { get; set; }
    }
}
