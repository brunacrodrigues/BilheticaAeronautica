namespace LibraryAeronautica.Modelos
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
        /// O número do voo (ex.: VA1234).
        /// </summary>
        public string NumeroVoo { get; set; }

        /// <summary>
        /// O avião associado ao voo.
        /// </summary>
        public Aviao Aviao { get; set; }

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
        /// A hora de partida do voo.
        /// </summary>
        public TimeSpan HoraPartida { get; set; }

        /// <summary>
        /// A duração do voo.
        /// </summary>
        public TimeSpan Duracao { get; set; }


        /// <summary>
        /// Os bilhetes comprados para o voo.
        /// </summary>
        public List<Bilhete> Bilhetes { get; set; }

        /// <summary>
        /// O código IATA do aeroporto de origem e de destino do voo.
        /// </summary>
        public string Viagem
        {
            get
            {
                return $"{Origem.IATA} -> {Destino.IATA}";
            }
        }
        public override string ToString()
        {
            return $"{NumeroVoo} ({Aviao.Modelo}) - {Origem.IATA} -> {Destino.IATA} - {DataPartida:dd/MM/yyyy} {HoraPartida.ToString(@"hh\:mm")}";
        }


    }

}
