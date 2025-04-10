using LibraryAeronautica.Modelos;

namespace LibraryAeronautica.Servicos
{
    /// <summary>
    /// Serviço responsável por gerar IDs únicos.
    /// </summary>
    public class IdService
    {
        /// <summary>
        /// Gera um novo ID único para um bilhete com base nos bilhetes existentes nos voos.
        /// </summary>
        /// <param name="voos">Lista de voos contendo bilhetes.</param>
        /// <returns>O próximo ID disponível para um bilhete.</returns>
        public static int GerarIdBilhete(List<Voo> voos)
        {           
            int maiorId = 0;

            // Itera por cada voo na lista
            foreach (var voo in voos)
            {
                // Verifica se o voo possui bilhetes
                if (voo.Bilhetes != null && voo.Bilhetes.Count > 0)
                {
                    // Itera por cada bilhete do voo
                    foreach (var bilhete in voo.Bilhetes)
                    {
                        // Se o ID do bilhete atual for maior que o maiorId, atualiza o maiorId
                        if (bilhete.Id > maiorId)
                        {
                            maiorId = bilhete.Id;
                        }
                    }
                }
            }

            // Retorna o próximo ID, que é o maiorId + 1
            return maiorId + 1;
        }

        /// <summary>
        /// Gera um novo ID único para um aeroporto.
        /// </summary>
        /// <param name="aeroportos">Lista de aeroportos existentes.</param>
        /// <returns>O próximo ID disponível para um aeroporto.</returns>
        public static int GerarIdAeroporto(List<Aeroporto> aeroportos)
        {
            return aeroportos.Count > 0 ? aeroportos.Max(x => x.Id) + 1 : 1;
        }

        /// <summary>
        /// Gera um novo ID único para um cliente.
        /// </summary>
        /// <param name="clientes">Lista de clientes existentes.</param>
        /// <returns>O próximo ID disponível para um cliente.</returns>
        public static int GerarIdCliente(List<Cliente> clientes)
        {
            return clientes.Count > 0 ? clientes.Max(x => x.Id) + 1 : 1;
        }

        /// <summary>
        /// Gera um novo ID único para um avião.
        /// </summary>
        /// <param name="avioes">Lista de aviões existentes.</param>
        /// <returns>O próximo ID disponível para um avião.</returns>
        public static int GerarIdAviao(List<Aviao> avioes)
        {
            return avioes.Count > 0 ? avioes.Max(x => x.Id) + 1 : 1;
        }

        /// <summary>
        /// Gera um novo ID único para um voo.
        /// </summary>
        /// <param name="voos">Lista de voos existentes.</param>
        /// <returns>O próximo ID disponível para um voo.</returns>
        public static int GerarIdVoo(List<Voo> voos)
        {
            return voos.Count > 0 ? voos.Max(r => r.Id) + 1 : 1;
        }
    }
}
