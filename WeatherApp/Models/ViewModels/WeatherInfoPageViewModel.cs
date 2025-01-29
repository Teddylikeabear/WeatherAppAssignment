using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Services;

namespace WeatherApp.Models.ViewModels
{
    internal  partial class WeatherInfoPageViewModel : ObservableObject
    {
        private readonly WeatherApiService _weatherApiService;

        public WeatherInfoPageViewModel()
        {
            _weatherApiService = new WeatherApiService();
        }

        [ObservableProperty]
        private string latitude;

        [ObservableProperty]
        private string longitude;

        [ObservableProperty]
        private string weatherIcon;

        [ObservableProperty]
        private string temperature;

        [ObservableProperty]
        private string weatherDescription;

        [ObservableProperty]
        private string location;

        [ObservableProperty]
        private string humidity;

        [ObservableProperty]
        private string cloudCoverLevel;

        [ObservableProperty]
        private string isDay;


        [RelayCommand]//to bind to the button
        private async Task FetchWeatherInformation()
        { 
            var weatherApiResponse = await _weatherApiService.GetWeatherInformation(latitude, longitude);
            if (weatherApiResponse != null)
            {
                WeatherIcon = weatherApiResponse.Current.Weather_icons[0];
                Temperature = $"{weatherApiResponse.Current.Temperature}C";
                Location = $"{weatherApiResponse.Location.Name},{weatherApiResponse.Location.region}, {weatherApiResponse.Location.Country}";
                WeatherDescription = weatherApiResponse.Current.Weather_descriptions[0];
                //Humidity = weatherApiResponse.Current.Humidity;
                CloudCoverLevel = weatherApiResponse.Current.Cloudcover_level;
                IsDay = weatherApiResponse.Current.Is_day.ToUpper();
            
            }

        }
    }
}
