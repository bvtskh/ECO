namespace ECO_DX_For_PUR.DATA.Entities.PI_BASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [StringLength(50)]
        public string CUSTOMER_ID { get; set; }

        [StringLength(50)]
        public string CUSTOMER_GROUP { get; set; }

        [Required]
        [StringLength(50)]
        public string CUSTOMER_NAME { get; set; }
    }
}
