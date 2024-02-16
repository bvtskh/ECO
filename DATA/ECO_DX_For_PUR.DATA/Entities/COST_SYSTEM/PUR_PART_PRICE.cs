namespace ECO_DX_For_PUR.DATA.COST_SYSTEM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PUR_PART_PRICE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string PUR_INFO_REC { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime QUOTE_DATE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string PART_NO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string RATE_UNIT { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal UNIT_PRICE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string REF_NO { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string CREATE_USER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CREATE_DATE { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "date")]
        public DateTime VALID_FROM { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "date")]
        public DateTime VALID_TO { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string SUPPLIER { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string SUPPLIER_NAME { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool FIXED_VENDOR { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string MANUFACTURER_NAME { get; set; }
    }
}
