namespace LibraryAeronautica.Modelos
{
    /// <summary>
    /// Representa um cliente.
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// O identificador único do cliente.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// O número do passaporte do cliente.
        /// </summary>
        public string Passaporte { get; set; }

        /// <summary>
        /// O nome completo do cliente.
        /// </summary>
        public string NomeCompleto { get; set; }

        /// <summary>
        /// O email do cliente.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// O telefone do cliente.
        /// </summary>
        public string Telefone { get; set; }

    }
}
