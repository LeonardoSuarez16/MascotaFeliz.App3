using System;
using System.Collections.Generic;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno
            _repoDueno = new RepositorioDueno(new Persistencia.AppContext());

        private static IRepositorioVeterinario
            _repoVeterinario =
                new RepositorioVeterinario(new Persistencia.AppContext());

        private static IRepositorioMascota
            _repoMascota =
                new RepositorioMascota(new Persistencia.AppContext());

        private static IRepositorioHistoria
            _repoHistoria =
                new RepositorioHistoria(new Persistencia.AppContext());

        private static IRepositorioVisitaPyP
            _repoVisitaPyP =
                new RepositorioVisitaPyP(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("HOLA       FELICITACIONES     YA       ESTA      FUNCIONANDO");

            AddDueno();
            //BuscarDueno(7);
            //UpdateDueno(2);
            //DeleteDueno(5);

            AddVeterinario();
            //BuscarVeterinario(19);
            //UpdateVeterinario(4);
            //DeleteVeterinario(15);

            //AddMascota();
            //BuscarMascota(1);
            //UpdateMascota(12);
            //DeleteMascota(10);

            //AddHistoria();
            //BuscarHistoria(2);
            //UpdateHistoria(1);
            //DeleteHistoria(1);
                        
            //AsignarVeterinario(1, 4);
            //AsignarVeterinario(2, 5);

            //AddVisitaPyP();
            //BuscarVisitaPyP(11);
            //UpdateVisitaPyP(4);
            //DeleteVisitaPyP(2);

            //ListarDuenoFiltro();
            //ListarVeterinariosFiltro();
            //ListarMascotaFiltro();
            
            //GetAllMascotas();
        }

        private static void AddDueno()
        {
            var dueno =
                new Dueno {
                    Nombres = "Emilton",
                    Apellidos = "Mendoza Ojeda",
                    Direccion = "Costa sin Mar",
                    Telefono = "3156838222",
                    Correo = "emiltonmendozao@gmail.com"
                };
            _repoDueno.AddDueno (dueno);
            
            dueno =
                new Dueno {
                    Nombres = "Esneider",
                    Apellidos = "Méndez Méndez",
                    Direccion = "Avenida Siempre Viva",
                    Telefono = "3156838333",
                    Correo = "mendezesneider@gmail.com"
                };
            _repoDueno.AddDueno (dueno);            

            dueno =
                new Dueno {
                    Nombres = "Leonardo Picasso",
                    Apellidos = "Suarez Frances",
                    Direccion = "Autos Leo 123",
                    Telefono = "3156838444",
                    Correo = "autosLeo@gmail.com"
                };
            _repoDueno.AddDueno (dueno);            
        }

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console
                .WriteLine(dueno.Nombres +
                " " +
                dueno.Apellidos +
                " " +
                dueno.Direccion +
                " " +
                dueno.Telefono +
                " " +
                dueno.Correo);
        }

        private static void UpdateDueno(int idDueno)
        {
            var dueno = new Dueno {
                    Id = idDueno,
                    Nombres = "Esneider",
                    Apellidos = "Méndez",
                    Direccion = "Calle 123",
                    Telefono = "3333333333",
                    Correo = "mendezmendez@gmail.com"
                };
            _repoDueno.UpdateDueno(dueno);
        }

        private static void DeleteDueno(int idDueno)
        {
            _repoDueno.DeleteDueno(idDueno);
        }


        private static void AddVeterinario()
        {
            var veterinario =
                new Veterinario {
                    Nombres = "Esmeralda",
                    Apellidos = "Verde",
                    Direccion = "Colombia 123",
                    Telefono = "3100002345",
                    TarjetaProfesional = "001178"
                };
            _repoVeterinario.AddVeterinario (veterinario);

            veterinario =
                new Veterinario {
                    Nombres = "Dennis Angela",
                    Apellidos = "Gomez Amador",
                    Direccion = "Bogota DC",
                    Telefono = "3100006789",
                    TarjetaProfesional = "001180"
                };
            _repoVeterinario.AddVeterinario (veterinario);            
        }

        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console
                .WriteLine(veterinario.Nombres +
                " " +
                veterinario.Apellidos +
                " " +
                veterinario.Direccion +
                " " +
                veterinario.Telefono +
                " " +
                veterinario.TarjetaProfesional);
        }

        private static void UpdateVeterinario (int idVeterinario)
        {
             var veterinario = new Veterinario {
                    Id = idVeterinario,
                    Nombres = "Esmeralda",
                    Apellidos = "Ardila",
                    Direccion = "Calle 32 42 52",
                    Telefono = "3152222222",
                    TarjetaProfesional = "AI5678"
                };
            _repoVeterinario.UpdateVeterinario(veterinario);
        }

        private static void DeleteVeterinario(int idVeterinario)
        {
            _repoVeterinario.DeleteVeterinario(idVeterinario);
        }

        private static void AddMascota()
        {
            var mascota =
                new Mascota {
                    Nombres = "Felix El Gato",
                    Color = "#000000",
                    Raza = "Angora",
                    Especie = "Felino",
                    Foto = "Foto"
                };
            var mascotaGuardada=_repoMascota.AddMascota (mascota);
            _repoMascota.AsignarDueno(mascotaGuardada.Id,1);
            _repoMascota.AsignarVeterinario(mascotaGuardada.Id,4);
            var mascotaHistoria=AddHistoria();
            var historiaGuardada=_repoMascota.AsignarHistoria(mascotaGuardada.Id,mascotaHistoria.Id);
            
            var visitaPyP =
                new VisitaPyP {
                    FechaVisita = new DateTime(2022, 10, 02),
                    Temperatura = 35,
                    Peso = 20,
                    FrecuenciaRespiratoria = 35, 
                    FrecuenciaCardiaca = 20,
                    EstadoAnimo = "Ansioso",
                    Recomendaciones = "Evitar dejarlo en espacios pequeños"
                  };
            var visitaGuardada=_repoVisitaPyP.AddVisitaPyP(visitaPyP);
            _repoVisitaPyP.AsignarHistoria(visitaGuardada.Id,historiaGuardada.Id);

            visitaPyP =
                new VisitaPyP {
                    FechaVisita = new DateTime(2022, 10, 02),
                    Temperatura = 34,
                    Peso = 21,
                    FrecuenciaRespiratoria = 37, 
                    FrecuenciaCardiaca = 23,
                    EstadoAnimo = "Asustadiso",
                    Recomendaciones = "Evitar Exponerlo a Sonidos Fuertes"
                  };
            visitaGuardada=_repoVisitaPyP.AddVisitaPyP(visitaPyP);
            _repoVisitaPyP.AsignarHistoria(visitaGuardada.Id,historiaGuardada.Id);

            visitaPyP =
                new VisitaPyP {
                    FechaVisita = new DateTime(2022, 10, 02),
                    Temperatura = 34,
                    Peso = 21,
                    FrecuenciaRespiratoria = 37, 
                    FrecuenciaCardiaca = 23,
                    EstadoAnimo = "Impredecible",
                    Recomendaciones = "Llevarlo al parque dia por medio"
                  };
            visitaGuardada=_repoVisitaPyP.AddVisitaPyP(visitaPyP);
            _repoVisitaPyP.AsignarHistoria(visitaGuardada.Id,historiaGuardada.Id);


            mascota =
                new Mascota {
                    Nombres = "Growlie",
                    Color = "#CCCC00",
                    Raza = "Pokemon",
                    Especie = "Canino",
                    Foto = "Foto"
                };
            mascotaGuardada=_repoMascota.AddMascota (mascota);
            _repoMascota.AsignarDueno(mascotaGuardada.Id,2);
            _repoMascota.AsignarVeterinario(mascotaGuardada.Id,5);
            mascotaHistoria=AddHistoria();
            historiaGuardada=_repoMascota.AsignarHistoria(mascotaGuardada.Id,mascotaHistoria.Id);

            visitaPyP =
                new VisitaPyP {
                    FechaVisita = new DateTime(2022, 10, 02),
                    Temperatura = 34,
                    Peso = 21,
                    FrecuenciaRespiratoria = 37, 
                    FrecuenciaCardiaca = 23,
                    EstadoAnimo = "Somnoliento",
                    Recomendaciones = "Alejarlo de espacios ruidosos para que pueda descansar"
                  };
            visitaGuardada=_repoVisitaPyP.AddVisitaPyP(visitaPyP);
            _repoVisitaPyP.AsignarHistoria(visitaGuardada.Id,historiaGuardada.Id);

            visitaPyP =
                new VisitaPyP {
                    FechaVisita = new DateTime(2022, 10, 02),
                    Temperatura = 34,
                    Peso = 21,
                    FrecuenciaRespiratoria = 37, 
                    FrecuenciaCardiaca = 23,
                    EstadoAnimo = "Alegre",
                    Recomendaciones = "Aumentar la cantidad de concentrado"
                  };
            visitaGuardada=_repoVisitaPyP.AddVisitaPyP(visitaPyP);
            _repoVisitaPyP.AsignarHistoria(visitaGuardada.Id,historiaGuardada.Id);                      

            mascota =
                new Mascota {
                    Nombres = "Meowth",
                    Color = "#CCCCCC",
                    Raza = "Pokemon",
                    Especie = "Felino",
                    Foto = "Foto"
                };
            mascotaGuardada=_repoMascota.AddMascota (mascota);
            _repoMascota.AsignarDueno(mascotaGuardada.Id,3);
            _repoMascota.AsignarVeterinario(mascotaGuardada.Id,4);            
            mascotaHistoria=AddHistoria();
            historiaGuardada=_repoMascota.AsignarHistoria(mascotaGuardada.Id,mascotaHistoria.Id);

            mascota =
                new Mascota {
                    Nombres = "SnowBull",
                    Color = "#FFCCCC",
                    Raza = "Pokemon",
                    Especie = "Canino",
                    Foto = "Foto"
                };
            mascotaGuardada=_repoMascota.AddMascota (mascota);
            _repoMascota.AsignarDueno(mascotaGuardada.Id,1);
            _repoMascota.AsignarVeterinario(mascotaGuardada.Id,5);
            mascotaHistoria=AddHistoria();
            _repoMascota.AsignarHistoria(mascotaGuardada.Id,mascotaHistoria.Id);

            mascota =
                new Mascota {
                    Nombres = "Persian",
                    Color = "#FFFFCC",
                    Raza = "Pokemon",
                    Especie = "Felino",
                    Foto = "Foto"
                };
            mascotaGuardada=_repoMascota.AddMascota (mascota);
            _repoMascota.AsignarDueno(mascotaGuardada.Id,2);
            _repoMascota.AsignarVeterinario(mascotaGuardada.Id,4);
            mascotaHistoria=AddHistoria();
            _repoMascota.AsignarHistoria(mascotaGuardada.Id,mascotaHistoria.Id);

            mascota =
                new Mascota {
                    Nombres = "Suicune",
                    Color = "#55FF55",
                    Raza = "Pokemon",
                    Especie = "Canino",
                    Foto = "Foto"
                };
            mascotaGuardada=_repoMascota.AddMascota (mascota);
            _repoMascota.AsignarDueno(mascotaGuardada.Id,3);
            _repoMascota.AsignarVeterinario(mascotaGuardada.Id,5);
            mascotaHistoria=AddHistoria();
            _repoMascota.AsignarHistoria(mascotaGuardada.Id,mascotaHistoria.Id);


        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console
                .WriteLine(mascota.Id +
                " " +
                mascota.Nombres +
                " " +
                mascota.Color +
                " " +
                mascota.Especie +
                " " +
                mascota.Raza);
        }

        private static void UpdateMascota(int idMascota)
        {
            var mascota =
                new Mascota {
                    Id = idMascota,
                    Nombres = "Max",
                    Color = "Chocolate",
                    Raza = "Cocker",
                    Especie = "Canino"
                };
            _repoMascota.UpdateMascota(mascota);
        }

        private static void DeleteMascota(int idMascota)
        {
            _repoMascota.DeleteMascota(idMascota);
        }



       
        private static void AddVisitaPyP()
        {
            var visitaPyP =
                new VisitaPyP {
                    
                    FechaVisita = new DateTime(2022, 10, 02),
                    Temperatura = 35,
                    Peso = 20,
                    FrecuenciaRespiratoria = 35, 
                    FrecuenciaCardiaca = 20,
                    EstadoAnimo = "Juguetón",
                    Recomendaciones = "Entonces quitar el juguete"
                  };
            _repoVisitaPyP.AddVisitaPyP (visitaPyP);
        }


        private static void BuscarVisitaPyP(int idVisitaPyP)
        {
            var visitaPyP = _repoVisitaPyP.GetVisitaPyP(idVisitaPyP);
            Console
                .WriteLine(visitaPyP.Id +
                " " +
                visitaPyP.FechaVisita +
                " " +
                visitaPyP.Temperatura +
                " " +
                visitaPyP.Peso +
                " " +
                visitaPyP.EstadoAnimo +
                " " +
                visitaPyP.Recomendaciones);
        }


        private static void UpdateVisitaPyP(int idVisitaPyP)
        {
            var visitaPyP =
                new VisitaPyP {
                    
                    FechaVisita = new DateTime(2021, 6, 28),
                    Temperatura = 35,
                    Peso = 20,
                    FrecuenciaRespiratoria = 35, 
                    FrecuenciaCardiaca = 24,
                    EstadoAnimo = "Muy Somnoliento",
                    Recomendaciones = "Cuidar mucho"
                  };
            _repoVisitaPyP.AddVisitaPyP (visitaPyP);
        }


        private static void DeleteVisitaPyP(int idVisitaPyP)
        {
            _repoVisitaPyP.DeleteVisitaPyP(idVisitaPyP);
        }

        private static Historia AddHistoria()
        {
            Random rnd = new Random();
            int month  = rnd.Next(1, 13);
            int day    = rnd.Next(1, 27);//no me quiero complicar con febrero
            var historia =
                new Historia {
                    FechaInicial = new DateTime(2022, month, day)
                    //VisitasPyP = new List<VisitaPyP>()
                };
           // historia.VisitasPyP.Add({new DateTime(2021, 6, 28),35,20,35,24,"Somnoliento","Cuidar mucho"});
            return _repoHistoria.AddHistoria(historia);
        }

        private static void BuscarHistoria(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            Console.WriteLine(historia.FechaInicial);
        }

        private static void UpdateHistoria(int idHistoria)
        {
            var historia =
                new Historia {
                    Id = idHistoria,
                    FechaInicial = new DateTime(2021, 09, 16)

                };
            _repoHistoria.UpdateHistoria(historia);
        }

         private static void DeleteHistoria(int idHistoria)
        {
            _repoHistoria.DeleteHistoria(idHistoria);
        }


    }
}
