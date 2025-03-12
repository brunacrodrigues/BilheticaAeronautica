using LibraryAeronautica.Enums;

namespace LibraryAeronautica
{
    public class Bilhete
    {
        public int Id { get; set; }
        public  Voo Voo { get; set; }
        public Lugar Lugar { get; set; }
        public decimal Valor { get; set; }
        public Cliente Cliente { get; set; }

    }
}
