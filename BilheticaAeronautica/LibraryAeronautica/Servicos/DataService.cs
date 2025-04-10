using LibraryAeronautica.Enums;
using LibraryAeronautica.Modelos;

namespace LibraryAeronautica.Servicos
{
    /// <summary>
    /// Serviço responsável por gravar e ler os dados nos ficheiro de texto.
    /// </summary>
    public static class DataService
    {
        public static string Mensagem { get; private set; } = string.Empty;

        /// <summary>
        /// Guarda a lista de aeroportos no ficheiro indicado.
        /// </summary>
        /// <param name="aeroportos">Lista de aeroportos a guardar.</param>
        /// <param name="ficheiro">Caminho do ficheiro de destino.</param>
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


        ///<summary>
        /// Lê e retorna a lista de aeroportos de um ficheiro.
        /// </summary>
        /// <param name="ficheiro">Caminho do ficheiro a ler.</param>
        /// <returns>Lista de aeroportos carregada.</returns>
        /// 
        public static List<Aeroporto> ObterAeroportos(string ficheiro)
        {
            List<Aeroporto> aeroportos = new List<Aeroporto>();

            try
            {
                using StreamReader sr = File.OpenText(ficheiro);
                string linha;

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split(',');

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

            return aeroportos;
        }       

        /// <summary>
        /// Guarda a lista de aviões no ficheiro indicado.
        /// </summary>
        /// <param name="avioes">Lista de aviões a guardar.</param>
        /// <param name="ficheiro">Caminho do ficheiro de destino.</param>
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
                    string linha = $"{aviao.Id},{aviao.Modelo},{aviao.Estado},{aviao.LugaresExecutivos},{aviao.LugaresEconomicos}";

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

        /// <summary>
        /// Lê e retorna a lista de aviões de um ficheiro.
        /// </summary>
        /// <param name="ficheiro">Caminho do ficheiro a ler.</param>
        /// <returns>Lista de aviões carregada.</returns>
        public static List<Aviao> ObterAvioes(string ficheiro)
        {
            List<Aviao> avioes = new List<Aviao>();

            try
            {
                using StreamReader sr = File.OpenText(ficheiro);
                string linha;

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split(',');

                    Aviao aviao = new Aviao
                    {
                        Id = Convert.ToInt32(campos[0]),
                        Modelo = campos[1],
                        Estado = bool.Parse(campos[2]),
                        LugaresExecutivos = Convert.ToInt32(campos[3]),
                        LugaresEconomicos = Convert.ToInt32(campos[4]),
                        Lugares = new List<Lugar>()
                    };

                    for (int i = 5; i < campos.Length; i += 4)
                    {
                        Lugar lugar = new Lugar
                        {
                            Fila = Convert.ToInt32(campos[i]),
                            Letra = campos[i + 1],
                            Tipo = (TipoLugar)Enum.Parse(typeof(TipoLugar), campos[i + 2]),
                            Disponivel = bool.Parse(campos[i + 3]),
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

            return avioes;
        }

        /// <summary>
        /// Guarda a lista de voos no ficheiro indicado.
        /// </summary>
        /// <param name="voos">Lista de voos a guardar.</param>
        /// <param name="ficheiro">Caminho do ficheiro de destino.</param>
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
                        $"{voo.HoraPartida:hh\\:mm\\:ss}|" +
                        $"{voo.Duracao:hh\\:mm\\:ss}";

                    if (voo.Bilhetes != null && voo.Bilhetes.Count > 0)
                    {
                        foreach (Bilhete bilhete in voo.Bilhetes)
                        {
                            string clienteId = bilhete.Cliente != null ? bilhete.Cliente.Id.ToString() : "0";
                            string metPagamento = bilhete.MetodoPagamento != null ? bilhete.MetodoPagamento.ToString() : "Não Vendido";

                            linha += $"|{bilhete.Id}|{bilhete.Lugar.Nome}|{bilhete.Valor}|{bilhete.Lugar.Disponivel}|{bilhete.Voo.Id}|{clienteId}|{metPagamento}";
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

        /// <summary>
        /// Lê e retorna a lista de voos de um ficheiro.
        /// </summary>
        /// <param name="ficheiro">Caminho do ficheiro a ler.</param>
        /// <param name="avioes">Lista de aviões existente no sistema.</param>
        /// <param name="aeroportos">Lista de aeroportos existente no sistema.</param>
        /// <param name="clientes">Lista de clientes existente no sistema.</param>
        /// <returns>Lista de voos carregada.</returns>
        public static List<Voo> ObterVoos(string ficheiro, List<Aviao> avioes, List<Aeroporto> aeroportos, List<Cliente> clientes)
        {
            List<Voo> voos = new List<Voo>();

            try
            {
                using StreamReader sr = File.OpenText(ficheiro);
                string linha;

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
                    TimeSpan.TryParse(campos[6], out TimeSpan horaPartida);
                    TimeSpan.TryParse(campos[7], out TimeSpan duracao);

                    DateTime dataHoraPartida = dataPartida.Add(horaPartida);

                    Voo voo = new Voo
                    {
                        Id = Convert.ToInt32(campos[0]),
                        NumeroVoo = campos[1],
                        Aviao = aviao,
                        Origem = origem,
                        Destino = destino,
                        DataPartida = dataHoraPartida,
                        HoraPartida = horaPartida,
                        Duracao = duracao,
                        Bilhetes = new List<Bilhete>()
                    };

                    if (aviao != null)
                    {
                        ProcessarBilhetes(voo, campos, clientes);

                        voos.Add(voo);
                    }
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Mensagem = e.Message;
            }

            return voos;
        }

        /// <summary>
        /// Processa os bilhetes para um voo, atribuindo lugares e clientes com base nos dados fornecidos.
        /// </summary>
        /// <param name="voo">O voo ao qual os bilhetes serão associados.</param>
        /// <param name="campos">Um array contendo os dados dos bilhetes, como ID, lugar, valor, disponibilidade e ID do cliente.</param>
        /// <param name="clientes">A lista de clientes disponíveis para associar aos bilhetes.</param>
        private static void ProcessarBilhetes(Voo voo, string[] campos, List<Cliente> clientes)
        {
            for (int i = 8; i < campos.Length; i += 7)
            {
                Lugar lugar = voo.Aviao.Lugares.FirstOrDefault(l => l.Nome == campos[i + 1]);

                if (lugar != null)
                {
                    int idCliente = Convert.ToInt32(campos[i + 5]);
                    Cliente cliente = clientes.FirstOrDefault(c => c.Id == idCliente);

                    Lugar lugarVoo = new Lugar
                    {
                        Fila = lugar.Fila,
                        Letra = lugar.Letra,
                        Tipo = lugar.Tipo,
                        Disponivel = Convert.ToBoolean(campos[i + 3]) // Recupera o estado de disponibilidade
                    };

                    string metPagamento = campos[i + 6];
                    MetodoPagamento? metodoPagamento = metPagamento == "Não Vendido" ? null : (MetodoPagamento)Enum.Parse(typeof(MetodoPagamento), metPagamento);

                    Bilhete bilhete = new Bilhete
                    {
                        Id = Convert.ToInt32(campos[i]),
                        Lugar = lugarVoo,
                        Valor = Convert.ToDecimal(campos[i + 2]),
                        Voo = voo,
                        Cliente = cliente,
                        MetodoPagamento = metodoPagamento
                    };

                    voo.Bilhetes.Add(bilhete);
                }
            }
        }
        
        /// <summary>
        /// Guarda a lista de clientes no ficheiro indicado.
        /// </summary>
        /// <param name="clientes">Lista de clientes a guardar.</param>
        /// <param name="ficheiro">Caminho do ficheiro de destino.</param>
        public static void SalvarClientes(List<Cliente> clientes, string ficheiro)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ficheiro, false);

                if (!File.Exists(ficheiro))
                {
                    sw = File.CreateText(ficheiro);
                }

                foreach (Cliente cliente in clientes)
                {
                    string linha = $"{cliente.Id},{cliente.NomeCompleto},{cliente.Passaporte},{cliente.Email},{cliente.Telefone}";

                    sw.WriteLine(linha);
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Mensagem = e.Message;
            }
        }

        /// <summary>
        /// Lê e retorna a lista de clientes de um ficheiro.
        /// </summary>
        /// <param name="ficheiro">Caminho do ficheiro a ler.</param>
        /// <returns>Lista de clientes carregada.</returns>
        public static List<Cliente> ObterClientes(string ficheiro)
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                using StreamReader sr = File.OpenText(ficheiro);
                string linha;

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split(',');

                    clientes.Add(new Cliente
                    {
                        Id = Convert.ToInt32(campos[0]),
                        NomeCompleto = campos[1],
                        Passaporte = campos[2],
                        Email = campos[3],
                        Telefone = campos[4],
                    });
                }
            }
            catch (Exception e)
            {
                Mensagem = e.Message;
            }

            return clientes;
        }     
    }
}



