namespace Moon_Coffee.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            Masa = new HashSet<Masa>();
        }

        public int kullaniciID { get; set; }

        [StringLength(50)]
        public string kullaniciAdi { get; set; }

        [StringLength(50)]
        public string sifre { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string soyad { get; set; }

        [StringLength(5)]
        public string cinsiyet { get; set; }

        [StringLength(11)]
        public string telefon { get; set; }

        [StringLength(50)]
        public string eposta { get; set; }

        public string adres { get; set; }

        [StringLength(10)]
        public string unvan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? kayitTarihi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ayrilmaTarihi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Masa> Masa { get; set; }
    }
}
