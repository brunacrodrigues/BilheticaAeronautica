using LibraryAeronautica.Enums;
using LibraryAeronautica.Modelos;

namespace LibraryAeronautica.Servicos
{
    /// <summary>
    /// Serviço responsável por operações relacionadas à entidade Aviao, 
    /// como gerar lugares e validar a eliminação de um modelo.
    /// </summary>
    public class AviaoService
    {

        /// <summary>
        /// Gera os lugares (executivos e económicos) para um avião, com base nas quantidades definidas.
        /// </summary>
        /// <param name="aviao">O avião que receberá a lista completa de lugares gerados.</param>
        public static void GerarLugaresAviao(Aviao aviao)
        {
            List<Lugar> lugares = new List<Lugar>();
            const string letrasLugares = "ABCDEF"; // Máximo 6 lugares por fila

            // Gerar lugares executivos
            GerarLugaresPorTipo(aviao.LugaresExecutivos, TipoLugar.Executivo, lugares, letrasLugares);

            // Gerar lugares económicos
            GerarLugaresPorTipo(aviao.LugaresEconomicos, TipoLugar.Economico, lugares, letrasLugares);

            aviao.Lugares = lugares;
        }

        /// <summary>
        /// Gera uma lista de lugares com base no tipo (executivo/económico).
        /// </summary>
        /// <param name="totalLugares">Total de lugares a serem gerados.</param>
        /// <param name="tipo">Tipo do lugar (executivo ou económico).</param>
        /// <param name="lugares">Lista onde os lugares serão adicionados.</param>
        /// <param name="letrasLugares">Sequência de letras usadas para os lugares.</param>
        private static void GerarLugaresPorTipo(int totalLugares, TipoLugar tipo, List<Lugar> lugares, string letrasLugares)
        {
            int lugaresPorFila = letrasLugares.Length;
            int filas = (int)Math.Ceiling((double)totalLugares / lugaresPorFila);
            int lugaresRestantes = totalLugares;
            int filaInicial = 1;

            // Gerar os lugares para o tipo especificado
            for (int fila = filaInicial; fila < filaInicial + filas; fila++)
            {
                for (int i = 0; i < Math.Min(lugaresPorFila, lugaresRestantes); i++)
                {
                    lugares.Add(new Lugar
                    {
                        Fila = fila,
                        Letra = letrasLugares[i].ToString(),
                        Tipo = tipo,
                        Disponivel = true,
                    });
                }
                lugaresRestantes -= Math.Min(lugaresPorFila, lugaresRestantes);
            }
        }


        /// <summary>
        /// Retorna o estado textual do avião com base no seu atributo booleano.
        /// </summary>
        /// <param name="aviao">Instância do avião.</param>
        /// <returns>String "Ativo" ou "Inativo".</returns>
        public static string GerarEstado(Aviao aviao)
        {
            if (aviao.Estado)
            {
                return $"Ativo";
            }
            else
            {
                return $"Inativo";
            }
        }

        /// <summary>
        /// Verifica se um modelo de avião pode ser eliminado com base no histórico e agendamento de voos.
        /// </summary>
        /// <param name="voos">Lista de voos existentes.</param>
        /// <param name="avioes">Lista de aviões existentes.</param>
        /// <param name="aviao">O avião cujo modelo será validado para eliminação.</param>
        /// <returns>True se o modelo puder ser eliminado, caso contrário retorna false.</returns>
        public static bool ValidarEliminacaoModelo(List<Voo> voos, List<Aviao> avioes, Aviao aviao)
        {
            // se o modelo foi usado em qualquer voo passado, não pode eliminar
            bool foiUsado = voos.Any(v => v.Aviao.Modelo == aviao.Modelo && v.DataPartida <= DateTime.Now);

            if (foiUsado)
                return false;

            // se ainda existem voos futuros com esse modelo, não foi substituído
            bool aindaVaiSerUsado = voos.Any(v => v.Aviao.Modelo == aviao.Modelo && v.DataPartida > DateTime.Now);

            if (aindaVaiSerUsado)
                return false;

            return true;
        }
    }
}
