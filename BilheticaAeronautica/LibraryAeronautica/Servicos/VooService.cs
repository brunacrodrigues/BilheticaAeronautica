using LibraryAeronautica.Modelos;

namespace LibraryAeronautica.Servicos
{
    /// <summary>
    /// Serviço responsável por operações relacionadas aos voos, como geração de número, atualizações e remarcações de bilhetes do voo.
    /// </summary>
    public static class VooService
    {
        /// <summary>
        /// Gera um número de voo aleatório com o prefixo "VA".
        /// </summary>
        /// <returns>Uma string com o número do voo gerado (ex: "VA1234").</returns>
        public static string GerarNumeroVoo()
        {
            string sigla = "VA";
            Random random = new Random();
            int numero = random.Next(100, 9999);

            return $"{sigla}{numero}";
        }

        /// <summary>
        /// Atualiza os voos agendados com o novo modelo de avião atualizado.
        /// </summary>
        /// <param name="voos">Lista de voos agendados.</param>
        /// <param name="aviaoAtualizado">Avião com as novas informações.</param>
        public static void AtualizarVoosAgendados(List<Voo> voos, Aviao aviaoAtualizado)
        {
            var voosAgendados = voos.Where(x => x.Aviao.Modelo == aviaoAtualizado.Modelo && x.DataPartida > DateTime.Now);

            foreach (var voo in voosAgendados)
            {
                voo.Aviao = aviaoAtualizado;
            }
        }

        /// <summary>
        /// Atualiza ou remarca os bilhetes de um voo com base numa nova configuração de lugares.
        /// </summary>
        /// <param name="voo">Voo cujos bilhetes devem ser atualizados.</param>
        /// <param name="remarcar">Define se os bilhetes devem ser remarcados ou não para os mesmos clientes.</param>
        /// <param name="voos">Lista de voos usados para gerar IDs únicos.</param>
        public static void AtualizarOuRemarcarBilhetes(Voo voo, bool remarcar, List<Voo> voos)
        {
            List<Bilhete> bilhetesAntigos = voo.Bilhetes.ToList();

            voo.Bilhetes.Clear();

            List<Lugar> tempLugares = voo.Aviao.Lugares.Select(l => new Lugar
            {
                Fila = l.Fila,
                Letra = l.Letra,
                Tipo = l.Tipo,
                Disponivel = l.Disponivel
            }).ToList();

            int idBilhete = IdService.GerarIdBilhete(voos);

            foreach (var lugar in tempLugares)
            {

                // Verifica se bilhete antigo correspondente ao lugar
                Bilhete bilheteAntigo = bilhetesAntigos.FirstOrDefault(b => b.Lugar.Tipo == lugar.Tipo && b.Lugar.Fila == lugar.Fila && b.Lugar.Letra == lugar.Letra);

                // Define o valor do bilhete, caso o bilhete antigo exista
                decimal valorBilhete = bilhetesAntigos.First(b => b.Lugar.Tipo == lugar.Tipo).Valor;

                // Cria o novo bilhete
                Cliente clientePadrao = new Cliente
                {
                    Id = 0,
                    NomeCompleto = "Cliente Padrão"
                };

                Bilhete novoBilhete = new Bilhete
                {
                    Id = idBilhete++,
                    Lugar = lugar,
                    Voo = voo,
                    Cliente = clientePadrao,
                    Valor = valorBilhete
                };

                voo.Bilhetes.Add(novoBilhete);

                // Verifica se o bilhete antigo possui um cliente
                if (remarcar && bilheteAntigo != null && bilheteAntigo.Cliente != null && bilheteAntigo.Cliente.Id != 0 )
                {
                    // Substitui o cliente do novo bilhete pelo cliente do bilhete antigo
                    novoBilhete.Cliente = bilheteAntigo.Cliente;
                    novoBilhete.Lugar.Disponivel = false;
                }
                else
                {
                    novoBilhete.Lugar.Disponivel = true;
                }
            }
        }
    }
}








