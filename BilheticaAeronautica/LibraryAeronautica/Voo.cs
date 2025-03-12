namespace LibraryAeronautica
{
    public class Voo
    {
        public int Id { get; set; }
        public string NumeroVoo { get; set; }
        public Aeroporto Destino { get; set; }
        public Aeroporto Origem { get; set; }
        public DateTime DataPartida { get; set; }
        public DateTime DataChegada { get; set; }
        public Aviao Aviao { get; set; }
        public List<Bilhete> Bilhetes { get; set; }
    }
}
