using ADS_Project.Models;
using ADS_Project.Repository;
using ADS_Project.Utils;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ADS_Project.Controllers
{
    public class ProfesorController : Controller
    {
        private readonly IProfesorRepository profesorRepository;

        public ProfesorController(IProfesorRepository profesorRepository)
        {
            this.profesorRepository = profesorRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                var item = profesorRepository.obtenerProfesores();
                return View(item);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public IActionResult Form(int? idProfesor, Operaciones operaciones)
        {
            try
            {
                var profesor = new ProfesorViewModel();

                if (idProfesor.HasValue)
                {
                    profesor = profesorRepository.obtenerProfesorPorID(idProfesor.Value);
                }

                //Indica el tipo de operacion que se esta realizando
                ViewData["Operaciones"] = operaciones;
                return View(profesor);

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Form(ProfesorViewModel profesorViewModel)
        {
            try
            {
                if (profesorViewModel.idProfesor == 0) //En caso de insertar
                {

                    profesorRepository.agregarProfesor(profesorViewModel);
                }
                else //En caso de actualizar
                {
                    profesorRepository.actualizarProfesor(profesorViewModel.idProfesor, profesorViewModel);

                }

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpGet]
        public IActionResult Delete(int idProfesor)
        {
            try
            {
                profesorRepository.eliminarProfesor(idProfesor);
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index");
        }
    }
}
