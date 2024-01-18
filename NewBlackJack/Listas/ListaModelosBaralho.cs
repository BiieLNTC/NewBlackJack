using NewBlackJack.Enums;

namespace NewBlackJack.Listas
{
    public class ListaModelosBaralho
    {
        public class ModeloBaralho
        {
            public string Codigo { get; set; }
            public string Imagem { get; set; }
        }

        private static List<ModeloBaralho> ListaBaralhoPadrao = new()
        {
            new ModeloBaralho {Codigo = "AS", Imagem="./Images/BaralhoPadrao/AS.png"},
            new ModeloBaralho {Codigo = "2S", Imagem="./Images/BaralhoPadrao/2S.png"},
            new ModeloBaralho {Codigo = "3S", Imagem="./Images/BaralhoPadrao/3S.png"},
            new ModeloBaralho {Codigo = "4S", Imagem="./Images/BaralhoPadrao/4S.png"},
            new ModeloBaralho {Codigo = "5S", Imagem="./Images/BaralhoPadrao/5S.png"},
            new ModeloBaralho {Codigo = "6S", Imagem="./Images/BaralhoPadrao/6S.png"},
            new ModeloBaralho {Codigo = "7S", Imagem="./Images/BaralhoPadrao/7S.png"},
            new ModeloBaralho {Codigo = "8S", Imagem="./Images/BaralhoPadrao/8S.png"},
            new ModeloBaralho {Codigo = "9S", Imagem="./Images/BaralhoPadrao/9S.png"},
            new ModeloBaralho {Codigo = "0S", Imagem="./Images/BaralhoPadrao/0S.png"},
            new ModeloBaralho {Codigo = "QS", Imagem="./Images/BaralhoPadrao/QS.png"},
            new ModeloBaralho {Codigo = "JS", Imagem="./Images/BaralhoPadrao/JS.png"},
            new ModeloBaralho {Codigo = "KS", Imagem="./Images/BaralhoPadrao/KS.png"},

            new ModeloBaralho {Codigo = "AC", Imagem="./Images/BaralhoPadrao/AC.png"},
            new ModeloBaralho {Codigo = "2C", Imagem="./Images/BaralhoPadrao/2C.png"},
            new ModeloBaralho {Codigo = "3C", Imagem="./Images/BaralhoPadrao/3C.png"},
            new ModeloBaralho {Codigo = "4C", Imagem="./Images/BaralhoPadrao/4C.png"},
            new ModeloBaralho {Codigo = "5C", Imagem="./Images/BaralhoPadrao/5C.png"},
            new ModeloBaralho {Codigo = "6C", Imagem="./Images/BaralhoPadrao/6C.png"},
            new ModeloBaralho {Codigo = "7C", Imagem="./Images/BaralhoPadrao/7C.png"},
            new ModeloBaralho {Codigo = "8C", Imagem="./Images/BaralhoPadrao/8C.png"},
            new ModeloBaralho {Codigo = "9C", Imagem="./Images/BaralhoPadrao/9C.png"},
            new ModeloBaralho {Codigo = "0C", Imagem="./Images/BaralhoPadrao/0C.png"},
            new ModeloBaralho {Codigo = "QC", Imagem="./Images/BaralhoPadrao/QC.png"},
            new ModeloBaralho {Codigo = "JC", Imagem="./Images/BaralhoPadrao/JC.png"},
            new ModeloBaralho {Codigo = "KC", Imagem="./Images/BaralhoPadrao/KC.png"},

            new ModeloBaralho {Codigo = "AH", Imagem="./Images/BaralhoPadrao/AH.png"},
            new ModeloBaralho {Codigo = "2H", Imagem="./Images/BaralhoPadrao/2H.png"},
            new ModeloBaralho {Codigo = "3H", Imagem="./Images/BaralhoPadrao/3H.png"},
            new ModeloBaralho {Codigo = "4H", Imagem="./Images/BaralhoPadrao/4H.png"},
            new ModeloBaralho {Codigo = "5H", Imagem="./Images/BaralhoPadrao/5H.png"},
            new ModeloBaralho {Codigo = "6H", Imagem="./Images/BaralhoPadrao/6H.png"},
            new ModeloBaralho {Codigo = "7H", Imagem="./Images/BaralhoPadrao/7H.png"},
            new ModeloBaralho {Codigo = "8H", Imagem="./Images/BaralhoPadrao/8H.png"},
            new ModeloBaralho {Codigo = "9H", Imagem="./Images/BaralhoPadrao/9H.png"},
            new ModeloBaralho {Codigo = "0H", Imagem="./Images/BaralhoPadrao/0H.png"},
            new ModeloBaralho {Codigo = "QH", Imagem="./Images/BaralhoPadrao/QH.png"},
            new ModeloBaralho {Codigo = "JH", Imagem="./Images/BaralhoPadrao/JH.png"},
            new ModeloBaralho {Codigo = "KH", Imagem="./Images/BaralhoPadrao/KH.png"},

            new ModeloBaralho {Codigo = "AD", Imagem="./Images/BaralhoPadrao/AD.png"},
            new ModeloBaralho {Codigo = "2D", Imagem="./Images/BaralhoPadrao/2D.png"},
            new ModeloBaralho {Codigo = "3D", Imagem="./Images/BaralhoPadrao/3D.png"},
            new ModeloBaralho {Codigo = "4D", Imagem="./Images/BaralhoPadrao/4D.png"},
            new ModeloBaralho {Codigo = "5D", Imagem="./Images/BaralhoPadrao/5D.png"},
            new ModeloBaralho {Codigo = "6D", Imagem="./Images/BaralhoPadrao/6D.png"},
            new ModeloBaralho {Codigo = "7D", Imagem="./Images/BaralhoPadrao/7D.png"},
            new ModeloBaralho {Codigo = "8D", Imagem="./Images/BaralhoPadrao/8D.png"},
            new ModeloBaralho {Codigo = "9D", Imagem="./Images/BaralhoPadrao/9D.png"},
            new ModeloBaralho {Codigo = "0D", Imagem="./Images/BaralhoPadrao/0D.png"},
            new ModeloBaralho {Codigo = "QD", Imagem="./Images/BaralhoPadrao/QD.png"},
            new ModeloBaralho {Codigo = "JD", Imagem="./Images/BaralhoPadrao/JD.png"},
            new ModeloBaralho {Codigo = "KD", Imagem="./Images/BaralhoPadrao/KD.png"},
        };

