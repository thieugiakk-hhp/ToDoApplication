namespace ToDoAplication.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserStatu
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [StringLength(14)]
        public string UserID { get; set; }

        [Required]
        [StringLength(200)]
        public string Status { get; set; }

        public double Water { get; set; }

        public double BMI { get; set; }

        public virtual Account Account { get; set; }
    }
}
