using GCS.VisuCifras3.Modelos.Classes.DTO;

namespace GCS.VisuCifras3.Modelos.Interfaces.Dados
{
    public interface IRepositorioCifras
    {
        List<string> ObterTodasIniciaisLetraTitulo();
        //List<DTOCifra> ObterTodasCifras();
        //List<DTOCifra> ObterCifrasPorArtista(string artista);
        //List<DTOCifra> ObterCifrasPorInicialLetraTitulo(string titulo);
        //DTOCifra ObterCifraPorId(int id);
    }
}
