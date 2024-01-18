using NewBlackJack.Enums;
using static NewBlackJack.Listas.ListaModelosBaralho;

namespace NewBlackJack.Listas
{
    public class ListaItensLoja
    {
        public class Item
        {

            public string NomeItem { get; set; }
            public BaralhoEnums.ETipoSkinBaralho SkinBaralho { get; set; }
            public int Preco { get; set; }
            public List<string> FotosProdutos { get; set; }
        }

        private static List<Item> ListaProdutos = new()
        {
            new Item {
                NomeItem = "Baralho Aquarela",
                Preco = 200,
                SkinBaralho=BaralhoEnums.ETipoSkinBaralho.Aquarela,
                FotosProdutos = new List<string>()
                {
                    "./Images/BaralhoAquarela/ApresentacaoBaralho/AcesAquarela.png",
                    "./Images/BaralhoAquarela/ApresentacaoBaralho/FigurasAquarela.png"
                }
            },

            new Item {
                NomeItem = "Baralho Desenhado",
                Preco = 300,
                SkinBaralho=BaralhoEnums.ETipoSkinBaralho.Desenhado,
                FotosProdutos = new(),
            },
            new Item {
                NomeItem = "Baralho Cartoon",
                Preco = 350,
                SkinBaralho=BaralhoEnums.ETipoSkinBaralho.Cartoon,
                FotosProdutos = new List<string>(){
                     "./Images/BaralhoCartoon/ApresentacaoBaralho/AcesCartoon.png",
                     "./Images/BaralhoCartoon/ApresentacaoBaralho/FigurasCartoon.png"
                }
            },

            new Item {
                NomeItem = "Baralho Medieval",
                Preco = 500,
                SkinBaralho=BaralhoEnums.ETipoSkinBaralho.Medieval,
                FotosProdutos = new List<string>(){
                    "./Images/BaralhoMedieval/ApresentacaoBaralho/AcesMedieval.png",
                    "./Images/BaralhoMedieval/ApresentacaoBaralho/FigurasMedieval.png"
                }
            }
        };

        public static List<Item> ObterLista()
        {
            return ListaProdutos;
        }
    }
}

