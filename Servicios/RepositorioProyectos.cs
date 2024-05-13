
using Portafolio.Models;

namespace Portafolio.Servicios{

    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    };

    public class RepositorioProyectos: IRepositorioProyectos{
        public List<ProyectoDTO> ObtenerProyectos(){
        return new List<ProyectoDTO> {
            new ProyectoDTO{
            Titulo = "Cygnus",
            Descripcion = "Interprete para un lenguaje de programación cuyas reglas fueron definidas por nuestro grupo de trabajo",
            Link = "https://github.com/jjuanic/Cygnus",
            ImagenURL = "/images/Cygnus.png"
            },
            new ProyectoDTO{
            Titulo = "Tridify",
            Descripcion = "Proyecto Front-End que simula la compra de albúmes músicales consultados en la API de ITunes",
            Link = "https://tridify.netlify.app/",
            ImagenURL = "/images/M20.jpg"
            },
            new ProyectoDTO{
            Titulo = "HalcNews",
            Descripcion = "Proyecto Back-End en C# con Framework ABP que da soporte a una aplicación de noticias",
            Link = "https://github.com/HalcSF/HalcNews-BE",
            ImagenURL = "/images/Halc.jfif"
            },
            new ProyectoDTO{
            Titulo = "Portafolio Web",
            Descripcion = "Página Web realizada en ASP.NET MVC para un curso de Udemy 'Aprende ASP.NET Core MVC 6 Haciendo Proyectos Desde Cero'",
            Link = "https://www.udemy.com/course/aprende-aspnet-core-mvc-haciendo-proyectos-desde-cero/?kw=mvc+6+asp.net&src=sac",
            ImagenURL = "/images/portafolio.png"
            },
        };
    }

    }
}