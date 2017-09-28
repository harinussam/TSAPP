namespace TSDataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPLOYEEPROJECTTIME")]
    public partial class EMPLOYEEPROJECTTIME
    {
        [Key]
        public int EMPPROJECTTIMEID { get; set; }

        public int? PROJECTEMPID { get; set; }

        public int? DAYENTRYID { get; set; }

        [StringLength(700)]
        public string NOTES { get; set; }

        public int CREATEDBY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CREATEDDATE { get; set; }

        public int? LASTUPDATEDBY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LASTUPDATEDDATE { get; set; }

        public double? TIME { get; set; }

        public virtual DAYENTRY DAYENTRY { get; set; }

        public virtual PROJECTEMPLOYEE PROJECTEMPLOYEE { get; set; }
    }
}
