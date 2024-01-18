using NewBlackJack.Dtos;
using NewBlackJack.Listas;
using NewBlackJack.Services.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.WebSockets;
using static NewBlackJack.Listas.ListaModelosBaralho;
using static System.Net.WebRequestMethods;

namespace NewBlackJack.Services
{
    public class BaralhoService : IBaralhoService
    {
        private readonly HttpClient _httpClient;

        public BaralhoService(HttpClient httpCliente)
        {
            _httpClient = httpCliente;
        }

        public async Task<string> ObterBaralho()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://www.deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1");
                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadAsStringAsync();

                JObject jObject = JObject.Parse(result);
                var value = jObject.SelectToken("deck_id").ToString();

                if (string.IsNullOrEmpty(value))
                    return null;

                return value;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public async Task<List<CartaDto>> ObterCartas(int qntdCarta, string baralhoId, List<ModeloBaralho> baralhoSkin)
        {
            try
            {
                var response = await _httpClient.GetAsync($"https://www.deckofcardsapi.com/api/deck/{baralhoId}/draw/?count={qntdCarta}");
                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadAsStringAsync();
                JObject jObject = JObject.Parse(result);

                var values = jObject.SelectToken("cards").ToObject<List<CartaDto>>();

                if (values == null || !values.Any())
                    return new List<CartaDto>();

                foreach(var item in values)
                {
                    var pinba = baralhoSkin.Where(w => w.Codigo == item.Code).Select(s => s.Imagem).FirstOrDefault();
                    item.Image = pinba == null ? item.Image : pinba;
                }

                return values;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new List<CartaDto>();
            }
        }

    }
}
