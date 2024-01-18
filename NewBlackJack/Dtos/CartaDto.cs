namespace NewBlackJack.Dtos
{
    public class CartaDto
    {
        public string Code { get; set; }        
        public string Image { get; set; }
        public ImagesDto Images { get; set; }
        public string Value { get; set; }
        public string Suit { get; set; }
    }

    public class ImagesDto
    {
        public string Svg { get; set; }
        public string Png { get; set; }
    }
}
