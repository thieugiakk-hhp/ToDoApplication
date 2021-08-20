namespace ToDoAplication.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Task")]
    public partial class Task
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TaskID { get; set; }

        [Required]
        [StringLength(14)]
        public string UserID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime StartDay { get; set; }

        public DateTime EndDay { get; set; }

        [Required]
        [StringLength(10)]
        public string CategoryID { get; set; }

        public long? TaskListID { get; set; }

        [StringLength(4000)]
        public string TaskDescription { get; set; }

        public bool Important { get; set; }

        public bool Complete { get; set; }

        public virtual Account Account { get; set; }

        public virtual Category Category { get; set; }

        public virtual TaskList TaskList { get; set; }
    }
}
