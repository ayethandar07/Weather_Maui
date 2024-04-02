namespace WeatherApp_Maui
{
    public partial class MainPage : ContentPage
    {
        RestService _restService;

        public MainPage()
        {
            InitializeComponent();
            _restService = new RestService();
        }

        async void OnGetWeatherButtonClicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(_cityEntry.Text))
            {
                string query = GenerateRequestURL(Constants.OpenWeatherMapEndpoint);

                WeatherData weatherData = await 
                    _restService.
                    GetWeatherData(query);

                BindingContext = weatherData;
            }
        }

        string GenerateRequestURL(string endPoint)
        {
            string requestUri = endPoint;
            requestUri += $"?q={_cityEntry.Text}";
            requestUri += "&units=imperial";
            requestUri += $"&APPID={Constants.OpenWeatherMapAPIKey}";
            return requestUri;
        }
    }

}
