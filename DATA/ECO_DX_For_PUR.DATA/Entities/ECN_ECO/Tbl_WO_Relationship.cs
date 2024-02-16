namespace ECO_DX_For_PUR.DATA.Entities.ECN_ECO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_WO_Relationship
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Customer { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(20)]
        public string AI { get; set; }

        public int? AI_Qty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AI_Date_Pro { get; set; }

        [StringLength(20)]
        public string SMTA { get; set; }

        public int? SMTA_Qty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SMTA_Date_Pro { get; set; }

        [StringLength(20)]
        public string SMTB { get; set; }

        public int? SMTB_Qty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SMTB_Date_Pro { get; set; }

        [StringLength(20)]
        public string SMT { get; set; }

        public int? SMT_Qty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SMT_Date_Pro { get; set; }

        [StringLength(20)]
        public string FAT1 { get; set; }

        public int? FAT1_Qty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FAT1_Date_Pro { get; set; }

        [StringLength(20)]
        public string FAT2 { get; set; }

        public int? FAT2_Qty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FAT2_Date_Pro { get; set; }

        [StringLength(20)]
        public string FAT3 { get; set; }

        public int? FAT3_Qty { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FAT3_Date_Pro { get; set; }

        [StringLength(50)]
        public string Updater { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(50)]
        public string HostName { get; set; }

        public int? Change_ID { get; set; }

        [StringLength(20)]
        public string Change_Name { get; set; }
    }
}
