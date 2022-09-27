using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioDueno
    {
        Dueno AddDueno(Dueno dueno);

        Dueno GetDueno(int idDueno);

        Dueno UpdateDueno(Dueno dueno);

        void DeleteDueno(int idDueno);

        IEnumerable<Dueno> GetDuenosPorFiltro(string filtro);

        IEnumerable<Dueno> GetAllDuenos();
    }
}
