using ADS_Project.Utils;
using System.ComponentModel.DataAnnotations;
namespace ADS_Project.Models
{
    public class MateriaViewModel
    {
        [Display(Name = "ID")]
        public int idMateria { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor a 3 caracteres.")]
        [Display(Name = "Materia")]
        public string nombreMateria{ get; set; }
    }
}
