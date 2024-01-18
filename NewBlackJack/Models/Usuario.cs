using NewBlackJack.Enums;

namespace NewBlackJack.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int QntdFichas { get; set; }
        public BaralhoEnums.ETipoSkinBaralho BaralhoAtivo { get; set; }
        public DateTime UltimoLogin { get; set; }

        public Usuario Clone()
        {
            return (Usuario)MemberwiseClone();
        }
    }
}
