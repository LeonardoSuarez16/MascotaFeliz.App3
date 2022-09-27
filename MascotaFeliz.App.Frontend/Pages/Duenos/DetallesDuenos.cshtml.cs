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
    public class DetallesDuenosModel : PageModel
    {
        private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioMascota _repoMascota;

        public Dueno dueno {get;set;}
        public IEnumerable<Mascota> ListaMascota {get;set;}
        public DetallesDuenosModel()
        {
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoMascota= new RepositorioMascota(new Persistencia.AppContext());
            this.dueno=null;
            this.ListaMascota=null;
        }
        
        public IActionResult OnGet(int idDueno)
        {
            dueno = _repoDueno.GetDueno(idDueno);
            ListaMascota = _repoMascota.GetAllMascotasDueno(idDueno);
            if (dueno == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
    }
}

