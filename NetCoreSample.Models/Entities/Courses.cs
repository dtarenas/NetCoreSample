
namespace NetCoreSample.Models.Entities
{
    using NetCoreSample.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Courses
    /// </summary>
    [Table("Courses")]
    public class Courses
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Courses"/> class.
        /// </summary>
        public Courses()
        {
            this.FkRemarks = new HashSet<Remarks>();
        }

        /// <summary>
        /// Gets or sets the course identifier.
        /// </summary>
        /// <value>
        /// The course identifier.
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        /// <summary>
        /// Gets or sets the short description.
        /// </summary>
        /// <value>
        /// The short description.
        /// </value>
        [Display(Name = "Descrición Corta")]
        [Required(ErrorMessage = "{0} es oblogatiorio")]
        [StringLength(150)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or sets the long description.
        /// </summary>
        /// <value>
        /// The long description.
        /// </value>
        [Display(Name = "Descrición General")]
        [Required(ErrorMessage = "{0} es oblogatiorio")]
        [StringLength(4000)]
        public string LongDescription { get; set; }

        /// <summary>
        /// Gets or sets the URL cover picture.
        /// </summary>
        /// <value>
        /// The URL cover picture.
        /// </value>
        [Display(Name = "Descrición General")]
        [StringLength(500)]
        public string UrlCoverPicture { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
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
        /// Gets or sets the fk remarks.
        /// </summary>
        /// <value>
        /// The fk remarks.
        /// </value>
        public virtual ICollection<Remarks> FkRemarks { get; set; }
    }
}
