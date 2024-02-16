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
            public string FotoPrincipal { get; set; }
            public List<string> FotosProdutos { get; set; }
            public bool Indisponivel { get; set; } = false;
        }

        private static List<Item> ListaProdutos = new()
        {
            new Item {
                NomeItem = "Baralho Aquarela",
                Preco = 200,
                SkinBaralho=BaralhoEnums.ETipoSkinBaralho.Aquarela,
                FotoPrincipal = "./Images/BaralhoAquarela/ApresentacaoBaralho/PrincipalLoja.png",
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
                FotoPrincipal = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e2/A_studio_image_of_a_hand_of_playing_cards._MOD_45148377.jpg/258px-A_studio_image_of_a_hand_of_playing_cards._MOD_45148377.jpg",
                FotosProdutos = new(),
                Indisponivel = true
            },
            new Item {
                NomeItem = "Baralho Cartoon",
                Preco = 350,
                SkinBaralho=BaralhoEnums.ETipoSkinBaralho.Cartoon,
                FotoPrincipal = "./Images/BaralhoCartoon/ApresentacaoBaralho/PrincipalLoja.png",
                FotosProdutos = new List<string>(){
                     "./Images/BaralhoCartoon/ApresentacaoBaralho/AcesCartoon.png",
                     "./Images/BaralhoCartoon/ApresentacaoBaralho/FigurasCartoon.png"
                }
            },

            new Item {
                NomeItem = "Baralho Medieval",
                Preco = 500,
                SkinBaralho=BaralhoEnums.ETipoSkinBaralho.Medieval,
                FotoPrincipal = "./Images/BaralhoMedieval/ApresentacaoBaralho/PrincipalLoja.png",
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

