


using RotasREST;

namespace ConsoleRotas
{
    public class Program : BaseService
    {
        static void Main(string[] args)
        {
            FiltroRotasModel filtroRotas = new FiltroRotasModel();

            Console.WriteLine("Informe o local de partida:");
            filtroRotas.Partida = Console.ReadLine();

            Console.WriteLine("Informe o local de destino:");
            filtroRotas.Destino = Console.ReadLine();

            Rotas rotas = new Rotas();

            var retorno = rotas.ConsultarRotaMaisBarata(filtroRotas);

            if (retorno != null)
            {
                string textRota = $"{retorno._Partida}{retorno._Parada1}{retorno._Parada2}{retorno._Parada3}{retorno._Destino}";

                Console.WriteLine("Melhor rota: {0} ao custo de R${1}", textRota, retorno.Valor);
            }
            {
                Console.WriteLine("Nenhuma rota encontrada para os parametros especificados.");
            }
        }
    }
}
