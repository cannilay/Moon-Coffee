namespace Moon_Coffee.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OdemeTuru")]
    public partial class OdemeTuru
    {
        [Key]
        [StringLength(50)]
        public string odemeTurID { get; set; }

        [Column("odemeTuru")]
        [StringLength(50)]
        public string odemeTuru1 { get; set; }

        public bool? durum { get; set; }

        [StringLength(50)]
        public string toplamTutar { get; set; }
    }
}
