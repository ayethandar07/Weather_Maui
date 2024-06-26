﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp_Maui
{
    public class RestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<WeatherData> GetWeatherData(string query)
        {
            WeatherData weatherData = null;

            try
            {
                if(!string.IsNullOrEmpty(query))
                {
                    var response = await _client.GetAsync(query);
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        weatherData = JsonConvert.DeserializeObject<WeatherData>(content);
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }

            return weatherData;
        }
    }
}
