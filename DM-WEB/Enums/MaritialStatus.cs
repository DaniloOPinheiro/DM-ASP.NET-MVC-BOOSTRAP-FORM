using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DM_WEB.Enums
{
    public enum MaritialStatus
    {
        // [Display(Name = "Solteiro(a)")]
        NotMarried,
        [Display(Name = "Casado(a)")]
        Married,
        [Display(Name = "Divorciado(a)")]
        Divorced,
        [Display(Name = "Viuvo(a)")]
        Widower,
        [Display(Name = "Separado(a)")]
        Separate
    }
}