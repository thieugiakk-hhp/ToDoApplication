namespace ToDoAplication.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUserInformation")]
    public partial class tblUserInformation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(14)]
        public string UserID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public byte? Age { get; set; }

        public bool? Sex { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Profession { get; set; }

        public virtual tblAccount tblAccount { get; set; }
    }
}
