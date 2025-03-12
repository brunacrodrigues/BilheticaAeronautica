using LibraryAeronautica.Enums;

namespace LibraryAeronautica
{
    public class Aviao
    {
        public int Id { get; set; }
        public  string Marca { get; set; }
        public string Modelo { get; set; }
        
        public bool Estado { get; set; }
        public List<Lugar> Lugares { get; set; }
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
