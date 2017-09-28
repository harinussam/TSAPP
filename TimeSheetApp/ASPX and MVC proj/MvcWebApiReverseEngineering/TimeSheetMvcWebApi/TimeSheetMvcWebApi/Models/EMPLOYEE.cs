namespace TimeSheetMvcWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPLOYEE")]
    public partial class EMPLOYEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLOYEE()
        {
            WEEKENTRies = new HashSet<WEEKENTRY>();
            PROJECTEMPLOYEEs = new HashSet<PROJECTEMPLOYEE>();
        }

        [Key]
        public int EMPID { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        public int CREATEDBY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CREATEDDATE { get; set; }

        public int? LASTUPDATEDBY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LASTUPDATEDDATE { get; set; }

        public bool? ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WEEKENTRY> WEEKENTRies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJECTEMPLOYEE> PROJECTEMPLOYEEs { get; set; }
    }
}
