namespace ECO_DX_For_PUR.DATA.Entities.PI_BASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModelMaster")]
    public partial class ModelMaster
    {
        [Key]
        public int MODEL_ID { get; set; }

        [StringLength(50)]
        public string MODEL_NAME { get; set; }

        [StringLength(50)]
        public string SERIES { get; set; }

        [StringLength(50)]
        public string CUSTOMER_ID { get; set; }

        public bool? IS_BARCODE { get; set; }

        public DateTime? UPD_TIME { get; set; }

        [StringLength(50)]
        public string CUSTOMER_SAP { get; set; }
    }
}
