using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using Microsoft.EntityFrameworkCore;


namespace MascotaFeliz.App.Frontend.Pages
{
    public class DetalleMascotaModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioDueno _repoDueno;  
        public  readonly IRepositorioVeterinario _repoVeterinario; 
        private readonly IRepositorioHistoria _repoHistoria;  
        private readonly IRepositorioVisitaPyP _repoVisita;  

        [BindProperty] 
        public Mascota MascotaEncontrada{get; set;}
        public Dueno DuenoEncontrado{get; set;}  
        public Veterinario VeterinarioEncontrado{get; set;}
        public Historia HistoriaEncontrada{get; set;}
        public IEnumerable<VisitaPyP> ListaVisitas{get;set;} 
        //esta lista se combinara con la de visitas para poder acceder al nombre y apellido de cada veterinario
        public IList<string> ListaVeterinarios{get;set;} 
        
        public DetalleMascotaModel(){
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext()); 
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext()); 
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext()); 
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext()); 
            this._repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext()); 
            
            this.MascotaEncontrada=null;
            this.DuenoEncontrado=null;
            this.VeterinarioEncontrado=null;
            this.HistoriaEncontrada=null;
            this.ListaVisitas=null;
            this.ListaVeterinarios=null;
        }

        public void OnGet(int? CajitaIdMascota)
        {
            Console.WriteLine("Inicio - onGet - Detalle Mascota");
            if (CajitaIdMascota.HasValue)
                {
                    MascotaEncontrada = _repoMascota.GetMascota(CajitaIdMascota.Value);
                    DuenoEncontrado = _repoMascota.GetMascotaDueno(CajitaIdMascota.Value);
                    VeterinarioEncontrado = _repoMascota.GetMascotaVeterinario(CajitaIdMascota.Value);
                    HistoriaEncontrada = _repoMascota.GetMascotaHistoria(CajitaIdMascota.Value);
                    ListaVisitas = _repoVisita.GetVisitaPorHistoria(HistoriaEncontrada.Id);
                    //llenamos la lista de veterinarios segun quien realizo la visita                    
                    /*foreach (var item in ListaVisitas)
                    {
                        var vet=_repoVeterinario.GetVeterinario(item.IdVeterinario);
                        ListaVeterinarios.Add(vet.Nombres+" "+vet.Apellidos);
                    }*/
                }
                else{
                    Console.WriteLine("Mascota no encontrada");
                }
            Console.WriteLine("Fin - onGet - Detalle Mascota");
        }
    }
}
