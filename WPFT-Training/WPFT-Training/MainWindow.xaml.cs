using System.Collections.Generic;
using System.Windows;
using System.Net.Http;
using Newtonsoft.Json;
using WPFT_Training.DTO;

namespace WPFT_Training
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
 
    public partial class MainWindow : Window
    {
     
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void loadButton_Click(object sender, RoutedEventArgs e)
        {

            var client = new HttpClient();
            var response = await client.GetAsync("https://api.coinmarketcap.com/v1/ticker/");
            var content = await response.Content.ReadAsStringAsync();
            var tradeableCoinsList = JsonConvert.DeserializeObject<List<TradeableCoin>>(content);

            this.TradeableCoinsDataGrid.ItemsSource = tradeableCoinsList;

        }
    }
    
}
