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

        ///// <summary>
        ///// A capacidade total do avião.
        ///// </summary>
        //public int Capacidade
        //{
        //    get
        //    {
        //        if (Lugares != null)
        //        {
        //            return Lugares.Count;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //}

        public int FilasExecutivas { get; set; }
        public int FilasEconomicas { get; set; }
        public int LugaresPorFila { get; set; }

        //public override string ToString()
        //{
        //    return $"{Modelo}";
        //}

        /// <summary>
        /// Gera os lugares no avião com base no número de filas executivas, filas económicas e lugares em cada fila.
        /// </summary>
        /// <param name="filasExecutivas"></param>
        /// <param name="filasEconomicas"></param>
        /// <param name="lugaresPorFila"></param>
        //public void GerarLugares()
        //{
        //    Lugares = new List<Lugar>();
        //    const string letrasLugares = "ABCDEFGHIJ"; //Máximo 10 lugares por fila

        //    // Gerar os lugares para as filas executivas
        //    for (int fila = 1; fila <= FilasExecutivas; fila++)
        //    {
        //        for (int lugar = 0; lugar < LugaresPorFila; lugar++)
        //        {
        //            Lugar novoLugar = new Lugar
        //            {
        //                Fila = fila.ToString(),
        //                Letra = letrasLugares[lugar].ToString(),
        //                Tipo = TipoLugar.Executivo,
        //                Disponivel = true,
        //            };

        //            Lugares.Add(novoLugar);
        //        }
        //    }            

        //    // Gerar os lugares para as filas económicas
        //    for (int fila = FilasExecutivas + 1; fila <= FilasExecutivas + FilasEconomicas; fila++)
        //    {
        //        for (int lugar = 0; lugar < LugaresPorFila; lugar ++)
        //        {
        //            Lugar novoLugar = new Lugar
        //            {
        //                Fila = fila.ToString(),
        //                Letra = letrasLugares[lugar].ToString(),
        //                Tipo = TipoLugar.Economico,
        //                Disponivel = true,
        //            };

        //            Lugares.Add(novoLugar);
        //        }
        //    }
        //}

        public string GerarEstado()
        {
            if (Estado)
            {
                return $"Ativo";
            }
            else
            {
                return $"Inativo";
            }
        }



    }
}
