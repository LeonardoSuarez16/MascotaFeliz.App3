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
    public class BuscarMascotasModel : PageModel
    {
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        public void OnGet()
        {
            
        }

        public void OnPost()
        {/*
            if (!ModelState.IsValid)
            {
                //return Page();
                Console.WriteLine("TA      haciendoO");
            }
            else
            {
                var codigoIdMascota = Request.Form["CajitaIdMascota"];
                var buscaMascota = _repoMascota.GetMascota(Int32.Parse(codigoIdMascota));
                Console.WriteLine("Que esta haciendo aquí?    Emilton");    
            }
            
            */
        }
    }
}
