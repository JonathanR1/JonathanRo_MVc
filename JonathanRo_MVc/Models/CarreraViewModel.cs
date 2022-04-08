using ADS_Project.Utils;
using System.ComponentModel.DataAnnotations;

namespace ADS_Project.Models
{
    public class CarreraViewModel
    {

        [Display(Name = "ID")]
        public int idCarrera { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor a 3 caracteres.")]
        [Display(Name = "Código")]
        public string codigoCarrera { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor a 3 caracteres.")]
        [Display(Name = "Carrera")]
        public string nombreCarrera { get; set; }

    }
}
