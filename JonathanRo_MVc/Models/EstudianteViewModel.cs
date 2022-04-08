using ADS_Project.Utils;
using System.ComponentModel.DataAnnotations;
namespace ADS_Project.Models
{
    public class EstudianteViewModel
    {
        [Display(Name ="ID")]
        public int idEstudiante { get; set; }

        [Required(ErrorMessage =Constants.REQUIRED_FIELD)]
        [StringLength(50,MinimumLength = 3,ErrorMessage ="La longitud del campo no debe ser mayor a 50 caracteres ni menor a 3 caracteres.")]
        [Display(Name = "Nombre")]
        public string nombresEstudiante { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor a 3 caracteres.")]
        [Display(Name = "Apellido")]
        public string apellidosEstudiante { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "La longitud del campo de ser de 12 caracteres.")]
        [Display(Name = "Código")]
        public string codigoEstudiante { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor a 5 caracteres.")]
        [Display(Name = "Correo")]
        public string correoEstudiante { get; set; }

    }
}
