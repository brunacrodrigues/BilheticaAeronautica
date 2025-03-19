using LibraryAeronautica.Enums;

namespace LibraryAeronautica.Modelos
{
    /// <summary>
    /// Representa um bilhete.
    /// </summary>
    public class Bilhete
    {
        /// <summary>
        /// O identificador único do bilhete.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// O voo associado ao bilhete.
        /// </summary>
        public Voo Voo { get; set; }

        /// <summary>
        /// O lugar associado ao bilhete.
        /// </summary>
        public Lugar Lugar { get; set; }

        /// <summary>
        /// O valor do bilhete.
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// O cliente associado ao bilhete.
        /// </summary>
        public Cliente Cliente { get; set; }     


    }
}
