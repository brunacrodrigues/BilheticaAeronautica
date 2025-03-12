using LibraryAeronautica.Enums;

namespace LibraryAeronautica
{
    public class Lugar
    {
        public string Numero { get; set; }
        public string Fila { get; set; }
        public ClasseLugar Classe { get; set; }
        public bool Disponivel { get; set; }
    }
}
