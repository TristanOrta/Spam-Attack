using System;


namespace MailSpam
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string correoOrigen ;
            string password;
            string destino;
            string asunto;
            string mensaje;
            int numero;

            Console.WriteLine(" \n" +
                "░██████╗██████╗░░█████╗░███╗░░░███╗  ░█████╗░████████╗████████╗░█████╗░░█████╗░██╗░░██╗ \n" +
                "██╔════╝██╔══██╗██╔══██╗████╗░████║  ██╔══██╗╚══██╔══╝╚══██╔══╝██╔══██╗██╔══██╗██║░██╔╝ \n" +
                "╚█████╗░██████╔╝███████║██╔████╔██║  ███████║░░░██║░░░░░░██║░░░███████║██║░░╚═╝█████═╝░ \n" +
                "░╚═══██╗██╔═══╝░██╔══██║██║╚██╔╝██║  ██╔══██║░░░██║░░░░░░██║░░░██╔══██║██║░░██╗██╔═██╗░ \n" +
                "██████╔╝██║░░░░░██║░░██║██║░╚═╝░██║  ██║░░██║░░░██║░░░░░░██║░░░██║░░██║╚█████╔╝██║░╚██╗ \n" +
                "╚═════╝░╚═╝░░░░░╚═╝░░╚═╝╚═╝░░░░░╚═╝  ╚═╝░░╚═╝░░░╚═╝░░░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝ \n" +
                 "from: \n" +
                " -https://github.com/TristanOrta- \n" +
                "\n" +
                "version beta : (solo funciona con correos Gmail leer documentacion del proyecto\n" +
                "\n" +
                "\n" );


            Console.WriteLine("Introduce tu correo");
            correoOrigen = Console.ReadLine();

            Console.WriteLine("Introduce tu contraseña");
            password = Console.ReadLine();

            Console.WriteLine("Introduce el destinatario");
            destino = Console.ReadLine();

            Console.WriteLine("Introduce el asunto del correo");
            asunto = Console.ReadLine();

            Console.WriteLine("Introduce el mensaje del correo");
            mensaje = Console.ReadLine();

            Console.WriteLine("Introduce el numeo de veces a mandar el correo: ");
            numero = Int32.Parse(Console.ReadLine());

            string validaGmail = correoOrigen.Substring(correoOrigen.Length - 10);

            if (validaGmail == "@gmail.com")
            {
                servicorDeCorreo.Correogmail(correoOrigen, destino, asunto, mensaje, password,numero);
            }
            else
            {
                Console.WriteLine("Error utiliza un dominio de correo valido ejemplo:  miCorreo@gmail");
            }


        }
    }
}
