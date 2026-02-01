using GCS.VisuCifras3.Client.Modelos.Classes.Dados.BD;
using GCS.VisuCifras3.Modelos.Interfaces.Dados;

namespace GCS.VisuCifras3.Modelos.Classes.Dados.Repositorios
{
    public class RepositorioCifras : IRepositorioCifras
    {
        public List<string> ObterInicialLetraTitulo()
        {
            var l = BDCifras.Cifras
                .Select(cifra => cifra.Titulo.Substring(0, 1).ToUpper())
                .Distinct()
                .OrderBy(letra => letra)
                .ToList();

            return l;
        }
    }
}
