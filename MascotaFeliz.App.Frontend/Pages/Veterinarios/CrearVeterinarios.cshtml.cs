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
    public class CrearVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario _repoVeterinario;

        public CrearVeterinariosModel(){
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        }

        public void OnPost(){
            if (ModelState.IsValid){
                Console.WriteLine("OnPost Crear Veterinario");
                
                var vNombres = Request.Form["Nombres"];
                var vApellidos = Request.Form["Apellidos"];
                var vDireccion = Request.Form["Direccion"];
                var vTelefono = Request.Form["Telefono"];
                var vTarjetaProfesional = Request.Form["TarjetaProfesional"];
                
                var veterinario = new Veterinario {
                    Nombres = vNombres,
                    Apellidos = vApellidos,
                    Direccion = vDireccion,
                    Telefono = vTelefono,
                    TarjetaProfesional = vTarjetaProfesional
                };
                _repoVeterinario.AddVeterinario(veterinario);
            }
        }
    }
}
