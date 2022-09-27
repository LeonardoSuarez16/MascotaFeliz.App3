using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;


namespace MascotaFeliz.App.Persistencia
{
public class RepositorioVisitaPyP : IRepositorioVisitaPyP
{  
///<summary>
/// Referencia al contexto del VisitaPyP
///</summary>
private readonly AppContext _appContext;
///<summary>
/// Metodo Constructor utilizado
///<summary>
///</summary>
///<param name="appContext"></param>//
public RepositorioVisitaPyP(AppContext appContext)
{
    _appContext = appContext;
}
                                                                                                 
public VisitaPyP AddVisitaPyP(VisitaPyP visitaPyP)
{
   var visitaPyPAdicionado = _appContext.VisitasPyP.Add(visitaPyP);
   _appContext.SaveChanges();   
   return visitaPyPAdicionado.Entity;
}

public VisitaPyP GetVisitaPyP(int idVisitaPyP)
{
    return _appContext.VisitasPyP.Include(v => v.Historia).FirstOrDefault(v => v.Id == idVisitaPyP);
}


public VisitaPyP UpdateVisitaPyP(VisitaPyP visitaPyP)
{
    var visitaEncontrado = _appContext.VisitasPyP.FirstOrDefault(v => v.Id == visitaPyP.Id);
if (visitaEncontrado != null)
{

    visitaEncontrado.FechaVisita = visitaPyP.FechaVisita;
    visitaEncontrado.Temperatura = visitaPyP.Temperatura;
    visitaEncontrado.Peso = visitaPyP.Peso;
    visitaEncontrado.FrecuenciaRespiratoria = visitaPyP.FrecuenciaRespiratoria;
    visitaEncontrado.FrecuenciaCardiaca = visitaPyP.FrecuenciaCardiaca;
    visitaEncontrado.EstadoAnimo = visitaPyP.EstadoAnimo;
    visitaEncontrado.IdVeterinario = visitaPyP.IdVeterinario;
    visitaEncontrado.Recomendaciones = visitaPyP.Recomendaciones;
  
    _appContext.SaveChanges();
}
   return visitaEncontrado;

  }

  public void DeleteVisitaPyP(int idVisitaPyP)
{
 var visitaEncontrada = _appContext.VisitasPyP.FirstOrDefault(v => v.Id == idVisitaPyP);
                                                                       
  if (visitaEncontrada == null)
                {
                 Console.WriteLine("Visita no encontrada");
                 return;
                }
_appContext.VisitasPyP.Remove(visitaEncontrada);
_appContext.SaveChanges();
Console.WriteLine("Visita fue borrada correctamente");
}


public Historia AsignarHistoria(int idVisita, int idHistoria)
{
    var visitaEncontrada = _appContext.VisitasPyP.FirstOrDefault(v => v.Id == idVisita);
    if(visitaEncontrada != null)
    {
        var historiaEncontrada = _appContext.Historias.FirstOrDefault(h => h.Id == idHistoria);
        if(historiaEncontrada != null)
        {
            visitaEncontrada.Historia = historiaEncontrada;
            _appContext.SaveChanges();
        }
        return historiaEncontrada;
    }
    return null;
}  

public IEnumerable<VisitaPyP> GetVisitaPorHistoria(int filtro)
{
    return  _appContext.VisitasPyP
               .Include(v => v.Historia)
               .Where(v => v.Historia.Id == filtro);

}

public Historia GetHistoriaVisitaPyP(int IdVisita){
    //var visitaEncontrada = _appContext.VisitasPyP.FirstOrDefault(v => v.Id == IdVisita);
    var visitaEncontrada = _appContext.VisitasPyP
        .Include(v => v.Historia)
        .FirstOrDefault(v => v.Id == IdVisita);
    return visitaEncontrada.Historia;
}

public IEnumerable<VisitaPyP> GetAllVisitaPyP()
{
    return _appContext.VisitasPyP;
}


} 
}
 