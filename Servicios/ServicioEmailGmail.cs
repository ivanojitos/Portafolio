using Portafolio.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;


namespace Portafolio.Servicios
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoDTO contacto);
    }

    public class ServicioEmailGmail : IServicioEmail
    {
        private readonly IConfiguration configuration;

        public ServicioEmailGmail(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task Enviar(ContactoDTO contacto)
        {
            var emailEmisor = configuration.GetValue<string>("CONFIGURACIONES_EMAIL:EMAIL");
            var password = configuration.GetValue<string>("CONFIGURACIONES_EMAIL:PASSWORD");
            var host = configuration.GetValue<string>("CONFIGURACIONES_EMAIL:HOST");
            var puerto = configuration.GetValue<int>("CONFIGURACIONES_EMAIL:PUERTO");

            //var smtpCliente = new SmtpClient(host, puerto);
            //smtpCliente.EnableSsl = true;
            //smtpCliente.UseDefaultCredentials = false;
            //smtpCliente.Credentials = new NetworkCredential(emailEmisor, password);
            //var mensaje = new MailMessage(emailEmisor, emailEmisor,
            //    $"El cliente {contacto.Nombre} ({contacto.Email}) quiere contactarte", contacto.Mensaje);
            
            //await smtpCliente.SendMailAsync(mensaje);



            using (var smtpCliente = new SmtpClient(host, 587))
            {
                smtpCliente.EnableSsl = true;
                smtpCliente.UseDefaultCredentials = false;
                smtpCliente.Credentials = new NetworkCredential(emailEmisor, password);
                smtpCliente.DeliveryMethod = SmtpDeliveryMethod.Network;

                using (var mensaje = new MailMessage(emailEmisor, emailEmisor,
                $"El cliente {contacto.Nombre} ({contacto.Email}) quiere contactarte", contacto.Mensaje))
                {
                    await smtpCliente.SendMailAsync(mensaje);
                }
            }

        }
    }
}
