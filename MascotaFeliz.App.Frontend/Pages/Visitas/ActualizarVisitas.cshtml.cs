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
    public class ActualizarVisitasModel : PageModel
    {
        //private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioVeterinario _repoVeterinario;
        private readonly IRepositorioHistoria _repoHistoria;
        private readonly IRepositorioVisitaPyP _repoVisita;
        public IEnumerable<Veterinario> ListaVeterinarios {get;set;}

        [BindProperty]
        public VisitaPyP Visita {get;set;}
        //public Mascota  MascotaEncontrada {get;set;}
        public Historia HistoriaVisita {get;set;}
        public string FechaProcesada {get;set;}

        public ActualizarVisitasModel(){
            //this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            //this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
            this._repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext());

            //this.MascotaEncontrada=null;
            //this.HistoriaVisita=null;
            //this.Visita=null;
            //this.FechaProcesada=null;
        }

        public void OnGet(int? IdVisita)
        {
            Console.WriteLine("OnGet de Actualizar Visita");
            if (IdVisita.HasValue){
                Visita=_repoVisita.GetVisitaPyP(IdVisita.Value);
                FechaProcesada=Visita.FechaVisita.ToString("yyyy-MM-dd HH:mm");
                Console.WriteLine("fecha procesada "+FechaProcesada);
            }
            ListaVeterinarios = _repoVeterinario.GetAllVeterinarios();            
        }
        public void OnPost()
        {
            //MascotaEncontrada = _repoMascota.GetMascota(Int32.Parse(Request.Form["IdMascota"]));
            HistoriaVisita = _repoVisita.GetHistoriaVisitaPyP(Int32.Parse(Request.Form["IdVisita"]));
            var v=_repoVisita.GetVisitaPyP(Int32.Parse(Request.Form["IdVisita"]));
            Console.WriteLine("Historia visita id "+v.Historia.Id);
            if (ModelState.IsValid){
                Console.WriteLine("OnPost Actualizar Visita");
                var vId = Request.Form["IdVisita"];
                var fechaVisita = Request.Form["fechaVisita"];
                var selectVeterinario = Request.Form["selectVeterinario"];
                var temperatura = Request.Form["temperatura"];
                var peso = Request.Form["peso"];
                var frespiratoria = Request.Form["frespiratoria"];
                var fcardiaca = Request.Form["fcardiaca"];
                var animo = Request.Form["animo"];
                var recomendaciones = Request.Form["recomendaciones"];
                
                var visita=
                    new VisitaPyP {
                        Id =Int32.Parse(vId),
                        FechaVisita = Convert.ToDateTime(fechaVisita),//convertir a fecha
                        Temperatura = Int32.Parse(temperatura),
                        Peso = Int32.Parse(peso),
                        FrecuenciaRespiratoria = Int32.Parse(frespiratoria),
                        FrecuenciaCardiaca = Int32.Parse(fcardiaca),
                        EstadoAnimo = animo,
                        IdVeterinario = Int32.Parse(selectVeterinario),
                        Recomendaciones = recomendaciones
                    };
                
                var visitaGuardada=_repoVisita.UpdateVisitaPyP(visita);
                Console.WriteLine("ID de la visita "+visitaGuardada.Id);
                //MascotaEncontrada = _repoMascota.GetMascota(Id.Value);
                //HistoriaVisita = _repoMascota.GetMascotaHistoria(Int32.Parse(Request.Form["IdMascota"]));                
                //Console.WriteLine("El Nombre de la mascota es "+ MascotaEncontrada.Nombres);
                //Console.WriteLine("El Id de la historia es "+ MascotaEncontrada.Historia.Id);
                _repoVisita.AsignarHistoria(visitaGuardada.Id,v.Historia.Id);

            }
            //ListaDuenos = _repoDueno.GetAllDuenos();
            ListaVeterinarios = _repoVeterinario.GetAllVeterinarios();
        }        
    }
}



