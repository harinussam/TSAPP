namespace TimeSheetMvcWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DAYENTRY")]
    public partial class DAYENTRY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAYENTRY()
        {
            EMPLOYEEPROJECTTIMEs = new HashSet<EMPLOYEEPROJECTTIME>();
        }

        public int DAYENTRYID { get; set; }

        public int? WEEKENTRYID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DAYDATE { get; set; }

        public int? DAYNUMBER { get; set; }

        public int CREATEDBY { get; set; }

        public int? LASTUPDATEDBY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LASTUPDATEDDATE { get; set; }

        public double? TIME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEEPROJECTTIME> EMPLOYEEPROJECTTIMEs { get; set; }

        public virtual WEEKENTRY WEEKENTRY { get; set; }
    }
}
