using Newtonsoft.Json.Linq;

namespace STUC
{
    public partial class MainForm : Form
    {
        private const string steamUrl = @"https://steamcommunity.com/market/priceoverview/?&currency=5&appid=730&market_hash_name=";
        private const string csMarketUrl = @"https://market.csgo.com/api/v2/search-item-by-hash-name?key=622dg9ziVGTl0R4egl8vhUg58SLj3u2&hash_name=";
        private Exception ex;
        public MainForm()
        {
            InitializeComponent();
            tbItemName.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    btnCalculate_Click(btnCalculate, e);
                }
            };
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            string item = tbItemName.Text;
            double csMarketPrice = await GetCSMarketPrice(item);
            double steamPrice = await GetSteamPrice(item);
            if (ex == null)
            {
                lblCSMarketPrice.Text = csMarketPrice.ToString();
                lblSteamPrice.Text = steamPrice.ToString();

                steamPrice = Math.Round(steamPrice / 1.15 + 0.01, 2);
                lblResult.Text = steamPrice.ToString();
                lblBonus.Text = $"�����: {Math.Round(steamPrice - csMarketPrice, 2)}";
                return;
            }
            MessageBox.Show("������������ ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ex = null;
        }

        private async Task<double> GetCSMarketPrice(string item)
        {
            return await Task.Run(() =>
            {
                using (HttpClient client = new HttpClient())
                {
                    string response = "";
                    try
                    {
                        response = client.GetStringAsync(csMarketUrl + item).Result;
                    }
                    catch (Exception e)
                    {
                        ex = e;
                        return 0;
                    }
                    JObject json = JObject.Parse(response);

                    JToken priceToken = json.SelectToken("data")?.First?.SelectToken("price");
                    double price = Math.Round(Convert.ToDouble(priceToken) / 100, 2);
                    return price;
                }
            });
        }

        private async Task<double> GetSteamPrice(string item)
        {
            return await Task.Run(() =>
            {
                using (HttpClient client = new HttpClient())
                {
                    string response = "";
                    try
                    {
                        response = client.GetStringAsync(steamUrl + item).Result;
                    }
                    catch (Exception e)
                    {
                        ex = e;
                        return 0;
                    }
                    JObject json = JObject.Parse(response);
                    JToken lowestToken = json.SelectToken("lowest_price");

                    if (lowestToken == null)
                    {
                        return 0;
                    }
                    Invoke(new Action(() =>
                    {
                        lblVolume.Text = json?.SelectToken("volume")?.ToString()?.Replace(",", "");
                    }));

                    string lowestStr = lowestToken.ToString();
                    double lowestPrice = double.Parse(lowestStr.Remove(lowestStr.Length - 5));
                    return Math.Round(lowestPrice * 0.98, 2);
                }
            });
        }
    }
}