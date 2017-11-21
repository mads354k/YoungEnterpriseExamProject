namespace WpfYoungEnterpriseGUI.Facade.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public int AccountId { get; set; }

        [StringLength(30)]
        public string UserName { get; set; }

        [StringLength(30)]
        public string UserPassword { get; set; }

        public int? PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
