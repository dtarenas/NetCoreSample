namespace NetCoreSample.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Status Enum
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// The active
        /// </summary>
        [Display(Name = "Activo")]
        Active = 1,

        /// <summary>
        /// The disactive
        /// </summary>
        [Display(Name = "Desactivo")]
        Disactive = 2
    }
}
