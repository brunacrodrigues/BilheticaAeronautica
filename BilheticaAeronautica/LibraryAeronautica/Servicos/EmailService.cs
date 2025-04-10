using LibraryAeronautica.Modelos;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace LibraryAeronautica.Servicos
{
    /// <summary>
    /// Serviço responsável pelo envio de e-mails.
    /// </summary>
    public class EmailService
    {
        /// <summary>
        /// Envia um e-mail para uma ou mais pessoas de forma assíncrona.
        /// </summary>
        /// <param name="de">Endereço de e-mail do remetente.</param>
        /// <param name="para">Lista de endereços de e-mail dos destinatários.</param>
        /// <param name="assunto">Assunto do e-mail.</param>
        /// <param name="corpo">Conteúdo HTML do corpo do e-mail.</param>
        /// <returns>Uma tarefa que representa a operação de envio de e-mail.</returns>
        private static async Task EnviarEmailAsync(string de, List<string> para, string assunto, string corpo)
        {
            MailAddress fromMailAddress = new MailAddress(de);

            MailMessage mail = new MailMessage();

            foreach (string email in para)
            {
                mail.To.Add(email);
            }

            mail.From = fromMailAddress;
            mail.Subject = assunto;
            mail.Body = corpo;
            mail.IsBodyHtml = true;

            SmtpClient client = GetSmtpClient();

            await client.SendMailAsync(mail);
        }

        /// <summary>
        /// Notifica os passageiros de um voo sobre alterações no mesmo.
        /// </summary>
        /// <param name="passageirosVoo">Lista de passageiros a serem notificados.</param>
        /// <param name="voo">Voo com as alterações a serem comunicadas.</param>
        /// <returns>True se todos os e-mails forem enviados com sucesso; caso contrário, false.</returns>
        public static async Task<bool> NotificarPassageirosAlteracoesAsync(List<Cliente> passageirosVoo, Voo voo)
        {
            string de = "teste@teste.com";
            List<string> para = new List<string>();
            string assunto = $"Alterações no voo {voo.NumeroVoo}, {voo.Origem.IATA} - {voo.Destino.IATA}";
            StringBuilder corpo = new StringBuilder(); // concatenar strings de forma eficiente           


            // Notificar passageiros das alterações do voo: duração, hora de partida
            try
            {
                foreach (Cliente passageiro in passageirosVoo)
                {
                    corpo.Clear();

                    corpo.AppendLine($"Caro(a) {passageiro.NomeCompleto}");
                    corpo.AppendLine("<p>");
                    corpo.AppendLine($"O voo {voo.NumeroVoo} foi alterado.");
                    corpo.AppendLine($"Novo horário: {voo.HoraPartida}, Duração: {voo.Duracao}");
                    corpo.AppendLine("<p>");
                    corpo.AppendLine("Pedimos desculpa por qualquer incómodo causado.");
                    corpo.AppendLine("<p>");
                    corpo.AppendLine("Atenciosamente, Vitoria Airlines");

                    para.Clear();
                    para.Add(passageiro.Email);

                    await EnviarEmailAsync(de, para, assunto, corpo.ToString());
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Notifica os passageiros de um voo sobre o cancelamento do mesmo.
        /// </summary>
        /// <param name="passageirosVoo">Lista de passageiros a serem notificados.</param>
        /// <param name="voo">Voo cancelado a ser comunicado.</param>
        /// <returns>True se todos os e-mails forem enviados com sucesso; caso contrário, false.</returns>
        public static async Task<bool> NotificarPassageirosCancelamentoAsync(List<Cliente> passageirosVoo, Voo voo)
        {
            string de = "teste@teste.com";
            List<string> para = new List<string>();
            string assunto = $"Cancelamento do voo {voo.NumeroVoo}, {voo.Origem.IATA} - {voo.Destino.IATA}";
            StringBuilder corpo = new StringBuilder(); // concatenar strings de forma eficiente           

            try
            {
                foreach (Cliente passageiro in passageirosVoo)
                {
                    corpo.Clear();

                    corpo.AppendLine($"Caro(a) {passageiro.NomeCompleto}");
                    corpo.AppendLine("<p>");
                    corpo.AppendLine($"O voo {voo.NumeroVoo} foi cancelado");
                    corpo.AppendLine("<p>");
                    corpo.AppendLine("O reembolso foi processado para o método de pagamento original.");
                    corpo.Append("<p>");
                    corpo.AppendLine("Pedimos desculpa por qualquer incómodo causado.");
                    corpo.AppendLine("<p>");
                    corpo.AppendLine("Atenciosamente, Vitoria Airlines");

                    para.Clear();
                    para.Add(passageiro.Email);

                    await EnviarEmailAsync(de, para, assunto, corpo.ToString());
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Notifica o cliente que mudou de bilhete da classe executiva para a classe económica.
        /// </summary>
        /// <param name="cliente">Cliente a ser notificado</param>
        /// <param name="voo">Voo para o qual o bilhete está a ser alterado.</param>
        /// <returns>True se o e-mail for enviad com sucesso; caso contrário, false.</returns>
        public static async Task<bool> NotificarPassageiroReembolsoAsync(Cliente cliente, Voo voo)
        {
            string de = "teste@teste.com";
            List<string> para = new List<string> { cliente.Email };
            string assunto = $"Reembolso pela alteração de classe no voo {voo.NumeroVoo}, {voo.Origem.IATA} - {voo.Destino.IATA}";
            StringBuilder corpo = new StringBuilder(); // concatenar strings de forma eficiente          

            try
            {                  

                corpo.AppendLine($"Caro(a) {cliente.NomeCompleto},");
                corpo.AppendLine("<p>");
                corpo.AppendLine($"Informamos que a sua reserva para o voo {voo.NumeroVoo} foi alterada da <strong>classe executiva</strong> para a <strong>classe económica</strong>.");
                corpo.AppendLine("<p>");
                corpo.AppendLine("Como resultado desta alteração, o valor correspondente à diferença entre as duas classes foi reembolsado para o seu método de pagamento original.");
                corpo.Append("<p>");
                corpo.AppendLine("<p>");
                corpo.AppendLine("Atenciosamente, Vitoria Airlines");


                await EnviarEmailAsync(de, para, assunto, corpo.ToString());
                
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Retorna um cliente SMTP pronto para uso com configurações predefinidas.
        /// </summary>
        /// <returns>Cliente SMTP configurado.</returns>
        private static SmtpClient GetSmtpClient()
        {
            string smtpHost = "127.0.0.1";
            int smtpPort = 25;
            string smtpUserName = "Teste";
            string smtpPassword = "Teste";
            bool enableSsl = false;

            SmtpClient client = new SmtpClient(smtpHost, smtpPort)
            {
                Credentials = new NetworkCredential(smtpUserName, smtpPassword),
                EnableSsl = enableSsl
            };

            return client;
        }
    }
}
