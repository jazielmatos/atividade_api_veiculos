using atividade_api_web.Models;

namespace atividade_api_web.Servicos
{
    public class VeiculoRepositorio
    {
        private VeiculoRepositorio()
        {
            Lista = new List<Veiculo>();
        }

        public List<Veiculo> Lista = default!;
        private static VeiculoRepositorio? veiculoRepositorio;

        public static VeiculoRepositorio Instancia()
        {
            if (veiculoRepositorio is null) veiculoRepositorio = new VeiculoRepositorio();
            return veiculoRepositorio;
        }
    }
}
