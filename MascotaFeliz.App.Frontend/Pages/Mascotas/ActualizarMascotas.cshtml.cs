using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class ActualizarMascotasModel : PageModel
    {

        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioVeterinario _repoVeterinario;
        [BindProperty]

        public Mascota MascotaActualizacion { get; set; } 
        public Dueno DuenoMascota { get; set; } 
        public Veterinario VeterinarioMascota { get; set; } 

        public IEnumerable<Dueno> ListaDuenos {get;set;}
        public IEnumerable<Veterinario> ListaVeterinarios {get;set;}   
        
        public ActualizarMascotasModel(){
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext()); 
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        }

        public void OnGet(int? CajitaIdMascota)
        {

            ListaDuenos = _repoDueno.GetAllDuenos();
            ListaVeterinarios = _repoVeterinario.GetAllVeterinarios();
            Console.WriteLine("Inicio - onGet - Actualizar Mascota");
            if (CajitaIdMascota.HasValue)
                {
                    MascotaActualizacion=_repoMascota.GetMascota(CajitaIdMascota.Value);
                    DuenoMascota = _repoMascota.GetMascotaDueno(CajitaIdMascota.Value);
                    VeterinarioMascota =_repoMascota.GetMascotaVeterinario(CajitaIdMascota.Value);
                    Console.WriteLine("El nombre de la Mascota es "+MascotaActualizacion.Nombres);

                }
                else{
                    Console.WriteLine("Mascota no encontrada");
                }
            Console.WriteLine("Fin - onGet - Actualizar Mascota");                
        }            
        public IActionResult OnPost(int? CajitaIdMascota)
        {
            Console.WriteLine("Inicio - onPost - Actualizar Mascota");
            if (ModelState.IsValid)
            {
                Console.WriteLine("Modelo onPost - Actualizar Mascota valido");
                if (CajitaIdMascota.HasValue){
                    var idMascota=Int32.Parse(Request.Form["Id"]);
                    var nombremascota = Request.Form["nombremascota"];
                    var colormascota = Request.Form["colormascota"];
                    var especiemascota = Request.Form["especiemascota"];
                    var razamascota = Request.Form["razamascota"];
                    var idDuenoMascota = Request.Form["selectDueno"];
                    var idVeterinarioMascota = Request.Form["selectVeterinario"];

                    Console.WriteLine("Nombre Mascota: "+nombremascota);
                    var mascota =
                        new Mascota {
                            Id = idMascota,
                            Nombres = nombremascota,
                            Color = colormascota,
                            Raza = razamascota,
                            Especie = especiemascota
                        };
                    MascotaActualizacion=_repoMascota.UpdateMascota(mascota);

                    _repoMascota.AsignarDueno(MascotaActualizacion.Id,Int32.Parse(idDuenoMascota));
                    _repoMascota.AsignarVeterinario(MascotaActualizacion.Id,Int32.Parse(idVeterinarioMascota));
                    
                    Console.WriteLine("Mascota Actualizada");
                }             
            }
            else{
              Console.WriteLine("Modelo onPost - Actualizar Mascota invalido");
            }
            //return Page();
            
            Console.WriteLine("Redirigiento a Buscar Mascota");

            ListaDuenos = _repoDueno.GetAllDuenos();
            ListaVeterinarios = _repoVeterinario.GetAllVeterinarios();

            return RedirectToPage("/Mascotas/BuscarMascotas");
        }

    }
}

       

