namespace ECO_DX_For_PUR.DATA.COST_SYSTEM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BC_BOM_LIST
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MODEL_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string PART_NO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ASSEMBLY_NO { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal RATIO { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal UNIT_QTY { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime CREATE_DATE { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool RUNNING_CHANGE { get; set; }

        [StringLength(50)]
        public string FOLLOW_UP { get; set; }

        [StringLength(50)]
        public string ALT_GROUP { get; set; }

        [StringLength(2000)]
        public string LOCATION { get; set; }
    }
}
