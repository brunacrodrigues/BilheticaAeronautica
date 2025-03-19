using LibraryAeronautica.Enums;
using LibraryAeronautica.Modelos;

namespace LibraryAeronautica.Servicos
{
    public static class DataService
    {
        public static string Mensagem { get; private set; } = string.Empty;

        public static void SalvarAeroportos(List<Aeroporto> aeroportos, string ficheiro)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ficheiro, false);

                if (!File.Exists(ficheiro))
                {
                    sw = File.CreateText(ficheiro);
                }

                foreach (Aeroporto aeroporto in aeroportos)
                {
                    string linha = $"{aeroporto.Id},{aeroporto.IATA},{aeroporto.Nome},{aeroporto.Cidade},{aeroporto.Pais}";

                    sw.WriteLine(linha);
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Mensagem = e.Message;
            }
        }

        public static void ObterAeroportos(List<Aeroporto> aeroportos, string ficheiro)
        {
            try
            {
                StreamReader sr = File.OpenText(ficheiro);

                string linha = string.Empty;

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split(",");

                    aeroportos.Add(new Aeroporto
                    {
                        Id = Convert.ToInt32(campos[0]),
                        IATA = campos[1],
                        Nome = campos[2],
                        Cidade = campos[3],
                        Pais = campos[4],
                    });
                }
            }
            catch (Exception e)
            {
                Mensagem = e.Message;
            }
}

        public static void SalvarAvioes(List<Aviao> avioes, string ficheiro)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ficheiro, false);

                if (!File.Exists(ficheiro))
                {
                    sw = File.CreateText(ficheiro);
                }

                foreach (Aviao aviao in avioes)
                {
                    string linha = $"{aviao.Id},{aviao.Modelo},{aviao.Estado},{aviao.LugaresPorFila},{aviao.FilasExecutivas}, {aviao.FilasEconomicas}";

                    foreach (Lugar lugar in aviao.Lugares)
                    {
                        linha += $",{lugar.Fila},{lugar.Letra},{lugar.Tipo},{lugar.Disponivel}";
                    }

                    sw.WriteLine(linha);
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Mensagem = e.Message;
            }
        }

        public static void ObterAvioes(List<Aviao> avioes, string ficheiro)
        {
            try
            {
                StreamReader sr = File.OpenText(ficheiro);

                string linha = string.Empty;

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split(",");

                    Aviao aviao = new Aviao
                    {
                        Id = Convert.ToInt32(campos[0]),
                        Modelo = campos[1],
                        Estado = bool.Parse(campos[2]),
                        LugaresPorFila = Convert.ToInt32(campos[3]),
                        FilasExecutivas = Convert.ToInt32(campos[4]),
                        FilasEconomicas = Convert.ToInt32(campos[5]),
                        Lugares = new List<Lugar>(),
                    };

                    for (int i = 6; i < campos.Length; i += 4)
                    {
                        Lugar lugar = new Lugar
                        {
                            Fila = campos[i],
                            Letra = campos[i + 1],
                            Tipo = (TipoLugar)Enum.Parse(typeof(TipoLugar), campos[i + 2]),
                            Disponivel = bool.Parse(campos[i + 3])
                        };
                        aviao.Lugares.Add(lugar);
                    }

                    avioes.Add(aviao);
                }
            }
            catch (Exception e)
            {
                Mensagem = e.Message;
            }
}

        public static void SalvarVoos(List<Voo> voos, string ficheiro)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ficheiro, false);

                if (!File.Exists(ficheiro))
                {
                    sw = File.CreateText(ficheiro);
                }

                foreach (Voo voo in voos)
                {
                    string linha = $"{voo.Id}|{voo.NumeroVoo}|{voo.Aviao.Id}|" +
                        $"{voo.Origem.Id}|{voo.Destino.Id}|" +
                        $"{voo.DataPartida:dd/MM/yyyy}|" +
                        $"{voo.HoraPartida:HH:mm:ss}|" +
                        $"{voo.Duracao}";

                    if (voo.Bilhetes != null)
                    {
                        foreach (Bilhete bilhete in voo.Bilhetes)
                        {
                            linha += $",{bilhete.Id},{bilhete.Voo.Id},{bilhete.Lugar.Nome},{bilhete.Valor}";
                        }

                    }
                    sw.WriteLine(linha);
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Mensagem = e.Message;
            }
        }

        public static void ObterVoos(List<Voo> voos, List<Aviao> avioes, List<Aeroporto> aeroportos, string ficheiro)
        {
            try
            {
                StreamReader sr = File.OpenText(ficheiro);

                string linha = string.Empty;

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split("|");

                    int aviaoId = Convert.ToInt32(campos[2]);
                    int origemId = Convert.ToInt32(campos[3]);
                    int destinoId = Convert.ToInt32(campos[4]);

                    Aviao aviao = avioes.FirstOrDefault(a => a.Id == aviaoId);
                    Aeroporto origem = aeroportos.FirstOrDefault(a => a.Id == origemId);
                    Aeroporto destino = aeroportos.FirstOrDefault(a => a.Id == destinoId);

                    DateTime.TryParse(campos[5], out DateTime dataPartida);
                    DateTime.TryParse(campos[6], out DateTime horaPartida);
                    TimeSpan.TryParse(campos[7], out TimeSpan duracao);

                    Voo voo = new Voo
                    {
                        Id = Convert.ToInt32(campos[0]),
                        NumeroVoo = campos[1],
                        Aviao = aviao,
                        Origem = origem,
                        Destino = destino,
                        DataPartida = dataPartida,
                        HoraPartida = horaPartida,
                        Duracao = duracao,
                        Bilhetes = new List<Bilhete>(),
                    };

                    if (campos.Length > 8)
                    {
                        for (int i = 8; i < campos.Length; i += 4)
                        {
                            Lugar lugar = aviao.Lugares.FirstOrDefault(l => l.Nome == campos[i + 2]);
                            if (lugar == null)
                            {
                                Mensagem = "Lugar não encontrado.";
                                continue;
                            }

                            Bilhete bilhete = new Bilhete
                            {
                                Id = Convert.ToInt32(campos[i]),
                                Voo = voo,
                                Lugar = lugar,
                                Valor = Convert.ToDecimal(campos[i + 3])
                            };
                            voo.Bilhetes.Add(bilhete);
                        }
                    }

                    voos.Add(voo);
                }
            }
            catch (Exception e)
            {
                Mensagem = e.Message;
            }
        }
    }           
}


