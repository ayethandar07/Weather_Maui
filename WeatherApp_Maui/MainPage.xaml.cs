namespace WeatherApp_Maui
{
    public partial class MainPage : ContentPage
    {
        RestService 

        public MainPage()
        {
            InitializeComponent();
        }

        async void OnGetWeatherButtonClicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(_cityEntry.Text))
            {

            }
        }
    }

}
