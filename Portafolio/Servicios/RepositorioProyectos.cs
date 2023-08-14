using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            { new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "E-Commers realizado en ASP.NET CORE",
                Link = "http://amazon.com",
                ImageURL = "/Imagenes/1.png",
            },
             new Proyecto
            {
                Titulo = "Google",
                Descripcion = "Pagina de noticias en react",
                Link = "http://amazon.com",
                ImageURL = "/Imagenes/2.png",
            },
             new Proyecto
            {
                Titulo = "Walmart",
                Descripcion = "software para el area de salchichoneria",
                Link = "http://amazon.com",
                ImageURL = "/Imagenes/3.jpg",
            },
             new Proyecto
            {
                Titulo = "Aurrera",
                Descripcion = "vendedor tienda en linea",
                Link = "http://amazon.com",
                ImageURL = "/Imagenes/4.jpg",
            },

            };
        }
    }
}
