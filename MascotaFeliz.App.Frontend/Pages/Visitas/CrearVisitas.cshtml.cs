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
    public class CrearVisitasModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        //private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioVeterinario _repoVeterinario;
        private readonly IRepositorioHistoria _repoHistoria;
        private readonly IRepositorioVisitaPyP _repoVisita;

        //public IEnumerable<Dueno> ListaDuenos {get;set;}
        [BindProperty]
        public IEnumerable<Veterinario> ListaVeterinarios {get;set;}

        public Mascota  MascotaEncontrada {get;set;}
        public Historia HistoriaVisita {get;set;}

        public CrearVisitasModel(){
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            //this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
            this._repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext());

            this.MascotaEncontrada=null;
            this.HistoriaVisita=null;
        }

        public void OnGet(int? Id, int? IdVeterinario, int? IdHistoria)
        {
            Console.WriteLine("OnGet de Crear Visita");
            //ListaDuenos = _repoDueno.GetAllDuenos();
            if (Id.HasValue){
                Console.WriteLine("Id Mascota "+Id.Value);
                MascotaEncontrada = _repoMascota.GetMascota(Id.Value);
                HistoriaVisita = _repoMascota.GetMascotaHistoria(Id.Value);
                Console.WriteLine("Mascota "+MascotaEncontrada.Nombres);
                Console.WriteLine("Historia "+HistoriaVisita.Id);   
            }
            ListaVeterinarios = _repoVeterinario.GetAllVeterinarios();            
        }
        public void OnPost()
        {
            MascotaEncontrada = _repoMascota.GetMascota(Int32.Parse(Request.Form["IdMascota"]));
            HistoriaVisita = _repoMascota.GetMascotaHistoria(Int32.Parse(Request.Form["IdHistoria"]));            
            if (ModelState.IsValid){
                Console.WriteLine("OnPost Crear Visita");
                var fechaVisita = Request.Form["fechaVisita"];
                var selectVeterinario = Request.Form["selectVeterinario"];
                var temperatura = Request.Form["temperatura"];
                var peso = Request.Form["peso"];
                var frespiratoria = Request.Form["frespiratoria"];
                var fcardiaca = Request.Form["fcardiaca"];
                var animo = Request.Form["animo"];
                var recomendaciones = Request.Form["recomendaciones"];

                Console.WriteLine(fechaVisita);

                var visita=
                    new VisitaPyP {
                        FechaVisita = Convert.ToDateTime(fechaVisita),//convertir a fecha
                        Temperatura = Int32.Parse(temperatura),
                        Peso = Int32.Parse(peso),
                        FrecuenciaRespiratoria = Int32.Parse(frespiratoria),
                        FrecuenciaCardiaca = Int32.Parse(fcardiaca),
                        EstadoAnimo = animo,
                        IdVeterinario = Int32.Parse(selectVeterinario),
                        Recomendaciones = recomendaciones
                    };
                
                var visitaGuardada=_repoVisita.AddVisitaPyP(visita);
                //MascotaEncontrada = _repoMascota.GetMascota(Id.Value);
                HistoriaVisita = _repoMascota.GetMascotaHistoria(Int32.Parse(Request.Form["IdMascota"]));                
                //Console.WriteLine("El Nombre de la mascota es "+ MascotaEncontrada.Nombres);
                //Console.WriteLine("El Id de la historia es "+ MascotaEncontrada.Historia.Id);
                var hs=_repoVisita.AsignarHistoria(visitaGuardada.Id,HistoriaVisita.Id);

            }
            //ListaDuenos = _repoDueno.GetAllDuenos();
            //ListaVeterinarios = _repoVeterinario.GetAllVeterinarios();
            //return RedirectToPage("/Mascotas/DetalleMascota?CajitaIdMascota="+MascotaEncontrada.Id);
        }        
    }
}
