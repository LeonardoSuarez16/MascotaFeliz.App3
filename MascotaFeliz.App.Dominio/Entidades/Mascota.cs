using System;
namespace MascotaFeliz.App.Dominio
{
    public class Mascota
    {
        public int Id {get;set;}
        public string Nombres {get;set;}
        public string Color {get;set;}
        public string Especie {get;set;}
        public string Raza {get;set;}
        public string Foto {get;set;}
        public Dueno Dueno {get;set;}
        public Veterinario Veterinario {get;set;}
        public Historia Historia {get;set;}
    }
}