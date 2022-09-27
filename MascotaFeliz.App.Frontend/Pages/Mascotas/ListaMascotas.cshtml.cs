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
    public class ListaMascotasModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioVeterinario _repoVeterinario;        
        
        public IEnumerable<Mascota> ListaMascotas {get;set;}
        public IEnumerable<Dueno> ListaDuenos {get;set;}
        public IEnumerable<Veterinario> ListaVeterinarios {get;set;}        
        
        public ListaMascotasModel(){
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());            
        }

        public void OnGet()
        {
            ListaMascotas = _repoMascota.GetAllMascotas();
            ListaDuenos = _repoDueno.GetAllDuenos();
            ListaVeterinarios = _repoVeterinario.GetAllVeterinarios();            
        }
    }
}
