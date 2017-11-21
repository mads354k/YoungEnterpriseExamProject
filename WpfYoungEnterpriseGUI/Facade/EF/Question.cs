namespace WpfYoungEnterpriseGUI.Facade.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            QuestionInformation = new HashSet<QuestionInformation>();
        }

        public int QuestionId { get; set; }

        [StringLength(50)]
        public string TextDescription { get; set; }

        [StringLength(30)]
        public string Track { get; set; }

        public double? WeightValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionInformation> QuestionInformation { get; set; }
    }
}
