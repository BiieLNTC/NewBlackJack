
using System.ComponentModel;

namespace NewBlackJack.Enums
{
    public class BaralhoEnums
    {
        public enum ETipoCompra
        {
            Comprar = 1,
            Dobrar = 2,
        }

        public enum ETipoSkinBaralho
        {
            [Description("Baralho Padrão")]
            Padrao = 1,

            [Description("Baralho Medieval")]
            Medieval = 2,

            [Description("Baralho Aquarela")]
            Aquarela = 3,

            [Description("Baralho Cartoon")]
            Cartoon = 4,

            [Description("Baralho Desenhado")]
            Desenhado = 5
        }
    }
}
