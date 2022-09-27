using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        /// <summary>
        /// Referencia al contexto de Mascota
        /// </summary>
        private readonly AppContext _appContext;

        /// <summary>
        /// Metodo Constructor Utiiza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Mascota AddMascota(Mascota mascota)
        {
            var mascotaAdicionado = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionado.Entity;
        }

        public Mascota GetMascota(int idMascota)
        {
            return _appContext.Mascotas.FirstOrDefault(d => d.Id == idMascota);
        }

        public Mascota UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrado =
                _appContext.Mascotas.FirstOrDefault(d => d.Id == mascota.Id);
            if (mascotaEncontrado != null)
            {
                mascotaEncontrado.Nombres = mascota.Nombres;
                mascotaEncontrado.Color = mascota.Color;
                mascotaEncontrado.Especie = mascota.Especie;
                mascotaEncontrado.Raza = mascota.Raza;
                mascotaEncontrado.Foto = mascota.Foto;

                _appContext.SaveChanges();
            }
            return mascotaEncontrado;
        }

        public void DeleteMascota(int idMascota)
        {
            var mascotaEncontrado =
                _appContext.Mascotas.FirstOrDefault(d => d.Id == idMascota);
            if (mascotaEncontrado == null) return;
            _appContext.Mascotas.Remove (mascotaEncontrado);
            _appContext.SaveChanges();
        }

        public Dueno AsignarDueno(int idMascota, int idDueno) 
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            
            if(mascotaEncontrado != null)
            {
                var duenoEncontrado = _appContext.Duenos.FirstOrDefault(d => d.Id == idDueno);
                if(duenoEncontrado != null)
                {
                    mascotaEncontrado.Dueno = duenoEncontrado;
                    _appContext.SaveChanges();
                }
                return duenoEncontrado;
            }
            return null;
        }

        public Dueno GetMascotaDueno(int idMascota) 
        {
            return _appContext.Mascotas
                    .Include(m => m.Dueno)
                    .AsNoTracking()
                    .FirstOrDefault(m => m.Id == idMascota)
                    .Dueno;
        } 

        public Veterinario GetMascotaVeterinario(int idMascota) 
        {
            return _appContext.Mascotas
                    .Include(m => m.Veterinario)
                    .AsNoTracking()
                    .FirstOrDefault(m => m.Id == idMascota)
                    .Veterinario;
        }                
        
        public Historia GetMascotaHistoria(int idMascota)
        {
            return _appContext.Mascotas
                    .Include(m => m.Historia)
                    .AsNoTracking()
                    .FirstOrDefault(m => m.Id == idMascota)
                    .Historia;
        }        
        
        public Veterinario AsignarVeterinario(int idMascota, int idVeterinario)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            if(mascotaEncontrado != null)
            {
                var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
                if(veterinarioEncontrado != null)
                {
                    mascotaEncontrado.Veterinario = veterinarioEncontrado;
                    _appContext.SaveChanges();
                }
                return veterinarioEncontrado;
            }
            return null;
        }

        public Historia AsignarHistoria(int idMascota, int idHistoria)
        {
            var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
            if(mascotaEncontrada != null)
            {
                var historiaEncontrada = _appContext.Historias.FirstOrDefault(h => h.Id == idHistoria);
                if(historiaEncontrada != null)
                {
                    mascotaEncontrada.Historia = historiaEncontrada;
                    _appContext.SaveChanges();
                }
                return historiaEncontrada;
            }
            return null;
        }        

        public IEnumerable<Mascota> GetAllMascotas()
        {
            return _appContext.Mascotas.Include("Dueno").Include("Veterinario");
        }

        public IEnumerable<Mascota> GetAllMascotasDueno(int IdDueno)
        {
            return _appContext.Mascotas.Include("Dueno").Include("Veterinario").Where(m => m.Dueno.Id == IdDueno);
        }        

        public IEnumerable<Mascota> GetAllMascotasVeterinario(int IdVeterinario)
        {
            return _appContext.Mascotas.Include("Dueno").Include("Veterinario").Where(m => m.Veterinario.Id == IdVeterinario);
        }        

     
    }
}
