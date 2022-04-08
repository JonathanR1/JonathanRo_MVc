using ADS_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADS_Project.Repository
{
    public interface IEstudianteRepository
    {
        List<EstudianteViewModel> obtenerEstudiantes();

        int agregarEstudiante(EstudianteViewModel estudianteViewModel);

        int actualizarEstudiante(int idEstudiante, EstudianteViewModel estudianteViewModel);

        bool eliminarEstudiante(int idEstudiante);

        EstudianteViewModel obtenerEstudiantePorID(int idEstudiante);
    }
}
