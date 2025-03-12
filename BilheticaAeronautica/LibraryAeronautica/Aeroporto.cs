namespace LibraryAeronautica
{
    /// <summary>
    /// Representa um aeroporto.
    /// </summary>
    public class Aeroporto
    {
        /// <summary>
        /// O código do aeroporto (ex: Lisboa).
        /// </summary>
        public string IATA { get; set; }

        /// <summary>
        /// O nome do aeroporto.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// A cidade onde o aeroporto está localizado.
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// O país onde o aeroporto está localizado.
        /// </summary>
        public string Pais { get; set; }
    }
}
