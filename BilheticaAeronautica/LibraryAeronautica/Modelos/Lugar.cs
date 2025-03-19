using LibraryAeronautica.Enums;

namespace LibraryAeronautica.Modelos
{
    /// <summary>
    /// Representa um lugar no avião.
    /// </summary>
    public class Lugar
    {
        /// <summary>
        /// A fila /representada por um número) onde o lugar se encontra.
        /// </summary>
        public string Fila { get; set; }

        public string Letra { get; set; }


        /// <summary>
        /// O tipo de lugar (Económico ou Executivo).
        /// </summary>
        public TipoLugar Tipo { get; set; }

        /// <summary>
        /// A disponibilidade do lugar.
        /// </summary>
        public bool Disponivel { get; set; }

        public string Nome
        {
            get
            {
                return $"{Fila}{Letra}, {Tipo}";
            }
        }
    }
}
