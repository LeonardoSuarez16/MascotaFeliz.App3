using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.IO;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class CrearMascotasModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioVeterinario _repoVeterinario;
        private readonly IRepositorioHistoria _repoHistoria;

        public IEnumerable<Dueno> ListaDuenos {get;set;}
        public IEnumerable<Veterinario> ListaVeterinarios {get;set;}

        public CrearMascotasModel(){
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        }

        public void OnGet(){
            Console.WriteLine("OnGet de Crear Mascota");
            ListaDuenos = _repoDueno.GetAllDuenos();
            ListaVeterinarios = _repoVeterinario.GetAllVeterinarios();
        }

        public void OnPost()
        {
            if (ModelState.IsValid){
                Console.WriteLine("OnPost Crear mascota");
                var nombremascota = Request.Form["nombremascota"];
                var colormascota = Request.Form["colormascota"];
                var especiemascota = Request.Form["especiemascota"];
                var razamascota = Request.Form["razamascota"];
                var fotomascota = Request.Form.Files["fotomascota"];
                var idDuenoMascota = Request.Form["selectDueno"];
                var idVeterinarioMascota = Request.Form["selectVeterinario"];

                var mascota =
                    new Mascota {
                        Nombres = nombremascota,
                        Color = colormascota,
                        Raza = razamascota,
                        Especie = especiemascota
                    
                    };
                var mascotaGuardada=_repoMascota.AddMascota (mascota);
                _repoMascota.AsignarDueno(mascotaGuardada.Id, Int32.Parse(idDuenoMascota) );
                _repoMascota.AsignarVeterinario(mascotaGuardada.Id, Int32.Parse(idVeterinarioMascota) );
                
                var historia = new Historia {FechaInicial = DateTime.Today};
                var historiaGuardada=_repoHistoria.AddHistoria(historia);
                _repoMascota.AsignarHistoria(mascotaGuardada.Id,historiaGuardada.Id);
            }
            
            ListaDuenos = _repoDueno.GetAllDuenos();
            ListaVeterinarios = _repoVeterinario.GetAllVeterinarios();
        }
    }
}
