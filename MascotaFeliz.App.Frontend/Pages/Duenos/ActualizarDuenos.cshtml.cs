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
    public class ActualizarDuenosModel : PageModel
    {
        private readonly IRepositorioDueno _repoDueno;
        public Dueno DuenoActualizacion=null;   

        public ActualizarDuenosModel(){
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this.DuenoActualizacion=null;
        }            

        public void OnGet(int? Id)
        {
            Console.WriteLine("Inicio - onGet - Actualizar Dueño");
            if (Id.HasValue)
                {
                    DuenoActualizacion=_repoDueno.GetDueno(Id.Value);
                    Console.WriteLine("El nombre de la Dueno es "+DuenoActualizacion.Nombres);

                }
                else{
                    Console.WriteLine("Duenoo no encontrado");
                }
            Console.WriteLine("Fin - onGet - Actualizar Dueno");   
        }

        public IActionResult OnPost(int? Id)
        {
            Console.WriteLine("Inicio - onPost - Actualizar Dueno");
            if (ModelState.IsValid)
            {
                Console.WriteLine("Modelo onPost - Actualizar Dueno valido");
                if (Id.HasValue){
                    var dId=Int32.Parse(Request.Form["Id"]);                    
                    var dNombres = Request.Form["Nombres"];
                    var dApellidos = Request.Form["Apellidos"];
                    var dDireccion = Request.Form["Direccion"];
                    var dTelefono = Request.Form["Telefono"];
                    var dCorreo = Request.Form["Correo"];
                    var dueno = new Dueno {
                        Id=dId,
                        Nombres = dNombres,
                        Apellidos = dApellidos,
                        Direccion = dDireccion,
                        Telefono = dTelefono,
                        Correo = dCorreo
                    };
                    _repoDueno.UpdateDueno(dueno);
                }
            }
            return RedirectToPage("/Duenos/BuscarDuenos");
        }
    }
}
