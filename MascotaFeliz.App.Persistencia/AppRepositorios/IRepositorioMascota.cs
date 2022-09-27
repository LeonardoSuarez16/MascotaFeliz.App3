using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMascota
    {
        Mascota AddMascota(Mascota mascota);
        Mascota GetMascota(int idMascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);

        Dueno AsignarDueno(int idMascota, int idDueno);
        Dueno GetMascotaDueno(int idMascota);

        Veterinario AsignarVeterinario(int idMascota, int idVeterinario);
        Veterinario GetMascotaVeterinario(int idMascota);

        Historia AsignarHistoria(int idMascota, int idHistoria);
        Historia GetMascotaHistoria(int idMascota);

        IEnumerable<Mascota> GetAllMascotasDueno(int IdDueno);
        IEnumerable<Mascota> GetAllMascotasVeterinario(int IdVeterinario);

        //IEnumerable<Mascota> GetMascotasPorFiltro(string filtro);
        IEnumerable<Mascota> GetAllMascotas();
    }
}
