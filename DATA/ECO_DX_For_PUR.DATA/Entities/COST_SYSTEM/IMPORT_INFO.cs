namespace ECO_DX_For_PUR.DATA.COST_SYSTEM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMPORT_INFO
    {
        public int ID { get; set; }

        [Required]
        [StringLength(500)]
        public string FileName { get; set; }

        [Required]
        [StringLength(50)]
        public string Func { get; set; }

        [Required]
        [StringLength(50)]
        public string Hostname { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
