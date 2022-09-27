using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
public interface IRepositorioHistoria
{
     
     Historia AddHistoria(Historia historia);
     Historia GetHistoria(int idHistoria);
     Historia UpdateHistoria(Historia historia);
     void DeleteHistoria(int idHistoria);     

     //IEnumerable<VisitaPyP> GetVisitasHistoria(int idHistoria);
     //IEnumerable<Historia> GetAllHistoria();
   }
}
