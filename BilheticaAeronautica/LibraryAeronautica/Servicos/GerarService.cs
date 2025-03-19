using LibraryAeronautica.Enums;
using LibraryAeronautica.Modelos;

namespace LibraryAeronautica.Servicos
{
    public class GerarService
    {        
        public static string GerarNumeroVoo()
        {
            string sigla = "TP";
            Random random = new Random();
            int numero = random.Next(100, 9999);

            return $"{sigla}{numero}";  
        }

        public static void GerarLugaresAviao(Aviao aviao)
        {
            List<Lugar> lugares = new List<Lugar>();

            const string letrasLugares = "ABCDEFGHIJ"; //Máximo 10 lugares por fila

            // Gerar os lugares para as filas executivas
            for (int fila = 1; fila <= aviao.FilasExecutivas; fila++)
            {
                for (int lugar = 0; lugar < aviao.LugaresPorFila; lugar++)
                {
                    Lugar novoLugar = new Lugar
                    {
                        Fila = fila.ToString(),
                        Letra = letrasLugares[lugar].ToString(),
                        Tipo = TipoLugar.Executivo,
                        Disponivel = true,
                    };

                    lugares.Add(novoLugar);
                }
            }

            // Gerar os lugares para as filas económicas
            for (int fila = aviao.FilasExecutivas + 1; fila <= aviao.FilasExecutivas + aviao.FilasEconomicas; fila++)
            {
                for (int lugar = 0; lugar < aviao.LugaresPorFila; lugar++)
                {
                    Lugar novoLugar = new Lugar
                    {
                        Fila = fila.ToString(),
                        Letra = letrasLugares[lugar].ToString(),
                        Tipo = TipoLugar.Economico,
                        Disponivel = true,
                    };

                    lugares.Add(novoLugar);
                }
            }

            aviao.Lugares = lugares;
        }
    }
}
