using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreSample.Models.DTOs
{
    public class UsersRegisterDTO
    {
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

        /// <summary>
        /// Gets or sets the password check.
        /// </summary>
        /// <value>
        /// The password check.
        /// </value>
        [Required(ErrorMessage = "{0} es obligatorio")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string PasswordCheck { get; set; }
    }
}
