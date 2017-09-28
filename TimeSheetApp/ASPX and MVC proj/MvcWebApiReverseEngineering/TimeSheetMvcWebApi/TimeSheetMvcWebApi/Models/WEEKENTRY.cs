namespace TimeSheetMvcWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WEEKENTRY")]
    public partial class WEEKENTRY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WEEKENTRY()
        {
            DAYENTRies = new HashSet<DAYENTRY>();
        }

        public int WEEKENTRYID { get; set; }

        public int EMPID { get; set; }

        [Column(TypeName = "date")]
        public DateTime WEEKSTARTDATE { get; set; }

        public int CREATEDBY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CREATEDDATE { get; set; }

        public int? LASTUPDATEDBY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LASTUPDATEDDATE { get; set; }

        public bool? STATUS { get; set; }

        public double? TIME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAYENTRY> DAYENTRies { get; set; }

        public virtual EMPLOYEE EMPLOYEE { get; set; }
    }
}
