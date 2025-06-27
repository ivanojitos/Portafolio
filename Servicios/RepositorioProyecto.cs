using Portafolio.Models;

namespace Portafolio.Servicios
{

    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }
    public class RepositorioProyecto : IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO
                {
                    Id = 1,
                    Titulo = "Servimsa",
                    Subtitulo = "Laravel",
                    Descripcion = "Me incorpore al sistema, pero es un sistema encargado de factoraje. te brinda reportes, altas de usuarios y carga de facturas como tambien " +
                    "ver los clientes que tienen pendientes por cargas sus facturas.",
                    Link = "https://whirlpool.com",
                    ImagenURL = "/imagenes/servimsa.png"
                },new ProyectoDTO
                {
                    Id = 2,
                    Titulo = "Wal-Mart",
                    Subtitulo = "ASP.NET",
                    Descripcion = "Realice el back y el front de cada una de las vistas. uno de los retos mas importantes fue , adaptarme al sistema. algo importante que destacar " +
                    "es que  yo no conocia asp.",
                    Link = "https://walmart.com",
                    ImagenURL = "/imagenes/Walmart.jpg"
                },new ProyectoDTO
                {
                     Id = 3,
                    Titulo = "Ey Banco",
                    Subtitulo = "Laravel con flutter",
                    Descripcion = "BackOffices en laravel con apis en android",
                    Link = "https://eybanco.com",
                    ImagenURL = "/imagenes/eybanco.png"
                },new ProyectoDTO
                {
                    Id = 4,
                    Titulo = "Miches Algo bien",
                    Subtitulo = "Laravel",
                    Descripcion = "Sistema encargado de llevar toda la venta del lugar y un backoffice para administradores.",
                    Link = "https://pv.michesalgobien.com",
                    ImagenURL = "/imagenes/miches-0.jpeg"
                },new ProyectoDTO
                {
                    Id = 5,
                    Titulo = "TechnoAlarme",
                    Subtitulo = "Windows Form",
                    Descripcion = "Sistema de monitoreo.",
                    Link = "https://technoalarme.com",
                    ImagenURL = "/imagenes/technoalarme.jpg"
                }
            };
        }
    }
}
