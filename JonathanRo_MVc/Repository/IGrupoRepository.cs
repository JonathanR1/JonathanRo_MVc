﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADS_Project.Repository;
using JonathanRo_MVc.Models;

namespace JonathanRo_MVc.Repository
{
    public class IGrupoRepository
    {
        private readonly List<GruposViewModel> lstGrupos;

        public IGrupoRepository()
        {
            lstGrupos = new List<GruposViewModel>
            {
                new GruposViewModel{ idGrupo= 1, idCarrera = 1, idMateria = 1,idProfesor = 1, ciclo = 01, anio = 2019 }
            };
        }

        public int agregarGrupo(GruposViewModel gruposViewModel)
        {
            try
            {
                if (lstGrupos.Count > 0)
                {
                    gruposViewModel.idGrupo = lstGrupos.Last().idGrupo + 1;
                }
                else
                {
                    gruposViewModel.idGrupo = 1;
                }
                lstGrupos.Add(gruposViewModel);
                return gruposViewModel.idGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int actualizarGrupo(int idGrupo, GruposViewModel gruposViewModel)
        {
            try
            {
                lstGrupos[lstGrupos.FindIndex(x => x.idGrupo == idGrupo)] = gruposViewModel;
                return gruposViewModel.idGrupo;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool eliminarGrupo(int idGrupo)
        {
            try
            {
                lstGrupos.RemoveAt(lstGrupos.FindIndex(x => x.idGrupo == idGrupo));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public GruposViewModel obtenerGruposPorID(int idGrupo)
        {
            try
            {
                var item = lstGrupos.Find(x => x.idGrupo == idGrupo);
                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<GruposViewModel> obtenerGrupos()
        {
            try
            {
                return lstGrupos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