        private static List<ModeloBaralho> ListaBaralhoMedieval = new()
        {
            new ModeloBaralho {Codigo = "AS", Imagem="./Images/BaralhoMedieval/AceSpade.png"},
            new ModeloBaralho {Codigo = "2S", Imagem="./Images/BaralhoMedieval/2Spade.png"},
            new ModeloBaralho {Codigo = "3S", Imagem="./Images/BaralhoMedieval/3Spade.png"},
            new ModeloBaralho {Codigo = "4S", Imagem="./Images/BaralhoMedieval/4Spade.png"},
            new ModeloBaralho {Codigo = "5S", Imagem="./Images/BaralhoMedieval/5Spade.png"},
            new ModeloBaralho {Codigo = "6S", Imagem="./Images/BaralhoMedieval/6Spade.png"},
            new ModeloBaralho {Codigo = "7S", Imagem="./Images/BaralhoMedieval/7Spade.png"},
            new ModeloBaralho {Codigo = "8S", Imagem="./Images/BaralhoMedieval/8Spade.png"},
            new ModeloBaralho {Codigo = "9S", Imagem="./Images/BaralhoMedieval/9Spade.png"},
            new ModeloBaralho {Codigo = "0S", Imagem="./Images/BaralhoMedieval/10Spade.png"},
            new ModeloBaralho {Codigo = "QS", Imagem="./Images/BaralhoMedieval/QueenSpade.png"},
            new ModeloBaralho {Codigo = "JS", Imagem="./Images/BaralhoMedieval/JackSpade.png"},
            new ModeloBaralho {Codigo = "KS", Imagem="./Images/BaralhoMedieval/KingSpade.png"},

            new ModeloBaralho {Codigo = "AC", Imagem="./Images/BaralhoMedieval/AceClubs.png"},
            new ModeloBaralho {Codigo = "2C", Imagem="./Images/BaralhoMedieval/2Clubs.png"},
            new ModeloBaralho {Codigo = "3C", Imagem="./Images/BaralhoMedieval/3Clubs.png"},
            new ModeloBaralho {Codigo = "4C", Imagem="./Images/BaralhoMedieval/4Clubs.png"},
            new ModeloBaralho {Codigo = "5C", Imagem="./Images/BaralhoMedieval/5Clubs.png"},
            new ModeloBaralho {Codigo = "6C", Imagem="./Images/BaralhoMedieval/6Clubs.png"},
            new ModeloBaralho {Codigo = "7C", Imagem="./Images/BaralhoMedieval/7Clubs.png"},
            new ModeloBaralho {Codigo = "8C", Imagem="./Images/BaralhoMedieval/8Clubs.png"},
            new ModeloBaralho {Codigo = "9C", Imagem="./Images/BaralhoMedieval/9Clubs.png"},
            new ModeloBaralho {Codigo = "0C", Imagem="./Images/BaralhoMedieval/0Clubs.png"},
            new ModeloBaralho {Codigo = "QC", Imagem="./Images/BaralhoMedieval/QueenClubs.png"},
            new ModeloBaralho {Codigo = "JC", Imagem="./Images/BaralhoMedieval/JackClubs.png"},
            new ModeloBaralho {Codigo = "KC", Imagem="./Images/BaralhoMedieval/KingClubs.png"},

            new ModeloBaralho {Codigo = "AH", Imagem="./Images/BaralhoMedieval/AceHearts.png"},
            new ModeloBaralho {Codigo = "2H", Imagem="./Images/BaralhoMedieval/2Hearts.png"},
            new ModeloBaralho {Codigo = "3H", Imagem="./Images/BaralhoMedieval/3Hearts.png"},
            new ModeloBaralho {Codigo = "4H", Imagem="./Images/BaralhoMedieval/4Hearts.png"},
            new ModeloBaralho {Codigo = "5H", Imagem="./Images/BaralhoMedieval/5Hearts.png"},
            new ModeloBaralho {Codigo = "6H", Imagem="./Images/BaralhoMedieval/6Hearts.png"},
            new ModeloBaralho {Codigo = "7H", Imagem="./Images/BaralhoMedieval/7Hearts.png"},
            new ModeloBaralho {Codigo = "8H", Imagem="./Images/BaralhoMedieval/8Hearts.png"},
            new ModeloBaralho {Codigo = "9H", Imagem="./Images/BaralhoMedieval/9Hearts.png"},
            new ModeloBaralho {Codigo = "0H", Imagem="./Images/BaralhoMedieval/10Hearts.png"},
            new ModeloBaralho {Codigo = "QH", Imagem="./Images/BaralhoMedieval/QueenHearts.png"},
            new ModeloBaralho {Codigo = "JH", Imagem="./Images/BaralhoMedieval/JackHearts.png"},
            new ModeloBaralho {Codigo = "KH", Imagem="./Images/BaralhoMedieval/KingHearts.png"},

            new ModeloBaralho {Codigo = "AD", Imagem="./Images/BaralhoMedieval/AceDiam.png"},
            new ModeloBaralho {Codigo = "2D", Imagem="./Images/BaralhoMedieval/2Diam.png"},
            new ModeloBaralho {Codigo = "3D", Imagem="./Images/BaralhoMedieval/3Diam.png"},
            new ModeloBaralho {Codigo = "4D", Imagem="./Images/BaralhoMedieval/4Diam.png"},
            new ModeloBaralho {Codigo = "5D", Imagem="./Images/BaralhoMedieval/5Diam.png"},
            new ModeloBaralho {Codigo = "6D", Imagem="./Images/BaralhoMedieval/6Diam.png"},
            new ModeloBaralho {Codigo = "7D", Imagem="./Images/BaralhoMedieval/7Diam.png"},
            new ModeloBaralho {Codigo = "8D", Imagem="./Images/BaralhoMedieval/8Diam.png"},
            new ModeloBaralho {Codigo = "9D", Imagem="./Images/BaralhoMedieval/9Diam.png"},
            new ModeloBaralho {Codigo = "0D", Imagem="./Images/BaralhoMedieval/10Diam.png"},
            new ModeloBaralho {Codigo = "QD", Imagem="./Images/BaralhoMedieval/QueenDiam.png"},
            new ModeloBaralho {Codigo = "JD", Imagem="./Images/BaralhoMedieval/JackDiam.png"},
            new ModeloBaralho {Codigo = "KD", Imagem="./Images/BaralhoMedieval/KingDiam.png"},
        };

