namespace LibraryAeronautica
{
    /// <summary>
    /// Representa um voo.
    /// </summary>
    public class Voo
    {
        /// <summary>
        /// O identificador único do voo.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// O número do voo (ex.: TP1234).
        /// </summary>
        public string NumeroVoo { get; set; }

        /// <summary>
        /// O aeroporto de destino.
        /// </summary>
        public Aeroporto Destino { get; set; }

        /// <summary>
        /// O aeroporto de origem.
        /// </summary>
        public Aeroporto Origem { get; set; }

        /// <summary>
        /// A data e hora de partida.
        /// </summary>
        public DateTime DataPartida { get; set; }

        /// <summary>
        /// A data e hora de chegada.
        /// </summary>
        public DateTime DataChegada { get; set; }

        /// <summary>
        /// O avião associado ao voo.
        /// </summary>
        public Aviao Aviao { get; set; }

        /// <summary>
        /// Os bilhetes comprados para o voo.
        /// </summary>
        public List<Bilhete> Bilhetes { get; set; }
    }
}
