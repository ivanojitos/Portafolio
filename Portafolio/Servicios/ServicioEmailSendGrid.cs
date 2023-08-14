using Portafolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portafolio.Servicios
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoViewModel contacto);
    }
    public class ServicioEmailSendGrid: IServicioEmail
    {
        private readonly IConfiguration configuration;

        public ServicioEmailSendGrid(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task Enviar(ContactoViewModel contacto)
        {
            var apikey = configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = configuration.GetValue<string>("SENDGRID_NOMBRE");

            var cliente = new SendGridClient(apikey);
            var from = new EmailAddress(email, nombre);
            var subjet = $"El cliente {contacto.Email} quiere contactarte";
            var to = new EmailAddress(email, nombre);
            var memsajeTextoPlano = contacto.Mensaje;
            var contenidoHtml = $@"De: {contacto.Nombre} - Email: {contacto.Email} Mensaje: {contacto.Mensaje}";
            var sigleEmail = MailHelper.CreateSingleEmail(from, to, subjet, memsajeTextoPlano, contenidoHtml);
            var respuesta = await cliente.SendEmailAsync(sigleEmail);
        }
    }
}
