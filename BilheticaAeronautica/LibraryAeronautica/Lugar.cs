using LibraryAeronautica.Enums;

namespace LibraryAeronautica
{
    /// <summary>
    /// Representa um lugar no avião.
    /// </summary>
    public class Lugar
    {
        /// <summary>
        /// O número do lugar.
        /// </summary>
        public string Numero { get; set; }

        /// <summary>
        /// A fila onde o lugar se encontra.
        /// </summary>
        public string Fila { get; set; }

        /// <summary>
        /// O tipo de lugar (Económico ou Executivo).
        /// </summary>
        public TipoLugar Tipo { get; set; }

        /// <summary>
        /// A disponibilidade do lugar.
        /// </summary>
        public bool Disponivel { get; set; }
    }
}