        private static List<ModeloBaralho> ListaBaralhoCartoon = new()
        {
            new ModeloBaralho {Codigo = "AS", Imagem="./Images/BaralhoCartoon/AceSpade.png"},
            new ModeloBaralho {Codigo = "2S", Imagem="./Images/BaralhoCartoon/2Spade.png"},
            new ModeloBaralho {Codigo = "3S", Imagem="./Images/BaralhoCartoon/3Spade.png"},
            new ModeloBaralho {Codigo = "4S", Imagem="./Images/BaralhoCartoon/4Spade.png"},
            new ModeloBaralho {Codigo = "5S", Imagem="./Images/BaralhoCartoon/5Spade.png"},
            new ModeloBaralho {Codigo = "6S", Imagem="./Images/BaralhoCartoon/6Spade.png"},
            new ModeloBaralho {Codigo = "7S", Imagem="./Images/BaralhoCartoon/7Spade.png"},
            new ModeloBaralho {Codigo = "8S", Imagem="./Images/BaralhoCartoon/8Spade.png"},
            new ModeloBaralho {Codigo = "9S", Imagem="./Images/BaralhoCartoon/9Spade.png"},
            new ModeloBaralho {Codigo = "0S", Imagem="./Images/BaralhoCartoon/10Spade.png"},
            new ModeloBaralho {Codigo = "QS", Imagem="./Images/BaralhoCartoon/QueenSpade.png"},
            new ModeloBaralho {Codigo = "JS", Imagem="./Images/BaralhoCartoon/JackSpade.png"},
            new ModeloBaralho {Codigo = "KS", Imagem="./Images/BaralhoCartoon/KingSpade.png"},

            new ModeloBaralho {Codigo = "AC", Imagem="./Images/BaralhoCartoon/AceClubs.png"},
            new ModeloBaralho {Codigo = "2C", Imagem="./Images/BaralhoCartoon/2Clubs.png"},
            new ModeloBaralho {Codigo = "3C", Imagem="./Images/BaralhoCartoon/3Clubs.png"},
            new ModeloBaralho {Codigo = "4C", Imagem="./Images/BaralhoCartoon/4Clubs.png"},
            new ModeloBaralho {Codigo = "5C", Imagem="./Images/BaralhoCartoon/5Clubs.png"},
            new ModeloBaralho {Codigo = "6C", Imagem="./Images/BaralhoCartoon/6Clubs.png"},
            new ModeloBaralho {Codigo = "7C", Imagem="./Images/BaralhoCartoon/7Clubs.png"},
            new ModeloBaralho {Codigo = "8C", Imagem="./Images/BaralhoCartoon/8Clubs.png"},
            new ModeloBaralho {Codigo = "9C", Imagem="./Images/BaralhoCartoon/9Clubs.png"},
            new ModeloBaralho {Codigo = "0C", Imagem="./Images/BaralhoCartoon/10Clubs.png"},
            new ModeloBaralho {Codigo = "QC", Imagem="./Images/BaralhoCartoon/QueenClubs.png"},
            new ModeloBaralho {Codigo = "JC", Imagem="./Images/BaralhoCartoon/JackClubs.png"},
            new ModeloBaralho {Codigo = "KC", Imagem="./Images/BaralhoCartoon/KingClubs.png"},

            new ModeloBaralho {Codigo = "AH", Imagem="./Images/BaralhoCartoon/AceHeart.png"},
            new ModeloBaralho {Codigo = "2H", Imagem="./Images/BaralhoCartoon/2Heart.png"},
            new ModeloBaralho {Codigo = "3H", Imagem="./Images/BaralhoCartoon/3Heart.png"},
            new ModeloBaralho {Codigo = "4H", Imagem="./Images/BaralhoCartoon/4Heart.png"},
            new ModeloBaralho {Codigo = "5H", Imagem="./Images/BaralhoCartoon/5Heart.png"},
            new ModeloBaralho {Codigo = "6H", Imagem="./Images/BaralhoCartoon/6Heart.png"},
            new ModeloBaralho {Codigo = "7H", Imagem="./Images/BaralhoCartoon/7Heart.png"},
            new ModeloBaralho {Codigo = "8H", Imagem="./Images/BaralhoCartoon/8Heart.png"},
            new ModeloBaralho {Codigo = "9H", Imagem="./Images/BaralhoCartoon/9Heart.png"},
            new ModeloBaralho {Codigo = "0H", Imagem="./Images/BaralhoCartoon/10Heart.png"},
            new ModeloBaralho {Codigo = "QH", Imagem="./Images/BaralhoCartoon/QueenHeart.png"},
            new ModeloBaralho {Codigo = "JH", Imagem="./Images/BaralhoCartoon/JackHeart.png"},
            new ModeloBaralho {Codigo = "KH", Imagem="./Images/BaralhoCartoon/KingHeart.png"},

            new ModeloBaralho {Codigo = "AD", Imagem="./Images/BaralhoCartoon/AceDiam.png"},
            new ModeloBaralho {Codigo = "2D", Imagem="./Images/BaralhoCartoon/2Diam.png"},
            new ModeloBaralho {Codigo = "3D", Imagem="./Images/BaralhoCartoon/3Diam.png"},
            new ModeloBaralho {Codigo = "4D", Imagem="./Images/BaralhoCartoon/4Diam.png"},
            new ModeloBaralho {Codigo = "5D", Imagem="./Images/BaralhoCartoon/5Diam.png"},
            new ModeloBaralho {Codigo = "6D", Imagem="./Images/BaralhoCartoon/6Diam.png"},
            new ModeloBaralho {Codigo = "7D", Imagem="./Images/BaralhoCartoon/7Diam.png"},
            new ModeloBaralho {Codigo = "8D", Imagem="./Images/BaralhoCartoon/8Diam.png"},
            new ModeloBaralho {Codigo = "9D", Imagem="./Images/BaralhoCartoon/9Diam.png"},
            new ModeloBaralho {Codigo = "0D", Imagem="./Images/BaralhoCartoon/10Diam.png"},
            new ModeloBaralho {Codigo = "QD", Imagem="./Images/BaralhoCartoon/QueenDiam.png"},
            new ModeloBaralho {Codigo = "JD", Imagem="./Images/BaralhoCartoon/JackDiam.png"},
            new ModeloBaralho {Codigo = "KD", Imagem="./Images/BaralhoCartoon/KingDiam.png"},
        };

