using RotasREST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRotas
{
    public class Rotas : BaseService, IRotas
    {
        private static readonly string _uri = "https://localhost:7036";

        public Rotas() : base(_uri)
        {

        }

        public RetornoRotasModel ConsultarRotaMaisBarata(FiltroRotasModel filtroRotas)
        {
            string request = string.Format(@"/ConsultaRotas/{0}/{1}", filtroRotas.Partida, filtroRotas.Destino);

            var retorno = Get<RetornoRotasModel>(request);

            return retorno;
        }
    }
}
