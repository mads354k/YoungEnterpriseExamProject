namespace WpfYoungEnterpriseGUI.Facade.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Team")]
    public partial class Team
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Team()
        {
            Person = new HashSet<Person>();
            Questionnarie = new HashSet<Questionnarie>();
        }

        [Key]
        [StringLength(30)]
        public string TeamName { get; set; }

        [StringLength(30)]
        public string Track { get; set; }

        [StringLength(30)]
        public string School { get; set; }

        public bool? Participant { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> Person { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Questionnarie> Questionnarie { get; set; }
    }
}
