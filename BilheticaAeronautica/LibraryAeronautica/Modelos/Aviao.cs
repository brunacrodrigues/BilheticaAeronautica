using LibraryAeronautica.Enums;

namespace LibraryAeronautica.Modelos
{
    /// <summary>
    /// Representa um avião.
    /// </summary>
    public class Aviao
    {
        /// <summary>
        /// O identificador único do avião.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// O modelo do avião.
        /// </summary>
        public string Modelo { get; set; }

        /// <summary>
        /// O estado do avião (Ativo ou Inativo).
        /// </summary>
        public bool Estado { get; set; }

        /// <summary>
        /// Os lugares do avião.
        /// </summary>
        public List<Lugar> Lugares { get; set; }

        /// <summary>
        /// O número de lugares executivos do avião.
        /// </summary>
        public int LugaresExecutivos { get; set; }

        /// <summary>
        /// O número de lugares económicos do avião.
        /// </summary>
        public int LugaresEconomicos { get; set; }

       

        



    }
}
