using GCS.VisuCifras3.Modelos.Classes.DTO;

namespace GCS.VisuCifras3.Client.Modelos.Classes.Dados.BD
{
    public static class BDCifras
    {
        private readonly static HashSet<DTOCifra> _cifras = new()
        {
            new DTOCifra(1, "Cifra 1", "Artista 1", "Conteúdo da Cifra 2", "Letra A", "http://", DateTime.Now),
            new DTOCifra(2, "A Cifra 2", "Artista 2", "Conteúdo da Cifra 2", "Letra 2", "http://", DateTime.Now),
            new DTOCifra(3, "Cifra 3", "Artista 3", "Conteúdo da Cifra 3", "Letra 3", "http://", DateTime.Now),
            // Adicione mais cifras conforme necessário
        };

        public static IReadOnlySet<DTOCifra> Cifras => _cifras;

    }
}
