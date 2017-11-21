namespace WpfYoungEnterpriseGUI.Facade.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuestionInformation")]
    public partial class QuestionInformation
    {
        [Key]
        public int InfoId { get; set; }

        public int? QuestionnarieId { get; set; }

        public int? QuestionId { get; set; }

        public virtual Question Question { get; set; }

        public virtual Questionnarie Questionnarie { get; set; }
    }
}
