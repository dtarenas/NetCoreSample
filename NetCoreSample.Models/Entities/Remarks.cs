namespace NetCoreSample.Models.Entities
{
    using NetCoreSample.Models.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Remarks Entity
    /// </summary>
    [Table("Remarks")]
    public class Remarks
    {
        /// <summary>
        /// Gets or sets the remarks identifier.
        /// </summary>
        /// <value>
        /// The remarks identifier.
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RemarksId { get; set; }

        /// <summary>
        /// Gets or sets the fk course identifier.
        /// </summary>
        /// <value>
        /// The fk course identifier.
        /// </value>
        [Required(ErrorMessage = "{0} es oblogatorio")]
        [Display(Name = "Curso")]
        public int FkCourseId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [Display(Name = "Descripción")]
        [StringLength(4000)]
        [Required(ErrorMessage = "{0} es oblogatorio")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        /// <value>
        /// My property.
        /// </value>
        [Range(0, int.MaxValue), Display(Name = "Calificación")]
        [Required(ErrorMessage = "{0} es oblogatorio")]
        public int Qualification { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [Display(Name = "Estado")]
        [Required(ErrorMessage = "{0} es oblogatorio")]
        public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the created on.
        /// </summary>
        /// <value>
        /// The created on.
        /// </value>
        [Required(ErrorMessage = "{0} es oblogatiorio")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the fk courses.
        /// </summary>
        /// <value>
        /// The fk courses.
        /// </value>
        public virtual Courses FkCourses { get; set; }
    }
}
