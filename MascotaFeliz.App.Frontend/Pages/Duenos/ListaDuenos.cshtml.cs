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
    public class ListaDuenosModel : PageModel
    {
        private readonly IRepositorioDueno _repoDueno;

        public IEnumerable<Dueno> ListaDuenos {get;set;}

        public ListaDuenosModel(){
             this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
             this.ListaDuenos=null;
        }

        public void OnGet()
        {
            ListaDuenos = _repoDueno.GetAllDuenos();
        }
    }
}
