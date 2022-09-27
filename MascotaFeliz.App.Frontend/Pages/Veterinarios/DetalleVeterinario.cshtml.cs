using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class DetalleVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario _repoVeterinario; 
        private readonly IRepositorioMascota _repoMascota;

        public Veterinario VeterinarioEncontrado{get; set;}
        public IEnumerable<Mascota> ListaMascota {get;set;}
        
        public DetalleVeterinarioModel()
        {
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this._repoMascota= new RepositorioMascota(new Persistencia.AppContext()); 
            this.VeterinarioEncontrado=null;
            this.ListaMascota=null;
        }

        public void OnGet(int? idVeterinario)
        {
            Console.WriteLine("Inicio - onGet - Detalle Mascota");
            if (idVeterinario.HasValue)
            {
                VeterinarioEncontrado = _repoVeterinario.GetVeterinario(idVeterinario.Value);  
                ListaMascota = _repoMascota.GetAllMascotasVeterinario(idVeterinario.Value);          
            }
        }
    }
}
