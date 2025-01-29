using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApp.Models.ApiModels
{
    // class WeatherApiResponse
    //{
    //}

    public class WeatherApiResponse
    {
        [JsonPropertyName("request")]
        public WeatherApiResponseRequest Request { get; set; }

        [JsonPropertyName("location")]
        public WeatherApiResponseLocation Location { get; set; }

        [JsonPropertyName("current")]
        public WeatherApiResponseCurrent Current { get; set; }
    }

    public class WeatherApiResponseRequest
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("query")]
        public string Query { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class WeatherApiResponseLocation
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("region")]
        public string region { get; set; }

        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        [JsonPropertyName("lon")]
        public string Lon { get; set; }

        [JsonPropertyName("timezone_id")]
        public string timezone_id { get; set; }

        [JsonPropertyName("localtime")]
        public string Localtime { get; set; }

        [JsonPropertyName("localtime_epoch")]
        public int Localtime_epoch { get; set; }

        [JsonPropertyName("utc_offset")]
        public string Utc_offset { get; set; }
    }

    public class WeatherApiResponseCurrent
    {
        internal string Cloudcover_level;

        [JsonPropertyName("observation_time")]
        public string Observation_time { get; set; }

        [JsonPropertyName("temperature")]
        public int Temperature { get; set; }

        [JsonPropertyName("weather_code")]
        public int Weather_code { get; set; }

        [JsonPropertyName("weather_icons")]
        public string[] Weather_icons { get; set; }

        [JsonPropertyName("weather_descriptions")]
        public string[] Weather_descriptions { get; set; }

        [JsonPropertyName("wind_speed")]
        public int Wind_speed { get; set; }

        [JsonPropertyName("wind_degree")]
        public int Wind_degree { get; set; }

        [JsonPropertyName("wind_dir")]
        public string Wind_dir { get; set; }

        [JsonPropertyName("pressure")]
        public int Pressure { get; set; }

        [JsonPropertyName("precip")]
        public int Precip { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

        [JsonPropertyName("cloudcover")]
        public int Cloudcover { get; set; }

        [JsonPropertyName("feelslike")]
        public int Feelslike { get; set; }

        [JsonPropertyName("uv_index")]
        public int Uv_index { get; set; }

        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }

        [JsonPropertyName("is_day")]
        public string Is_day { get; set; }
    }

}
