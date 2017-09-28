namespace TimeSheetMvcWebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROJECT")]
    public partial class PROJECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROJECT()
        {
            PROJECTEMPLOYEEs = new HashSet<PROJECTEMPLOYEE>();
        }

        public int projectId { get; set; }

        public int? CLIENTID { get; set; }

        [StringLength(900)]
        public string DESCRIPTION { get; set; }

        public double? TOTALEXPECTEDHOURS { get; set; }

        public double? TOTALALLOCATEDHOURS { get; set; }

        public int CREATEDBY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CREATEDDATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LASTUPDATEDDATE { get; set; }

        public bool? ACTIVE { get; set; }

        public double? COSTCENTER { get; set; }

        public int? PARENTPROJECTID { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJECTEMPLOYEE> PROJECTEMPLOYEEs { get; set; }
    }
}
