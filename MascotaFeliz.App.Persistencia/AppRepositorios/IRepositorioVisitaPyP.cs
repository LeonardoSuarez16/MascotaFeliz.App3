using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisitaPyP
    {
        VisitaPyP AddVisitaPyP(VisitaPyP visitaPyP);

        VisitaPyP UpdateVisitaPyP(VisitaPyP visitaPyP);

        void DeleteVisitaPyP(int idVisitaPyP);

        VisitaPyP GetVisitaPyP(int idVisitaPyP);

        Historia AsignarHistoria(int idVisita, int idHistoria);

        Historia GetHistoriaVisitaPyP(int IdVisita);
        
        IEnumerable<VisitaPyP> GetVisitaPorHistoria(int filtro);

        IEnumerable<VisitaPyP> GetAllVisitaPyP();


    }
}
