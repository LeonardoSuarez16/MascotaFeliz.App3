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
    public class CrearDuenosModel : PageModel
    {
        private static IRepositorioDueno
            _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
       
        public void OnGet()
        {
        }

        public void OnPost()
        {

           
            var nombredueno = Request.Form["nombredueno"];
            var apellidodueno = Request.Form["apellidodueno"];
            var direcciondueno = Request.Form["direcciondueno"];
            var telefonodueno = Request.Form["telefonodueno"];
            var correodueno = Request.Form["correodueno"];

            var dueno =
                new Dueno {
                    Nombres = nombredueno,
                    Apellidos = apellidodueno,
                    Direccion = direcciondueno,
                    Telefono = telefonodueno,
                    Correo = correodueno
                };
            _repoDueno.AddDueno (dueno);
            
        }
       
    }
}

