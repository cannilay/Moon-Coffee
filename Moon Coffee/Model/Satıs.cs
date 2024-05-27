namespace Moon_Coffee.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Satıs
    {
        [Key]
        public int satisID { get; set; }

        public int? gecmisID { get; set; }

        public int? icerikID { get; set; }

        public int? ekstraID { get; set; }

        public int? bardakBoyID { get; set; }

        public int? masaID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tarih { get; set; }

        public virtual BardakBoy BardakBoy { get; set; }

        public virtual Ekstra Ekstra { get; set; }

        public virtual Gecmis Gecmis { get; set; }

        public virtual Icerik Icerik { get; set; }

        public virtual Masa Masa { get; set; }
    }
}
