using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreSample.Models.Entities
{
    /// <summary>
    /// Users Entity
    /// </summary>
    [Table("Users")]
    public class Users
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        [Display(Name = "Nombre Completo")]
        [StringLength(150)]
        [Required(ErrorMessage = "{0} es obligatorio")]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Display(Name = "Correo")]
        [EmailAddress(ErrorMessage = "{0} no es una email válido")]
        [Required(ErrorMessage = "{0} es obligatorio")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required(ErrorMessage = "{0} es obligatorio")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
