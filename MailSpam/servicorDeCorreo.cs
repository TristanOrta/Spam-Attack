using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace MailSpam
{
    class servicorDeCorreo
    {
        public static void Correogmail(string correoOrigen,string destino,string asunto,string mensaje,string password, int numero)
        {
            string errorMessaje = "ERROR: revisa que tu correo y/o contraseña esten correctos";
            string exito = "Correo enviado con exito";
            for (int i = 1; i <= numero; i++)
            {
                try
                {
                    
                    MailMessage oMailMessage = new MailMessage(correoOrigen, destino, asunto, mensaje);

                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Host = "smtp.gmail.com";
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new System.Net.NetworkCredential(correoOrigen, password);

                    smtpClient.Send(oMailMessage);

                    Console.WriteLine(exito);

                    smtpClient.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(errorMessaje + ex);
                }
            }


         
        }

    }
}
