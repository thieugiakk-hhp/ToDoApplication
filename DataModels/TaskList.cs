namespace ToDoAplication.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskList")]
    public partial class TaskList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaskList()
        {
            Tasks = new HashSet<Task>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TaskListID { get; set; }

        [Required]
        [StringLength(14)]
        public string UserID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
