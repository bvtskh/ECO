namespace ECO_DX_For_PUR.DATA.COST_SYSTEM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    public partial class PUR_ZMM80
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string INTERNAL_MATERIAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ETA_FACTORY_DATE { get; set; }
    }
}
