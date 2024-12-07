using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRotas
{
    public class RetornoRotasModel
    {
        public string? Partida { get; set; }
        public string? Parada1 { get; set; }
        public string? Parada2 { get; set; }
        public string? Parada3 { get; set; }
        public string? Destino { get; set; }
        public int Valor { get; set; }

        public string _Partida { get { return Partida != "" ? $"{Partida} - " : ""; } }
        public string _Parada1 { get { return Parada1 != "" ? $"{Parada1} - " : ""; } }
        public string _Parada2 { get { return Parada2 != "" ? $"{Parada2} - " : ""; } }
        public string _Parada3 { get { return Parada3 != "" ? $"{Parada3} - " : ""; } }
        public string _Destino { get { return Destino != "" ? $"{Destino}" : ""; } }

    }
}
