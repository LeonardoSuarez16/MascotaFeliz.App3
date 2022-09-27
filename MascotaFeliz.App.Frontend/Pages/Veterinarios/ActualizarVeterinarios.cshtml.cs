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
    public class ActualizarVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario _repoVeterinario;

        //[BindProperty]
        public Veterinario VeterinarioActualizacion=null;

        public ActualizarVeterinariosModel(){
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this.VeterinarioActualizacion=null;
        }                 
        
        public void OnGet(int? Id)
        {
            Console.WriteLine("Inicio - onGet - Actualizar Veterinario");
            if (Id.HasValue)
                {
                    VeterinarioActualizacion=_repoVeterinario.GetVeterinario(Id.Value);
                    Console.WriteLine("El nombre de la Veterinario es "+VeterinarioActualizacion.Nombres);

                }
                else{
                    Console.WriteLine("Veterinario no encontrada");
                }
            Console.WriteLine("Fin - onGet - Actualizar Veterinario");   
        }

        public IActionResult OnPost(int? Id)
        {
            Console.WriteLine("Inicio - onPost - Actualizar Veterinario");
            if (ModelState.IsValid)
            {
                Console.WriteLine("Modelo onPost - Actualizar Veterinario valido");
                if (Id.HasValue){
                    var vId=Int32.Parse(Request.Form["Id"]);                    
                    var vNombres = Request.Form["Nombres"];
                    var vApellidos = Request.Form["Apellidos"];
                    var vDireccion = Request.Form["Direccion"];
                    var vTelefono = Request.Form["Telefono"];
                    var vTarjetaProfesional = Request.Form["TarjetaProfesional"];
                    var veterinario = new Veterinario {
                        Id=vId,
                        Nombres = vNombres,
                        Apellidos = vApellidos,
                        Direccion = vDireccion,
                        Telefono = vTelefono,
                        TarjetaProfesional = vTarjetaProfesional
                    };
                    _repoVeterinario.UpdateVeterinario(veterinario);
                }
            }
            return RedirectToPage("/Veterinarios/BuscarVeterinarios");
        }
    }
}
