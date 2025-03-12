using LibraryAeronautica.Enums;

namespace LibraryAeronautica
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
        /// A marca do avião.
        /// </summary>
        public  string Marca { get; set; }

        /// <summary>
        /// O modelo do avião.
        /// </summary>
        public string Modelo { get; set; }
        
        /// <summary>
        /// O estado do avião (Ativo ou Inativo).
        /// </summary>
        public bool Estado { get; set; }

        /// <summary>
        /// Os luagres do avião.
        /// </summary>
        public List<Lugar> Lugares { get; set; }

        /// <summary>
        /// A capacidade total do avião.
        /// </summary>
        public int Capacidade
        {
            get
            {
                if (Lugares != null)
                {
                    return Lugares.Count;
                }
                else
                {
                    return 0;
                }
            }
        }
        
    }
}
