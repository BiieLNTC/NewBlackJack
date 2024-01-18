using NewBlackJack.Dtos;
using static NewBlackJack.Listas.ListaModelosBaralho;

namespace NewBlackJack.Services.Interfaces
{
    public interface IBaralhoService
    {
        Task<string> ObterBaralho();
        Task<List<CartaDto>> ObterCartas(int qntdCarta, string baralhoId, List<ModeloBaralho> baralhoSkin);
    }
}