        private static List<ModeloBaralho> ListaBaralhoAquarela = new()
        {
            new ModeloBaralho {Codigo = "AS", Imagem="./Images/BaralhoAquarela/AceSpade.png"},
            new ModeloBaralho {Codigo = "2S", Imagem="./Images/BaralhoAquarela/2Spade.png"},
            new ModeloBaralho {Codigo = "3S", Imagem="./Images/BaralhoAquarela/3Spade.png"},
            new ModeloBaralho {Codigo = "4S", Imagem="./Images/BaralhoAquarela/4Spade.png"},
            new ModeloBaralho {Codigo = "5S", Imagem="./Images/BaralhoAquarela/5Spade.png"},
            new ModeloBaralho {Codigo = "6S", Imagem="./Images/BaralhoAquarela/6Spade.png"},
            new ModeloBaralho {Codigo = "7S", Imagem="./Images/BaralhoAquarela/7Spade.png"},
            new ModeloBaralho {Codigo = "8S", Imagem="./Images/BaralhoAquarela/8Spade.png"},
            new ModeloBaralho {Codigo = "9S", Imagem="./Images/BaralhoAquarela/9Spade.png"},
            new ModeloBaralho {Codigo = "0S", Imagem="./Images/BaralhoAquarela/10Spade.png"},
            new ModeloBaralho {Codigo = "QS", Imagem="./Images/BaralhoAquarela/QueenSpade.png"},
            new ModeloBaralho {Codigo = "JS", Imagem="./Images/BaralhoAquarela/JackSpade.png"},
            new ModeloBaralho {Codigo = "KS", Imagem="./Images/BaralhoAquarela/KingSpade.png"},

            new ModeloBaralho {Codigo = "AC", Imagem="./Images/BaralhoAquarela/AceClubs.png"},
            new ModeloBaralho {Codigo = "2C", Imagem="./Images/BaralhoAquarela/2Clubs.png"},
            new ModeloBaralho {Codigo = "3C", Imagem="./Images/BaralhoAquarela/3Clubs.png"},
            new ModeloBaralho {Codigo = "4C", Imagem="./Images/BaralhoAquarela/4Clubs.png"},
            new ModeloBaralho {Codigo = "5C", Imagem="./Images/BaralhoAquarela/5Clubs.png"},
            new ModeloBaralho {Codigo = "6C", Imagem="./Images/BaralhoAquarela/6Clubs.png"},
            new ModeloBaralho {Codigo = "7C", Imagem="./Images/BaralhoAquarela/7Clubs.png"},
            new ModeloBaralho {Codigo = "8C", Imagem="./Images/BaralhoAquarela/8Clubs.png"},
            new ModeloBaralho {Codigo = "9C", Imagem="./Images/BaralhoAquarela/9Clubs.png"},
            new ModeloBaralho {Codigo = "0C", Imagem="./Images/BaralhoAquarela/10Clubs.png"},
            new ModeloBaralho {Codigo = "QC", Imagem="./Images/BaralhoAquarela/QueenClubs.png"},
            new ModeloBaralho {Codigo = "JC", Imagem="./Images/BaralhoAquarela/JackClubs.png"},
            new ModeloBaralho {Codigo = "KC", Imagem="./Images/BaralhoAquarela/KingClubs.png"},

            new ModeloBaralho {Codigo = "AH", Imagem="./Images/BaralhoAquarela/AceHearts.png"},
            new ModeloBaralho {Codigo = "2H", Imagem="./Images/BaralhoAquarela/2Hearts.png"},
            new ModeloBaralho {Codigo = "3H", Imagem="./Images/BaralhoAquarela/3Hearts.png"},
            new ModeloBaralho {Codigo = "4H", Imagem="./Images/BaralhoAquarela/4Hearts.png"},
            new ModeloBaralho {Codigo = "5H", Imagem="./Images/BaralhoAquarela/5Hearts.png"},
            new ModeloBaralho {Codigo = "6H", Imagem="./Images/BaralhoAquarela/6Hearts.png"},
            new ModeloBaralho {Codigo = "7H", Imagem="./Images/BaralhoAquarela/7Hearts.png"},
            new ModeloBaralho {Codigo = "8H", Imagem="./Images/BaralhoAquarela/8Hearts.png"},
            new ModeloBaralho {Codigo = "9H", Imagem="./Images/BaralhoAquarela/9Hearts.png"},
            new ModeloBaralho {Codigo = "0H", Imagem="./Images/BaralhoAquarela/10Hearts.png"},
            new ModeloBaralho {Codigo = "QH", Imagem="./Images/BaralhoAquarela/QueenHearts.png"},
            new ModeloBaralho {Codigo = "JH", Imagem="./Images/BaralhoAquarela/JackHearts.png"},
            new ModeloBaralho {Codigo = "KH", Imagem="./Images/BaralhoAquarela/KingHearts.png"},

            new ModeloBaralho {Codigo = "AD", Imagem="./Images/BaralhoAquarela/AceDiam.png"},
            new ModeloBaralho {Codigo = "2D", Imagem="./Images/BaralhoAquarela/2Diam.png"},
            new ModeloBaralho {Codigo = "3D", Imagem="./Images/BaralhoAquarela/3Diam.png"},
            new ModeloBaralho {Codigo = "4D", Imagem="./Images/BaralhoAquarela/4Diam.png"},
            new ModeloBaralho {Codigo = "5D", Imagem="./Images/BaralhoAquarela/5Diam.png"},
            new ModeloBaralho {Codigo = "6D", Imagem="./Images/BaralhoAquarela/6Diam.png"},
            new ModeloBaralho {Codigo = "7D", Imagem="./Images/BaralhoAquarela/7Diam.png"},
            new ModeloBaralho {Codigo = "8D", Imagem="./Images/BaralhoAquarela/8Diam.png"},
            new ModeloBaralho {Codigo = "9D", Imagem="./Images/BaralhoAquarela/9Diam.png"},
            new ModeloBaralho {Codigo = "0D", Imagem="./Images/BaralhoAquarela/10Diam.png"},
            new ModeloBaralho {Codigo = "QD", Imagem="./Images/BaralhoAquarela/QueenDiam.png"},
            new ModeloBaralho {Codigo = "JD", Imagem="./Images/BaralhoAquarela/JackDiam.png"},
            new ModeloBaralho {Codigo = "KD", Imagem="./Images/BaralhoAquarela/KingDiam.png"},
        };
        public static List<ModeloBaralho> ObterLista(BaralhoEnums.ETipoSkinBaralho tipoBaralho)
        {
            switch (tipoBaralho)
            {
                case BaralhoEnums.ETipoSkinBaralho.Padrao:
                    return ListaBaralhoPadrao;
                case BaralhoEnums.ETipoSkinBaralho.Cartoon:
                    return ListaBaralhoCartoon;
                case BaralhoEnums.ETipoSkinBaralho.Medieval:
                    return ListaBaralhoMedieval;
                case BaralhoEnums.ETipoSkinBaralho.Aquarela:
                    return ListaBaralhoAquarela;
                default:
                    return new();
            }
        }
    }
}
