using ADS_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADS_Project.Repository
{
    public interface IProfesorRepository
    {
        List<ProfesorViewModel> obtenerProfesores();

        int agregarProfesor(ProfesorViewModel profesorViewModel);

        int actualizarProfesor(int idProfesor, ProfesorViewModel profesorViewModel);

        bool eliminarProfesor(int idProfesor);

        ProfesorViewModel obtenerProfesorPorID(int idProfesor);
    }
}
