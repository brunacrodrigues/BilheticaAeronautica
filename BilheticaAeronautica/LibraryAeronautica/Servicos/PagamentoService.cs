using LibraryAeronautica.Enums;
using Stripe;
using System.Configuration;

namespace LibraryAeronautica.Servicos
{
    /// <summary>
    /// Serviço responsável pelo processamento de pagamentos através de diferentes métodos simulados e Stripe.
    /// </summary>
    public static class PagamentoService
    {      

        static readonly string stripeKey = ConfigurationManager.AppSettings["StripeSecretKey"];
        public static string Mensagem { get; private set; } = "";


        /// <summary>
        /// Simula o processamento de um pagamento via PayPal de forma assíncrona.
        /// </summary>
        /// <param name="valor">Valor a ser pago.</param>
        /// <returns>Uma tarefa que retorna true caso o pagamento seja aprovado, caso contrário false.</returns>
        private static async Task<bool> ProcessarPagamentoPayPalAsync(decimal valor)
        {
            await Task.Delay(2000);

            bool sucesso = new Random().Next(2) == 1;

            Mensagem = sucesso ? "Pagamento PayPal aprovado." : "Pagamento PayPal recusado.";

            return sucesso;
        }

        /// <summary>
        /// Simula o processamento de um pagamento via MBWay de forma assíncrona.
        /// </summary>
        /// <param name="valor">Valor a ser pago.</param>
        /// <returns>Uma tarefa que retorna true caso o pagamento seja aprovado, caso contrário false.</returns>
        private static async Task<bool> ProcessarPagamentoMBWayAsync(decimal valor)
        {
            await Task.Delay(1500);

            bool sucesso = new Random().Next(2) == 1;

            Mensagem = sucesso ? "Pagamento MB WAY aprovado." : "Pagamento MB WAY recusado.";

            return sucesso;
        }

        /// <summary>
        /// Processa um pagamento real via Stripe com cartão de crédito (usando token de teste) de forma assíncrona.
        /// </summary>
        /// <param name="valor">Valor a ser pago.</param>
        /// <returns>Uma tarefa que retorna true se o pagamento for efetuado com sucesso.</returns>
        public static async Task<bool> ProcessarPagamentoCartaoAsync(decimal valor)
        {
            try
            {
                StripeConfiguration.ApiKey = stripeKey;

                string token = "tok_mastercard";

                var options = new ChargeCreateOptions
                {
                    Amount = Convert.ToInt32(valor * 100),
                    Currency = "eur",
                    Description = "Compra de bilhete via Stripe.",
                    Source = token
                };

                var chargeService = new ChargeService();

                Charge charge = await chargeService.CreateAsync(options);

                if (charge.Paid)
                {
                    Mensagem = "Pagamento efetuado com sucesso!";
                    return true;
                }
                else
                {
                    Mensagem = "O pagamento foi recusado pelo provedor.";
                    return false;
                }
            }
            catch (StripeException ex)
            {
                Mensagem = "Pagamento recusado: " + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                Mensagem = "Erro inesperado: " + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Processa um pagamento com o método de pagamento selecionado de forma assíncrona.
        /// </summary>
        /// <param name="valor">Valor a ser pago.</param>
        /// <param name="metodo">Método de pagamento a ser utilizado (Cartão, PayPal ou MB WAY).</param>
        /// <returns>Uma tarefa que retorna true se o pagamento for efetuado com sucesso, caso contrário retorna false.</returns>
        public static async Task<bool> ProcessarPagamentoAsync(decimal valor, MetodoPagamento metodo)
        {
            bool resultado;

            switch (metodo)
            {
                case MetodoPagamento.Cartao:
                    resultado = await ProcessarPagamentoCartaoAsync(valor);
                    break;
                case MetodoPagamento.PayPal:
                    resultado = await ProcessarPagamentoPayPalAsync(valor);
                    break;
                case MetodoPagamento.MBWay:
                    resultado = await ProcessarPagamentoMBWayAsync(valor);
                    break;
                default:
                    return false;
            }
            return resultado;
        }
    }
}
