using NewBlackJack.Enums;

namespace NewBlackJack.Models
{
    public class Inventario
    {
        public List<BaralhoEnums.ETipoSkinBaralho> BaralhosComprados { get; set; } = new();
    }
}
