namespace ECO_DX_For_PUR.DATA.Entities.ECN_ECO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Versions")]
    public partial class Versions
    {
        [Key]
        [Column("VERSION")]
        [StringLength(10)]
        public string VERSION1 { get; set; }

        public DateTime? CREATE_DATE { get; set; }

        [StringLength(500)]
        public string REMARK { get; set; }
    }
}
