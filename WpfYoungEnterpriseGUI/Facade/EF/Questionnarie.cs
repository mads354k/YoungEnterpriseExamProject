namespace WpfYoungEnterpriseGUI.Facade.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Questionnarie")]
    public partial class Questionnarie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Questionnarie()
        {
            QuestionInformation = new HashSet<QuestionInformation>();
        }

        public int QuestionnarieId { get; set; }

        public double? Valuation { get; set; }

        [StringLength(30)]
        public string TeamName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionInformation> QuestionInformation { get; set; }

        public virtual Team Team { get; set; }
    }
}
