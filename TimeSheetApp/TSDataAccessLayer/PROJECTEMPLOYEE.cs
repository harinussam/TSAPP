namespace TSDataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROJECTEMPLOYEE")]
    public partial class PROJECTEMPLOYEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROJECTEMPLOYEE()
        {
            EMPLOYEEPROJECTTIMEs = new HashSet<EMPLOYEEPROJECTTIME>();
        }

        [Key]
        public int PROJECTEMPID { get; set; }

        public int? EMPID { get; set; }

        public int? PROJECTID { get; set; }

        public double? TOTALEXPECTEDHOURS { get; set; }

        public double? TOTALALLOCATEDHOURS { get; set; }

        public int CREATEDBY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CREATEDDATE { get; set; }

        public int? LASTUPDATEDBY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LASTUPDATEDDATE { get; set; }

        public virtual EMPLOYEE EMPLOYEE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEEPROJECTTIME> EMPLOYEEPROJECTTIMEs { get; set; }

        public virtual PROJECT PROJECT { get; set; }
    }
}
